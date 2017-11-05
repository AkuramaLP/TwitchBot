using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchBotForms
{
    public class ChatMSG
    {
        public string rawMsg;
        public string name;
        public string msg;
        public Color color;

        public ChatMSG(string rMsg, string name = "", string msg = "", Color? color = null) //Fragezeichen hinter typ == darf null sein!!!!! 
        {
            this.rawMsg = rMsg;
            this.name = name;
            this.msg = msg;
            this.color = color??Color.Black;                                                //Wenn es null ist benutze das da! Das Andere
        }
    }
}
