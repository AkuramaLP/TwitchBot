using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitchBotForms.Forms;

namespace TwitchBotForms
{
    public partial class Form1 : Form
    {
        private IRCClient irc;   
        public static string clientID = "9olmkri5dqt8hrqu93audukkb1pxzn";
        public static string FilePath = @".\Data\Config.txt";
        public static string FolderPath = @".\Data\";
        private List<ChatMSG> chatMessages = new List<ChatMSG>();
        private ConfigManager cfgManager = new ConfigManager(FilePath, FolderPath);
        public List<SoundCommandClass> sounds = new List<SoundCommandClass>();

        public List<TextBox> TextBoxs = new List<TextBox>();

        public static Form1 manager;

        public Form1()
        {
            InitializeComponent();

            manager = this;

            TextBoxs.Add(IP_TextBox);
            TextBoxs.Add(Port_TextBox);
            TextBoxs.Add(Username_TextBox);
            TextBoxs.Add(Password_TextBox);
            TextBoxs.Add(ChannelName_TextBox);

            cfgManager.CheckIfFolderExists();
            cfgManager.LoadConfigs(TextBoxs);

            //TODO: ADD DYNAMIC SOUND INJECTIOM WITH FILE SELECTION
            sounds.Add(new SoundCommandClass("pika", "!pika", @".\Data\Sound\pika.wav"));
            sounds.Add(new SoundCommandClass("load", "!load", @".\Data\Sound\load.wav"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (irc != null)
            {
                irc.Disconnect();
            }
            irc = new IRCClient(IP_TextBox.Text, int.Parse(Port_TextBox.Text), Username_TextBox.Text, Password_TextBox.Text, ChannelName_TextBox.Text, this);
            cfgManager.CheckIfFolderExists();
            cfgManager.SaveConfigs(TextBoxs);
            irc.Connect();
            UpdateViewers();
            realChatBox.Clear();
        }

        public void AddMessage(ChatMSG msg)
        {
            chatMessages.Add(msg);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            while (chatMessages.Count > 0)
            {
                if (chatMessages[0].name != "" && chatMessages[0].msg != "")
                {
                    realChatBox.SelectionStart = realChatBox.TextLength;
                    realChatBox.SelectionLength = 0;
                    Font name = new Font(realChatBox.Font.FontFamily, 10, FontStyle.Bold);
                    realChatBox.SelectionFont = name;
                    realChatBox.SelectionColor = chatMessages[0].color;
                    realChatBox.AppendText(chatMessages[0].name + ": ");

                    realChatBox.SelectionStart = realChatBox.TextLength;
                    realChatBox.SelectionLength = 0;
                    Font msg = new Font(realChatBox.Font.FontFamily, 8, FontStyle.Regular);
                    realChatBox.SelectionFont = msg;
                    realChatBox.SelectionColor = Color.Black;
                    realChatBox.AppendText(chatMessages[0].msg);
                }


                ChatBox.AppendText(chatMessages[0].rawMsg);
                chatMessages.RemoveAt(0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (irc != null)
            {
                irc.SendMessage("!join bard priest");
            }
        }

        private void ChatBox_TextChanged(object sender, EventArgs e)
        {
            ChatBox.SelectionStart = ChatBox.Text.Length;
            ChatBox.ScrollToCaret();
        }

        private void SendMessage_Click(object sender, EventArgs e)
        {
            irc.SendMessage(TextInput.Text);
            TextInput.Clear();
        }

        async void UpdateViewers()
        {
            UpdateViewer.Enabled = false;
            UpdateViewer.Text = "Refreshing....";
            timer2.Stop();
            viewerList.Items.Clear();
            List<string> viewers = new List<string>();
            await Task.Run(() => { viewers = ViewManager.GetViewers(); });
            foreach (string names in viewers)
            {
                viewerList.Items.Add(names);
            }
            UpdateViewer.Enabled = true;
            UpdateViewer.Text = "Update Viewers";
            timer2.Start();
        }

        private void UpdateViewer_Click(object sender, EventArgs e)
        {
            UpdateViewers();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            UpdateViewers();
        }

        private void realChatBox_TextChanged(object sender, EventArgs e)
        {
            realChatBox.SelectionStart = ChatBox.Text.Length;
            realChatBox.ScrollToCaret();
        }

        private void add_Sound_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}