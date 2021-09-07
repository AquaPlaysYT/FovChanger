using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using MetroFramework.Controls;

namespace Lobby_Changer
{
    public partial class Form1 : Form
    {
        public MetroThemeStyle dark { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }


        String UserName = Environment.UserName;

        private void Form1_Load(object sender, EventArgs e)
        {


            MessageBox.Show("Welcome " + UserName + "! ,Thank you for using the tool!", "Fov Tool", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC2pXSfyN3aBHxljs7K5MqLw");
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.Extract Zip to normal folder then open Lobby Swapper and Open it");
            MessageBox.Show("2.Put Right Config Settings. and Enjoy Swaping");
            MessageBox.Show("if you have some trouble watch Aqua Plays Tutorial on Youtube or other tutorials on this program");
            
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC2pXSfyN3aBHxljs7K5MqLw");
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/Vfwsft7");
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Checking For updates dosen't work currently join discord for check instead");
            System.Diagnostics.Process.Start("https://discord.gg/Vfwsft7");
        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ops Coming Soon");
        }
        private void MetroButton12_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("EpicGamesLauncher").Length == 0)
            {
                MessageBox.Show("Your Epic Launcher is already closed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else//Process is found so run the code in the block body
            {
                try
                {
                    Process[] proc = Process.GetProcessesByName("EpicGamesLauncher");
                    proc[0].Kill();
                    MessageBox.Show("You Closed Epic!", "Epic Games Closed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
        System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC2pXSfyN3aBHxljs7K5MqLw");
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string rootFolder = "\\FortniteGame\\Saved\\Config\\WindowsClient\\";

            DialogResult result = MessageBox.Show("Are you sure you want to use 80 Fov?", "Fov Tool", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                string exePath = Application.StartupPath + "\\80\\GameUserSettings.ini";
                string copyPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string authorsFile = "GameUserSettings.ini";
                string delete = copyPath + rootFolder + authorsFile;
              

                if (File.Exists(delete))
                {
                    // If file found, delete it    
                    File.Delete(delete);
                    copyPath += "\\FortniteGame\\Saved\\Config\\WindowsClient\\" + Path.GetFileName(exePath);
                    File.Copy(exePath, copyPath);
                    MessageBox.Show("Your fov has been changed to 80!", "Fov Tool", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else if (result == DialogResult.No)
            {
                return;
            }
           
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            string rootFolder = "\\FortniteGame\\Saved\\Config\\WindowsClient\\";

            DialogResult result = MessageBox.Show("Are you sure you want to use 90 Fov?", "Fov Tool", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                string exePath = Application.StartupPath + "\\90\\GameUserSettings.ini";
                string copyPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string authorsFile = "GameUserSettings.ini";
                string delete = copyPath + rootFolder + authorsFile;


                if (File.Exists(delete))
                {
                    // If file found, delete it    
                    File.Delete(delete);
                    copyPath += "\\FortniteGame\\Saved\\Config\\WindowsClient\\" + Path.GetFileName(exePath);
                    File.Copy(exePath, copyPath);
                    MessageBox.Show("Your fov has been changed to 90!", "Fov Tool", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            string rootFolder = "\\FortniteGame\\Saved\\Config\\WindowsClient\\";

            DialogResult result = MessageBox.Show("Are you sure you want to use 100 Fov?", "Fov Tool", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                string exePath = Application.StartupPath + "\\100\\GameUserSettings.ini";
                string copyPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string authorsFile = "GameUserSettings.ini";
                string delete = copyPath + rootFolder + authorsFile;


                if (File.Exists(delete))
                {
                    // If file found, delete it    
                    File.Delete(delete);
                    copyPath += "\\FortniteGame\\Saved\\Config\\WindowsClient\\" + Path.GetFileName(exePath);
                    File.Copy(exePath, copyPath);
                    MessageBox.Show("Your fov has been changed to 100!", "Fov Tool", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            string rootFolder = "\\FortniteGame\\Saved\\Config\\WindowsClient\\";

            DialogResult result = MessageBox.Show("Are you sure you want to use 110 Fov?", "Fov Tool", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                string exePath = Application.StartupPath + "\\110\\GameUserSettings.ini";
                string copyPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string authorsFile = "GameUserSettings.ini";
                string delete = copyPath + rootFolder + authorsFile;


                if (File.Exists(delete))
                {
                    // If file found, delete it    
                    File.Delete(delete);
                    copyPath += "\\FortniteGame\\Saved\\Config\\WindowsClient\\" + Path.GetFileName(exePath);
                    File.Copy(exePath, copyPath);
                    MessageBox.Show("Your fov has been changed to 110!", "Fov Tool", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            string rootFolder = "\\FortniteGame\\Saved\\Config\\WindowsClient\\";

            DialogResult result = MessageBox.Show("Are you sure you want to use 120 Fov?", "Fov Tool", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                string exePath = Application.StartupPath + "\\120\\GameUserSettings.ini";
                string copyPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string authorsFile = "GameUserSettings.ini";
                string delete = copyPath + rootFolder + authorsFile;


                if (File.Exists(delete))
                {
                    // If file found, delete it    
                    File.Delete(delete);
                    copyPath += "\\FortniteGame\\Saved\\Config\\WindowsClient\\" + Path.GetFileName(exePath);
                    File.Copy(exePath, copyPath);
                    MessageBox.Show("Your fov has been changed to 120!", "Fov Tool", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }
    }
}


//Aqua Plays if you reading this now
//can you teach me how to make an Skin swapper
//i really wanna know
//if i know i would make one really good
//or we both could make one :)
//if not i don't really care

//2021: When the hell did someone ask me this LOL