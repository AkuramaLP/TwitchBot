using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace TwitchBotForms
{
    public class SoundCommandClass
    {
        public string name;
        public string command;
        public string soundFilePath;

        public SoundCommandClass(string Name, string Command, string SoundFilePath)
        {
            this.name = Name;
            this.command = Command;
            this.soundFilePath = SoundFilePath;
        }

        public SoundCommandClass()
        {
            
        }

        public void PlaySound()
        {
            if (System.IO.File.Exists(soundFilePath))
            {
                SoundPlayer sound = new SoundPlayer(soundFilePath);
                sound.Play();
            }
            else
            {
                Console.WriteLine("File not Exists");
            }
        }
    }
}
