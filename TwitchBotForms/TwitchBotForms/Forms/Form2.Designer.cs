namespace TwitchBotForms.Forms
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddSound = new System.Windows.Forms.Button();
            this.name_Label = new System.Windows.Forms.Label();
            this.command_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name_TextBox = new System.Windows.Forms.TextBox();
            this.OpenFile = new System.Windows.Forms.Button();
            this.FilePath_TextBox = new System.Windows.Forms.TextBox();
            this.command_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddSound
            // 
            this.AddSound.Location = new System.Drawing.Point(180, 398);
            this.AddSound.Name = "AddSound";
            this.AddSound.Size = new System.Drawing.Size(75, 23);
            this.AddSound.TabIndex = 0;
            this.AddSound.Text = "Add";
            this.AddSound.UseVisualStyleBackColor = true;
            this.AddSound.Click += new System.EventHandler(this.AddSound_Click);
            // 
            // name_Label
            // 
            this.name_Label.AutoSize = true;
            this.name_Label.Location = new System.Drawing.Point(13, 38);
            this.name_Label.Name = "name_Label";
            this.name_Label.Size = new System.Drawing.Size(33, 13);
            this.name_Label.TabIndex = 1;
            this.name_Label.Text = "name";
            // 
            // command_label
            // 
            this.command_label.AutoSize = true;
            this.command_label.Location = new System.Drawing.Point(13, 102);
            this.command_label.Name = "command_label";
            this.command_label.Size = new System.Drawing.Size(53, 13);
            this.command_label.TabIndex = 2;
            this.command_label.Text = "command";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "filepath";
            // 
            // name_TextBox
            // 
            this.name_TextBox.Location = new System.Drawing.Point(70, 38);
            this.name_TextBox.Name = "name_TextBox";
            this.name_TextBox.Size = new System.Drawing.Size(185, 20);
            this.name_TextBox.TabIndex = 4;
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(371, 158);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(75, 23);
            this.OpenFile.TabIndex = 5;
            this.OpenFile.Text = "button1";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // FilePath_TextBox
            // 
            this.FilePath_TextBox.Location = new System.Drawing.Point(70, 160);
            this.FilePath_TextBox.Name = "FilePath_TextBox";
            this.FilePath_TextBox.Size = new System.Drawing.Size(185, 20);
            this.FilePath_TextBox.TabIndex = 6;
            // 
            // command_TextBox
            // 
            this.command_TextBox.Location = new System.Drawing.Point(70, 99);
            this.command_TextBox.Name = "command_TextBox";
            this.command_TextBox.Size = new System.Drawing.Size(185, 20);
            this.command_TextBox.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 477);
            this.Controls.Add(this.command_TextBox);
            this.Controls.Add(this.FilePath_TextBox);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.name_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.command_label);
            this.Controls.Add(this.name_Label);
            this.Controls.Add(this.AddSound);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddSound;
        private System.Windows.Forms.Label name_Label;
        private System.Windows.Forms.Label command_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_TextBox;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.TextBox FilePath_TextBox;
        private System.Windows.Forms.TextBox command_TextBox;
    }
}