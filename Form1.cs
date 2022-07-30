using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;


namespace Rust_Admin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadup();
            
        }


        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChooseFolderServerFolder();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChooseSteamCMDFolder();
        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox2.Checked == true)
            {
                
                checkBox1.Checked = true;
                checkBox1.Enabled = false;
            }
            else if (checkBox2.Checked == false) 
            {
                checkBox1.Enabled = true;
                checkBox1.Checked = false;
            };
        }
        public void ChooseFolderServerFolder()
        {

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;

                // Save path to setting : App.config
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                config.AppSettings.Settings["PATH_ServerFolder"].Value = textBox1.Text.ToString();
                config.Save(ConfigurationSaveMode.Modified);

            }
        }
        public void ChooseSteamCMDFolder()
        {

            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = folderBrowserDialog2.SelectedPath;

                // Save path to setting : App.config
                Configuration config2 = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                config2.AppSettings.Settings["PATH_SteamCMD"].Value = textBox2.Text.ToString();
                config2.Save(ConfigurationSaveMode.Modified);

            }
        }

        public void loadup()
        {
            // Read path settings 
            string PATH_ServerFolder = ConfigurationManager.AppSettings.Get("PATH_ServerFolder");
            if (PATH_ServerFolder != null)
            {
                textBox1.Text = PATH_ServerFolder;
            }

            string PATH_SteamCMD = ConfigurationManager.AppSettings.Get("PATH_SteamCMD");
            if (PATH_SteamCMD != null)
            {
                textBox2.Text = PATH_SteamCMD;
            }

            string server_port = ConfigurationManager.AppSettings.Get("server_port");
            if (server_port != null)
            {
                serverPort.Text = server_port;
            }

            string Rcon_port = ConfigurationManager.AppSettings.Get("Rcon_port");
            if (Rcon_port != null)
            {
                Rconport.Text = Rcon_port;
            }
            string Server_Hostname = ConfigurationManager.AppSettings.Get("Server_Hostname");
            if (Server_Hostname != null)
            {
                ServerHostname2.Text = Server_Hostname;
            }
            
            string Max_Players = ConfigurationManager.AppSettings.Get("Max_Players");
            if (Max_Players != null)
            {
                MaxPlayers.Text = Max_Players;
            }
            string World_Size = ConfigurationManager.AppSettings.Get("World_Size");
            if (World_Size != null)
            {
                WorldSize.Text = World_Size;
            }
            string Server_seed = ConfigurationManager.AppSettings.Get("Server_seed");
            if (Server_seed != null)
            {
                serverseed.Text = Server_seed;
            }
            string Save_interval = ConfigurationManager.AppSettings.Get("Save_interval");
            if (Save_interval != null)
            {
                saveinterval.Text = Save_interval;
            }
            string Rcon_pass = ConfigurationManager.AppSettings.Get("Rcon_pass");
            if (Rcon_pass != null)
            {
                rconpass.Text = Rcon_pass;
            }
            
            string Server_description = ConfigurationManager.AppSettings.Get("Server_description");
            if (Server_description != null)
            {
                serverdescription.Text = Server_description;
            }
            
            string Image_url = ConfigurationManager.AppSettings.Get("Image_url");
            if (Image_url != null)
            {
                imageurl.Text = Image_url;
            }
            
            string server_identity = ConfigurationManager.AppSettings.Get("server_identity");
            if (server_identity != null)
            {
                serveridentity.Text = server_identity;
            }
        }
       

        private void serverPort_TextChanged(object sender, EventArgs e)
        {
            
            int box_int = 0; Int32.TryParse(serverPort.Text, out box_int);
            if (System.Text.RegularExpressions.Regex.IsMatch(serverPort.Text, "[^0-9]"))
            {
                
                serverPort.Clear();
                string server_port = ConfigurationManager.AppSettings.Get("server_port");
                if (server_port != null) { serverPort.Text = server_port; } else { serverPort.Text = "28015"; }
                MessageBox.Show("Please enter only numbers.");
            }
            
            else if (box_int > 65535 && serverPort.Text != "") 
            {
                //serverPort.Text = "28015" ;
                serverPort.Clear();
                string server_port = ConfigurationManager.AppSettings.Get("server_port");
                if (server_port != null) { serverPort.Text = server_port; } else { serverPort.Text = "28015"; }
                MessageBox.Show("Port number should be from 1 - 65535");
            }
            else
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                config.AppSettings.Settings["server_port"].Value = serverPort.Text.ToString();
                config.Save(ConfigurationSaveMode.Modified);
            }


        }

        private void Rcon_port_TextChanged(object sender, EventArgs e)
        {
            int box_int = 0; Int32.TryParse(Rconport.Text, out box_int);
            if (System.Text.RegularExpressions.Regex.IsMatch(Rconport.Text, "[^0-9]"))
            {

                Rconport.Clear();
                string Rcon_port = ConfigurationManager.AppSettings.Get("Rcon_port");
                if (Rcon_port != null) { Rconport.Text = Rcon_port; } else { Rconport.Text = "28015"; }
                MessageBox.Show("Please enter only numbers.");
            }

            else if (box_int > 65535 && Rconport.Text != "")
            {
                //Rconport.Text = "28015" ;
                Rconport.Clear();
                string Rcon_port = ConfigurationManager.AppSettings.Get("Rcon_port");
                if (Rcon_port != null) { Rconport.Text = Rcon_port; } else { Rconport.Text = "28015"; }
                MessageBox.Show("Port number should be from 1 - 65535");
            }
            else
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                config.AppSettings.Settings["Rcon_port"].Value = Rconport.Text.ToString();
                config.Save(ConfigurationSaveMode.Modified);
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {



        }
        private void MaxPlayers_TextChanged(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings["Max_Players"].Value = MaxPlayers.Text.ToString();
            config.Save(ConfigurationSaveMode.Modified);
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void WorldSize_TextChanged(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings["World_Size"].Value = WorldSize.Text.ToString();
            config.Save(ConfigurationSaveMode.Modified);
        }

        private void ServerHostname_TextChanged(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings["Server_Hostname"].Value = ServerHostname2.Text.ToString();
            config.Save(ConfigurationSaveMode.Modified);
        }

        private void serverseed_TextChanged(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings["Server_seed"].Value = serverseed.Text.ToString();
            config.Save(ConfigurationSaveMode.Modified);
        }

        private void saveinterval_TextChanged(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings["Save_interval"].Value = saveinterval.Text.ToString();
            config.Save(ConfigurationSaveMode.Modified);
        }

        private void rcompass_TextChanged(object sender, EventArgs e)
        {
            
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings["Rcon_pass"].Value = rconpass.Text.ToString();
            config.Save(ConfigurationSaveMode.Modified);
        }

        private void serverdescription_TextChanged(object sender, EventArgs e)
        {
            
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings["Server_description"].Value = serverdescription.Text.ToString();
            config.Save(ConfigurationSaveMode.Modified);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void imageurl_TextChanged(object sender, EventArgs e)
        {
            
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings["Image_url"].Value = imageurl.Text.ToString();
            config.Save(ConfigurationSaveMode.Modified);
        }

        private void serveridentity_TextChanged(object sender, EventArgs e)
        {
            
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings["server_identity"].Value = serveridentity.Text.ToString();
            config.Save(ConfigurationSaveMode.Modified);
        }
    }
}
