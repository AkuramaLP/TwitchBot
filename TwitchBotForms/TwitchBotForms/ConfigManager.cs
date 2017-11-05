using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitchBotForms
{
    public class ConfigManager
    {
        private string filePath;
        private string folderPath;

        public void SaveConfigs(List<TextBox> TextBoxes)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filePath))
            {
                foreach (TextBox CurrentBox in TextBoxes)
                {
                    file.WriteLine(CurrentBox.Text);
                }
            }
        }

        public void LoadConfigs(List<TextBox> TextBoxes)
        {
            string[] lines = System.IO.File.ReadAllLines(filePath);
            if (lines.Length == 0)
            {
                SaveConfigs(TextBoxes);
            }
            else
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    TextBoxes[i].Text = lines[i];
                }
            }
        }

        public void CheckIfFileExists()
        {
            if (System.IO.File.Exists(filePath))
            {
                
            }
            else
            {
                System.IO.File.Create(filePath).Close();
            }
        }

        public void CheckIfFolderExists()
        {
            if (System.IO.Directory.Exists(folderPath))
            {
                CheckIfFileExists();
            }
            else
            {
                System.IO.Directory.CreateDirectory(folderPath);
                CheckIfFileExists();
            }
        }

        public ConfigManager(string filePath, string folderPath)
        {
            this.filePath = filePath;
            this.folderPath = folderPath;
        }
    }
}
