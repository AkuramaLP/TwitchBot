using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TwitchBotForms.Forms
{
    public partial class Form2 : Form
    {
        OpenFileDialog openFile = new OpenFileDialog();
        private string fileLocation;

        public Form1 form1 = Form1.manager;

        public Form2()
        {
            InitializeComponent();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                fileLocation = openFile.FileName;
                FilePath_TextBox.Text = fileLocation;
            }
        }

        private void AddSound_Click(object sender, EventArgs e)
        {
            //if (name_TextBox.Text != "" && command_TextBox.Text != "" && FilePath_TextBox.Text != "")
            //{
            SoundCommandClass add = new SoundCommandClass(name_TextBox.Text, command_TextBox.Text, fileLocation);
                form1.sounds.Add(add);
            ExportSounds();
            //}
            //else
            //{
            //    Console.WriteLine("eins von dem ist leer");
            //}
        }

        public void ExportSounds()
        {
            foreach (SoundCommandClass sounds in form1.sounds)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(SoundCommandClass));
                TextWriter tw = new StreamWriter(@"./Data/test.xml", true);
                xmlSerializer.Serialize(tw, sounds);
                tw.Close();
            }
        }
    }
}
