using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifePunch_Content_Autopatcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool checkIfGmodFolderisOK(string folder)
        {
            if (File.Exists(folder + "\\hl2.exe") && Directory.Exists(folder + "\\garrysmod"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        void openProgram(string program, string args)
        {
            Process process = new Process();
            try
            {
                process.StartInfo.FileName = program;
                process.StartInfo.Arguments = args;
                process.Start();
                process.WaitForExit();
                process.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error launching: " + program + "\nInner: " + e.InnerException + "\nSource: " + e.Source + "\nString" + e.ToString());
            }
        }
        void showFolderDialog()
        {
            DialogResult result = folder.ShowDialog();
            if (result == DialogResult.OK)
            {
                pathBox.Text = folder.SelectedPath;
            }
        }
        bool installPackage(string name)
        {
            string installDir = pathBox.Text + "\\garrysmod\\addons\\LifePunch - " + name;
            logBox.Items.Add("Installation directory: \"" + installDir + "\"");
            if (Directory.Exists(installDir))
            {
                Directory.Delete(installDir);
            }

            using (WebClient client = new WebClient())
            {
                #region Downloading zips
                logBox.Items.Add("Downloading zip file \"" + name + "\", please be patient");

                if (name == "Content"){
                    client.DownloadFile("https://doc-0o-b0-docs.googleusercontent.com/docs/securesc/ha0ro937gcuc7l7deffksulhg5h7mbp1/rg67106f1g0p3cf63umqceukc9ak8g0k/1423706400000/10026425688678393106/*/0B5fwVeQ4kXnfN3lHOWpTMEVaVlE?e=download", "LifePunch - Content.zip");
                } else if (name == "Bunnyhop Maps"){
                    client.DownloadFile("https://doc-0o-b0-docs.googleusercontent.com/docs/securesc/ha0ro937gcuc7l7deffksulhg5h7mbp1/bihh6mqnfo35orvrg3seuepo107501f1/1423706400000/10026425688678393106/*/0B5fwVeQ4kXnfdFdBcE9zZzBxM00?e=download", "LifePunch - Bunnyhop Maps.zip");
                } else if (name == "Deathrun Maps"){
                    client.DownloadFile("https://doc-0o-b0-docs.googleusercontent.com/docs/securesc/ha0ro937gcuc7l7deffksulhg5h7mbp1/rmadm7a05e5svvjc0e5h71v4kh8ojsmp/1423706400000/10026425688678393106/*/0B5fwVeQ4kXnfUXlBa3poaTc4YzQ?e=download", "LifePunch - Deathrun Maps.zip");
                } else if (name == "Gungame Maps"){
                    client.DownloadFile("https://doc-04-b0-docs.googleusercontent.com/docs/securesc/ha0ro937gcuc7l7deffksulhg5h7mbp1/pbmnconshrv2ive0foqsa50ita57dimj/1423706400000/10026425688678393106/*/0B5fwVeQ4kXnfeWdBSkJRdm5Zb1k?e=download", "LifePunch - Gungame Maps.zip");
                } else if (name == "Jailbreak Maps"){
                    client.DownloadFile("https://doc-08-b0-docs.googleusercontent.com/docs/securesc/ha0ro937gcuc7l7deffksulhg5h7mbp1/mmv07dk1viiauok2bfqk4ggqlf96qbd5/1423706400000/10026425688678393106/*/0B5fwVeQ4kXnfUGplMXhVTi03RDg?e=download", "LifePunch - Jailbreak Maps.zip");
                }
                #endregion
                logBox.Items.Add("Downloading unzip");
                client.DownloadFile("https://github.com/Scarsz/windowsgameservers/blob/master/unzip.exe?raw=true", "unzip.exe");
            }
            logBox.Items.Add("Extracting files, please be patient");
            openProgram("unzip.exe", "-o \"LifePunch - " + name + ".zip\" -d \"" + installDir + "\" -x INSTRUCTIONS.txt");
            if (Directory.Exists(installDir))
            {
                logBox.Items.Add("Extraction finished");
            }
            else
            {
                logBox.Items.Add("Extraction did not complete successfully");
                logBox.Items.Add("Unknown reason");
            }
            logBox.Items.Add("Deleting unzip.exe");
            File.Delete("unzip.exe");
            logBox.Items.Add("Deleting package \"LifePunch - " + name + "\".zip");
            File.Delete("LifePunch - " + name + ".zip");
            return true;
        }

        private void pathBox_TextChanged(object sender, EventArgs e)
        {
            if (checkIfGmodFolderisOK(pathBox.Text))
            {
                folderStatus.ForeColor = Color.Green;
                folderStatus.Text = "GOOD";
                actionButton.Enabled = true;
                selectionBox.Enabled = true;
            }
            else
            {
                folderStatus.ForeColor = Color.Red;
                folderStatus.Text = "ERROR";
                actionButton.Enabled = false;
                selectionBox.Enabled = false;
            }
        }
        private void chooseFolder_Click(object sender, EventArgs e)
        {
            showFolderDialog();
        }
        private void selectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectionBox.Text != "Content" && 
                selectionBox.Text != "Bunnyhop Maps" &&
                selectionBox.Text != "Deathrun Maps" &&
                selectionBox.Text != "Gungame Maps" &&
                selectionBox.Text != "Jailbreak Maps")
            {
                MessageBox.Show("Invalid package");
            }
            else
            {
                logBox.Items.Add("Package \"" + selectionBox.Text + "\" selected");
                actionButton.Enabled = true;
                if (folderStatus.Text == "GOOD")
                {
                    if (Directory.Exists(pathBox.Text + "\\garrysmod\\addons\\LifePunch - " + selectionBox.Text))
                    {
                        actionButton.Text = "Reinstall";
                        logBox.Items.Add("Package \"" + selectionBox.Text + "\" is already installed, available for reinstall");
                    }
                    else
                    {
                        actionButton.Text = "Install";
                    }
                }
                else
                {
                    MessageBox.Show("Select your topmost GarrysMod folder first.");
                }
            }
        }
        private void actionButton_Click(object sender, EventArgs e)
        {
            if (actionButton.Text != "<- Choose")
            {
                actionButton.Enabled = false;
                chooseFolder.Enabled = false;
                pathBox.Enabled = false;
                selectionBox.Enabled = false;
                actionButton.Text = "Installing";

                logBox.Items.Add("Beginning installation of \"" + selectionBox.Text + "\"");
                installPackage(selectionBox.Text);
                logBox.Items.Add("Installation completed");

                actionButton.Enabled = true;
                chooseFolder.Enabled = true;
                pathBox.Enabled = true;
                selectionBox.Enabled = true;
                actionButton.Text = "<- Choose";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Update notification
            int version = 1;
            using (WebClient client = new WebClient())
            {
                int latestVersion = Convert.ToInt32(client.DownloadString("https://raw.githubusercontent.com/Scarsz/LifePunch-ContentPatcher/master/version"));
                if (version < latestVersion)
                {
                    MessageBox.Show("This version of LPCAP is outdated, please download the newest version.");
                    System.Diagnostics.Process.Start("https://github.com/Scarsz/LifePunch-ContentPatcher/releases");
                }
            }
        }
    }
}