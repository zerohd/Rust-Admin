namespace Rust_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rconpass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.saveinterval = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.serverseed = new System.Windows.Forms.TextBox();
            this.ServerHostname2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.WorldSize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MaxPlayers = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Rconport = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.serverPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.serverdescription = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.imageurl = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.serveridentity = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rust Server Folder:";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(15, 405);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 48);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wipe Options";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(83, 21);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(67, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Full wipe";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Map wipe";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 423);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Execute";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "SteamCMD Folder :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 20);
            this.textBox2.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(219, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 20);
            this.button3.TabIndex = 6;
            this.button3.Text = "Browse";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(15, 350);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 49);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Map Options";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.serveridentity);
            this.groupBox3.Controls.Add(this.imageurl);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.serverdescription);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.rconpass);
            this.groupBox3.Controls.Add(this.saveinterval);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.serverseed);
            this.groupBox3.Controls.Add(this.ServerHostname2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.WorldSize);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.MaxPlayers);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.Rconport);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.serverPort);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(15, 98);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 246);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Server Options";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(136, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Rcom pass";
            // 
            // rconpass
            // 
            this.rconpass.Location = new System.Drawing.Point(207, 182);
            this.rconpass.MaxLength = 10;
            this.rconpass.Name = "rconpass";
            this.rconpass.PasswordChar = '*';
            this.rconpass.Size = new System.Drawing.Size(51, 20);
            this.rconpass.TabIndex = 15;
            this.rconpass.TextChanged += new System.EventHandler(this.rcompass_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(136, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Save Interval";
            // 
            // saveinterval
            // 
            this.saveinterval.Location = new System.Drawing.Point(207, 132);
            this.saveinterval.MaxLength = 6;
            this.saveinterval.Name = "saveinterval";
            this.saveinterval.Size = new System.Drawing.Size(51, 20);
            this.saveinterval.TabIndex = 13;
            this.saveinterval.TextChanged += new System.EventHandler(this.saveinterval_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Server seed";
            // 
            // serverseed
            // 
            this.serverseed.Location = new System.Drawing.Point(74, 184);
            this.serverseed.MaxLength = 6;
            this.serverseed.Name = "serverseed";
            this.serverseed.Size = new System.Drawing.Size(51, 20);
            this.serverseed.TabIndex = 11;
            this.serverseed.TextChanged += new System.EventHandler(this.serverseed_TextChanged);
            // 
            // ServerHostname2
            // 
            this.ServerHostname2.Location = new System.Drawing.Point(74, 23);
            this.ServerHostname2.MaxLength = 999999999;
            this.ServerHostname2.Name = "ServerHostname2";
            this.ServerHostname2.Size = new System.Drawing.Size(184, 20);
            this.ServerHostname2.TabIndex = 10;
            this.ServerHostname2.TextChanged += new System.EventHandler(this.ServerHostname_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(136, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "World Size";
            // 
            // WorldSize
            // 
            this.WorldSize.Location = new System.Drawing.Point(207, 157);
            this.WorldSize.MaxLength = 6;
            this.WorldSize.Name = "WorldSize";
            this.WorldSize.Size = new System.Drawing.Size(51, 20);
            this.WorldSize.TabIndex = 8;
            this.WorldSize.TextChanged += new System.EventHandler(this.WorldSize_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Max Players";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // MaxPlayers
            // 
            this.MaxPlayers.Location = new System.Drawing.Point(74, 210);
            this.MaxPlayers.MaxLength = 6;
            this.MaxPlayers.Name = "MaxPlayers";
            this.MaxPlayers.Size = new System.Drawing.Size(51, 20);
            this.MaxPlayers.TabIndex = 6;
            this.MaxPlayers.TextChanged += new System.EventHandler(this.MaxPlayers_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rcon port";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Rconport
            // 
            this.Rconport.Location = new System.Drawing.Point(74, 158);
            this.Rconport.MaxLength = 6;
            this.Rconport.Name = "Rconport";
            this.Rconport.Size = new System.Drawing.Size(51, 20);
            this.Rconport.TabIndex = 2;
            this.Rconport.TextChanged += new System.EventHandler(this.Rcon_port_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Server port";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // serverPort
            // 
            this.serverPort.Location = new System.Drawing.Point(74, 132);
            this.serverPort.MaxLength = 6;
            this.serverPort.Name = "serverPort";
            this.serverPort.Size = new System.Drawing.Size(51, 20);
            this.serverPort.TabIndex = 0;
            this.serverPort.TextChanged += new System.EventHandler(this.serverPort_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Server Name";
            // 
            // serverdescription
            // 
            this.serverdescription.Location = new System.Drawing.Point(74, 49);
            this.serverdescription.MaxLength = 999999999;
            this.serverdescription.Name = "serverdescription";
            this.serverdescription.Size = new System.Drawing.Size(184, 20);
            this.serverdescription.TabIndex = 18;
            this.serverdescription.TextChanged += new System.EventHandler(this.serverdescription_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Description ";
            // 
            // imageurl
            // 
            this.imageurl.Location = new System.Drawing.Point(74, 75);
            this.imageurl.MaxLength = 999999999;
            this.imageurl.Name = "imageurl";
            this.imageurl.Size = new System.Drawing.Size(184, 20);
            this.imageurl.TabIndex = 20;
            this.imageurl.TextChanged += new System.EventHandler(this.imageurl_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Image URL";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Identity";
            // 
            // serveridentity
            // 
            this.serveridentity.Location = new System.Drawing.Point(74, 101);
            this.serveridentity.MaxLength = 999999999;
            this.serveridentity.Name = "serveridentity";
            this.serveridentity.Size = new System.Drawing.Size(184, 20);
            this.serveridentity.TabIndex = 21;
            this.serveridentity.TextChanged += new System.EventHandler(this.serveridentity_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(131, 210);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 21);
            this.button4.TabIndex = 23;
            this.button4.Text = "View raw config";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 458);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rust Admin : By Nurd";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox serverPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Rconport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MaxPlayers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox WorldSize;
        private System.Windows.Forms.TextBox ServerHostname2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox serverseed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox saveinterval;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox rconpass;
        private System.Windows.Forms.TextBox serverdescription;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox imageurl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox serveridentity;
        private System.Windows.Forms.Button button4;
    }
}

