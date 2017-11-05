namespace TwitchBotForms
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.ChatBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.IP_TextBox = new System.Windows.Forms.TextBox();
            this.Port_TextBox = new System.Windows.Forms.TextBox();
            this.Username_TextBox = new System.Windows.Forms.TextBox();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.ChannelName_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.SendMessage = new System.Windows.Forms.Button();
            this.TextInput = new System.Windows.Forms.TextBox();
            this.realChatBox = new System.Windows.Forms.RichTextBox();
            this.viewerList = new System.Windows.Forms.ListBox();
            this.UpdateViewer = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.add_Sound = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChatBox
            // 
            this.ChatBox.BackColor = System.Drawing.Color.Black;
            this.ChatBox.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ChatBox.Location = new System.Drawing.Point(987, 243);
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.Size = new System.Drawing.Size(548, 316);
            this.ChatBox.TabIndex = 0;
            this.ChatBox.Text = "";
            this.ChatBox.TextChanged += new System.EventHandler(this.ChatBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1433, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "GO!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IP_TextBox
            // 
            this.IP_TextBox.Location = new System.Drawing.Point(1106, 12);
            this.IP_TextBox.Name = "IP_TextBox";
            this.IP_TextBox.Size = new System.Drawing.Size(100, 20);
            this.IP_TextBox.TabIndex = 2;
            this.IP_TextBox.Text = "irc.twitch.tv";
            // 
            // Port_TextBox
            // 
            this.Port_TextBox.Location = new System.Drawing.Point(1106, 63);
            this.Port_TextBox.Name = "Port_TextBox";
            this.Port_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Port_TextBox.TabIndex = 3;
            this.Port_TextBox.Text = "6667";
            // 
            // Username_TextBox
            // 
            this.Username_TextBox.Location = new System.Drawing.Point(1106, 119);
            this.Username_TextBox.Name = "Username_TextBox";
            this.Username_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Username_TextBox.TabIndex = 4;
            this.Username_TextBox.Text = "akuramabot";
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Location = new System.Drawing.Point(1106, 173);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.PasswordChar = '*';
            this.Password_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Password_TextBox.TabIndex = 5;
            this.Password_TextBox.Text = "oauth:287klitbcyf2yfgstkigaa6rrl6kod";
            // 
            // ChannelName_TextBox
            // 
            this.ChannelName_TextBox.Location = new System.Drawing.Point(1106, 217);
            this.ChannelName_TextBox.Name = "ChannelName_TextBox";
            this.ChannelName_TextBox.Size = new System.Drawing.Size(100, 20);
            this.ChannelName_TextBox.TabIndex = 6;
            this.ChannelName_TextBox.Text = "janoschexelive";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(984, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(984, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(984, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(984, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(984, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Channel Name:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1433, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 73);
            this.button2.TabIndex = 12;
            this.button2.Text = "SendMessages";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SendMessage
            // 
            this.SendMessage.Location = new System.Drawing.Point(987, 582);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Size = new System.Drawing.Size(186, 23);
            this.SendMessage.TabIndex = 13;
            this.SendMessage.Text = "Send Message";
            this.SendMessage.UseVisualStyleBackColor = true;
            this.SendMessage.Click += new System.EventHandler(this.SendMessage_Click);
            // 
            // TextInput
            // 
            this.TextInput.Location = new System.Drawing.Point(15, 585);
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(954, 20);
            this.TextInput.TabIndex = 14;
            // 
            // realChatBox
            // 
            this.realChatBox.Location = new System.Drawing.Point(13, 12);
            this.realChatBox.Name = "realChatBox";
            this.realChatBox.Size = new System.Drawing.Size(954, 547);
            this.realChatBox.TabIndex = 15;
            this.realChatBox.Text = "";
            this.realChatBox.TextChanged += new System.EventHandler(this.realChatBox_TextChanged);
            // 
            // viewerList
            // 
            this.viewerList.FormattingEnabled = true;
            this.viewerList.Location = new System.Drawing.Point(1542, 13);
            this.viewerList.Name = "viewerList";
            this.viewerList.Size = new System.Drawing.Size(187, 550);
            this.viewerList.TabIndex = 16;
            // 
            // UpdateViewer
            // 
            this.UpdateViewer.Location = new System.Drawing.Point(1433, 152);
            this.UpdateViewer.Name = "UpdateViewer";
            this.UpdateViewer.Size = new System.Drawing.Size(102, 23);
            this.UpdateViewer.TabIndex = 17;
            this.UpdateViewer.Text = "Update Viewers";
            this.UpdateViewer.UseVisualStyleBackColor = true;
            this.UpdateViewer.Click += new System.EventHandler(this.UpdateViewer_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 300000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // add_Sound
            // 
            this.add_Sound.Location = new System.Drawing.Point(1433, 191);
            this.add_Sound.Name = "add_Sound";
            this.add_Sound.Size = new System.Drawing.Size(103, 23);
            this.add_Sound.TabIndex = 18;
            this.add_Sound.Text = "Add Sound";
            this.add_Sound.UseVisualStyleBackColor = true;
            this.add_Sound.Click += new System.EventHandler(this.add_Sound_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1741, 617);
            this.Controls.Add(this.add_Sound);
            this.Controls.Add(this.UpdateViewer);
            this.Controls.Add(this.viewerList);
            this.Controls.Add(this.realChatBox);
            this.Controls.Add(this.TextInput);
            this.Controls.Add(this.SendMessage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChannelName_TextBox);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.Username_TextBox);
            this.Controls.Add(this.Port_TextBox);
            this.Controls.Add(this.IP_TextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ChatBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ChatBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox IP_TextBox;
        private System.Windows.Forms.TextBox Port_TextBox;
        private System.Windows.Forms.TextBox Username_TextBox;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SendMessage;
        private System.Windows.Forms.TextBox TextInput;
        public System.Windows.Forms.RichTextBox realChatBox;
        private System.Windows.Forms.ListBox viewerList;
        public System.Windows.Forms.TextBox ChannelName_TextBox;
        private System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.Button UpdateViewer;
        private System.Windows.Forms.Button add_Sound;
    }
}

