using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Windows.Forms;

namespace TwitchBotForms
{
    class IRCClient
    {
        public string userName;
        public string channelName;
        public string password;
        public string ip;
        public string viewrListURL;
        
        public int port;

        public Form1 form1;

        public RichTextBox chatBox;

        private Socket socket;

        public IRCClient(string ip, int port, string userName, string password, string channelName, Form1 form1)
        {
            this.userName = userName;
            this.password = password;
            this.channelName = channelName;
            this.ip = ip;
            this.port = port;
            this.form1 = form1;
            this.viewrListURL = "https://tmi.twitch.tv/group/user/" + channelName + "/chatters";
        }

        public void Connect()
        {
            Console.WriteLine("Connecting to " + ip + " : " + port);
            Console.WriteLine("Creating Socket.");
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.BeginConnect(ip, port, ConnectCallback, socket);
        }

        void ConnectCallback(IAsyncResult res)
        {
            Socket client = (Socket)res.AsyncState;
            try
            {
                client.EndConnect(res);
                StateObject state = new StateObject();
                state.workSocket = client;
                client.BeginReceive(state.buffer, 0, StateObject.bufferSize, SocketFlags.None, ReceiveCallback, state);
                SendCommand("Pass " + password);
                SendCommand("USER " + userName);
                SendCommand("NICK " + userName);
                SendCommand("JOIN #" + channelName);
                SendCommand("CAP REQ :twitch.tv/commands");
                SendCommand("CAP REQ :twitch.tv/tags");
                SendMessage("Guten Tag der Akuramabot ist nun im diesem Channel");
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        

        public void GetIrcMessage(string message, bool fromClient = false)
        {
            if(fromClient == false)
            {
                if (message.Contains("PRIVMSG"))
                    form1.AddMessage(ExtractMessage(message));
            }
            else
            {
                ChatMSG cMSG = new ChatMSG(message, userName, message, Color.Black);
                form1.AddMessage(cMSG);
            }
            
        }

        void SendCommand(string message)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(message + "\r\n");
            socket.Send(buffer, buffer.Length, SocketFlags.None);

            ChatMSG cMSG = new ChatMSG(message, "", "", Color.Black);
            Console.WriteLine(message);
            form1.AddMessage(cMSG);
        }

        public void SendMessage(string msg)
        {
            string saveMsg = ":" + userName + "!" + userName +
                             "@" + userName + ".tmi.twitch.tv PRIVMSG #" + channelName + " :" + msg;
            SendCommand(saveMsg);
            GetIrcMessage(msg + '\n', true);
        }

        void ReceiveCallback(IAsyncResult res)
        {
            StateObject state = (StateObject)res.AsyncState;
            Socket client = state.workSocket;

            try
            {
                int bytesRead = client.EndReceive(res);
                if (bytesRead > 0)
                {
                    string msg = Encoding.UTF8.GetString(state.buffer, 0, bytesRead);
                    GetIrcMessage(msg);
                    checkMessage(msg);
                }
                client.BeginReceive(state.buffer, 0, StateObject.bufferSize, SocketFlags.None, ReceiveCallback, state);
            }
            catch
            {
                Console.WriteLine("Connection to server lost!");
            }
        }

        void checkMessage(string message)
        {
            if (message.Contains("PING"))
            {
                SendCommand("PONG tmi.twitch.tv");
            }
            foreach (SoundCommandClass sound in form1.sounds)
            {
                if (message.Contains(sound.command))
                {
                    sound.PlaySound();
                }
            }
            if (message.Contains("!sounds"))
            {
                string combined = "List of all Sounds: ";
                foreach (SoundCommandClass sound in form1.sounds)
                {
                    combined += sound.command + " ,";
                }

                SendMessage(combined);
            }
        }

        public void Disconnect()
        {
            if (socket != null && socket.Connected)
            {
                socket.Shutdown(SocketShutdown.Both);
                Console.WriteLine("Connection to server lost!");
                socket.Close();
            }
        }

        ChatMSG ExtractMessage(string rawMsg)
        {
            ChatMSG output = new ChatMSG(rawMsg);

            int nameIndex = rawMsg.IndexOf("display-name=") + "display-name=".Length;
            if (nameIndex > -1)
            {
                int nameEndIndex = rawMsg.IndexOf(";", nameIndex);
                output.name = rawMsg.Substring(nameIndex, nameEndIndex - nameIndex);
            }

            int colorIndex = rawMsg.IndexOf("color=") + "color=".Length;

            if (colorIndex > -1)
            {
                int colorEndIndex = rawMsg.IndexOf(";", colorIndex);
                string color = rawMsg.Substring(colorIndex, colorEndIndex - colorIndex);
                if (color == "")
                {
                    color = "#000000";
                }
                output.color = HexToColor(color);
            }

            int messageIndex = rawMsg.IndexOf("PRIVMSG");
            int messageStartIndex = rawMsg.IndexOf(':', messageIndex) + 1;
            string msg = rawMsg.Substring(messageStartIndex);
            output.msg = msg;

            return output;
        }

        Color HexToColor(string color)
        {
            if (color.IndexOf("#") != -1)
            {
                color = color.Replace("#", "");
            }

            int r = 0;
            int g = 0;
            int b = 0;

            if (color.Length == 6)
            {
                r = int.Parse(color.Substring(0, 2), NumberStyles.AllowHexSpecifier);
                g = int.Parse(color.Substring(2, 2), NumberStyles.AllowHexSpecifier);
                b = int.Parse(color.Substring(4, 2), NumberStyles.AllowHexSpecifier);
            }

            return Color.FromArgb(r, g, b);
        }
    }

    public class StateObject
    {
        public Socket workSocket = null;
        public const int bufferSize = 1024;
        public byte[] buffer = new byte[bufferSize];
        public StringBuilder sb = new StringBuilder();
    }
}
