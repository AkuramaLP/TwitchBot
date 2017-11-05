using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TwitchBotForms
{
    public enum EViewerAuthority
    {
        none,
        moderators,
        staff,
        admins,
        global_mods,
        viewers
    }

    public class ViewManager
    {
        internal static List<string> DecodeJsonViewers(string str)
        {
            List<string> viewers = new List<string>();

            for (int i = 1; i < Enum.GetValues(typeof(EViewerAuthority)).Length; ++i)
            {
                string viewType = "\"" + Enum.GetNames(typeof(EViewerAuthority))[i] + "\": [";
                int firstNamePos = str.IndexOf(viewType) + viewType.Length;
                if (str[firstNamePos] != ']')
                {
                    int endName = str.IndexOf(']', firstNamePos);
                    string allNames = str.Substring(firstNamePos, endName - firstNamePos);
                    string[] names = allNames.Split(',');
                    foreach (string s in names)
                    {
                        string name = s.Trim().Substring(1, s.Trim().Length - 2);
                        viewers.Add(name);
                    }
                }
            }
            return viewers;
        }

        internal static List<string> GetViewers()
        {
            WebClient web = new WebClient();
            Stream stream = web.OpenRead("https://tmi.twitch.tv/group/user/" + Form1.manager.ChannelName_TextBox.Text + "/chatters");
            using (StreamReader reader = new StreamReader(stream))
            {
                string text = reader.ReadToEnd();
                List<string> tmp = DecodeJsonViewers(text);
                return new List<string>(tmp);
            }
        }
    }
}
