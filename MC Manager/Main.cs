using DarkUI.Forms;
using System.Windows.Forms;
using System;
using Renci.SshNet;
using System.IO;
using DarkUI.Controls;

namespace MC_Manager
{
    public partial class Main : DarkForm
    {
        string username = "";
        string server = "";
        string configFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".\\MC Manager\\lastconfig.cfg");
        PrivateKeyFile[] privKey = { new PrivateKeyFile(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".\\.ssh\\id_rsa")) };
        public Main()
        {
            InitializeComponent();
            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MC Manager"));
            if (File.Exists(configFile))
            {
                try
                {
                    bool startedWithArgs = false;
                    string[] args = Environment.GetCommandLineArgs();
                    try
                    {
                        var x = args[1];
                        startedWithArgs = true;
                    } catch { }
                    if (startedWithArgs)
                    {
                        loadConfig(args[1]);
                    } else
                    {
                        loadConfig(File.ReadAllText(configFile));
                    }
                } catch { }
            }
            refreshUI();
            getMotd();
        }

        private void darkListView1_DoubleClick(object sender, EventArgs e)
        {
            username = darkListView1.Items[darkListView1.SelectedIndices[0]].Text;
            refreshUI();
            getMotd();
        }

        private void loadConfig(string filename, bool soft = false)
        {
            try
            {
                darkListView1.Items.Clear();
                darkTextBox1.Text = "";
                string[] config = File.ReadAllText(filename).Split("\n");
                foreach (string line in config)
                {
                    if (!soft)
                    {
                        if (line.StartsWith("server:"))
                        {
                            server = line.ToLower().Replace(" ", "").Split(new string[] { "server:" }, StringSplitOptions.None)[1];
                        }
                        else
                        {
                            darkListView1.Items.Add(new DarkListItem(line.Split("#")[0]));
                        }
                    }
                }
                if (!soft)
                {
                    darkListView1.SelectItem(0);
                    username = darkListView1.Items[0].Text;
                    refreshUI();
                }
                File.WriteAllText(configFile, filename);
            }
            catch
            {
                server = "";
                username = "";
            }
        }

        private void refreshUI()
        {
            try
            {
                progressBar1.Value = getRam();
                darkListView1.Update();
                getLog();
            }
            catch { }
        }

        private void getMotd()
        {
            try
            {
                string[] config = File.ReadAllText(File.ReadAllText(configFile)).Split("\n");
                foreach (string line in config)
                {
                    if (line.Split("#")[0] == username)
                    {
                        darkLabel2.Text = line.Split("#")[1];
                    }
                }
            }
            catch
            {
                darkLabel2.Text = "";
            }
        }

        private void stopServer()
        {
            try
            {
                using (var client = new SshClient(server, username, privKey))
                {
                    client.Connect();
                    int returnCode = client.RunCommand("for session in $(screen -ls | grep -o '[0-9]*\\.minecraft'); do screen -S \"${session}\" -X quit; done").ExitStatus;
                    returnCode = returnCode + client.RunCommand("rm -rf screen.log").ExitStatus;
                    if (returnCode == 0)
                    {
                        DarkMessageBox.ShowInformation("Server successfully stopped!", "Success", DarkDialogButton.Ok);
                    }
                    else
                    {
                        DarkMessageBox.ShowError("Error stopping server. Make sure you're connected to the internet and have the correct permissions.", "Error", DarkDialogButton.Ok);
                    }
                }
            }
            catch
            {
                DarkMessageBox.ShowError("Error stopping server. Make sure you're connected to the internet and have the correct permissions.", "Error", DarkDialogButton.Ok);
            }
        }

        private void startServer()
        {
            try
            {
                bool continueStart = true;
                using (var client = new SshClient(server, username, privKey))
                {
                    client.Connect();
                    int returnCode = client.RunCommand("ls screen.log").ExitStatus;
                    if (returnCode == 0)
                    {
                        continueStart = false;
                    }
                }
                if (continueStart)
                {
                    using (var client = new SshClient(server, username, privKey))
                    {
                        client.Connect();
                        int returnCode = client.RunCommand("screen -S minecraft -L -Logfile screen.log -d -m bash -c \"./start.sh\"").ExitStatus;
                        if (returnCode == 0)
                        {
                            DarkMessageBox.ShowInformation("Server successfully started!", "Success", DarkDialogButton.Ok);
                        }
                        else
                        {
                            DarkMessageBox.ShowError("Error starting server. Make sure you're connected to the internet and have the correct permissions.", "Error", DarkDialogButton.Ok);
                        }
                    }
                }
                else
                {
                    DarkMessageBox.ShowError("Error starting server. Server already started.", "Error", DarkDialogButton.Ok);
                }
            }
            catch
            {
                DarkMessageBox.ShowError("Error starting server. Make sure you're connected to the internet and have the correct permissions.", "Error", DarkDialogButton.Ok);
            }
        }

        private int getRam()
        {
            try
            {
                using (var client = new SshClient(server, username, privKey))
                {
                    client.Connect();
                    return Convert.ToInt32(client.RunCommand("free | grep Mem | awk '{print $3/$2 * 100.0}'").Result.Split(".")[0].Replace(" ", ""));
                }
            }
            catch
            {
                return 0;
            }
        }

        private void getLog()
        {
            try
            {
                using (var client = new SshClient(server, username, privKey))
                {
                    client.Connect();
                    int returnCode = client.RunCommand("cat screen.log").ExitStatus;
                    int logSize = (this.Size.Height / 489) * 20;
                    if (returnCode == 0)
                    {
                        darkTextBox1.Text = client.RunCommand("cat screen.log | tail -"+logSize.ToString()+" | sed 's/\x1B[@A-Z\\\\\\]^_]\\|\x1B\\[[0-9:;<=>?]*[-!\"#$%&'\"'\"'()*+,.\\/]*[][\\\\@A-Z^_`a-z{|}~]//g'").Result;
                    }
                    else
                    {
                        darkTextBox1.Text = "";
                    }
                }
            }
            catch
            {
                darkTextBox1.Text = "";
            }
        }

        private void runCommand(string command)
        {
            try
            {
                using (var client = new SshClient(server, username, privKey))
                {
                    client.Connect();
                    client.RunCommand("screen -S minecraft -p 0 -X stuff \"" + command + "^M\"");
                }
            }
            catch { }
        }

        private void darkButton2_Click(object sender, EventArgs e)
        {
            DialogResult messageBox = DarkMessageBox.ShowInformation("Are you sure you want to stop the server?", "Are you sure?", DarkDialogButton.YesNo);
            if (messageBox == DialogResult.Yes)
            {
                stopServer();
            }
        }

        private void darkButton3_Click(object sender, EventArgs e)
        {
            startServer();
        }

        private void ramUpdater_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = getRam();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void logUpdater_Tick(object sender, EventArgs e)
        {
            getLog();
            getMotd();
        }

        private void darkTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                runCommand(darkTextBox2.Text);
                darkTextBox2.Text = "";
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void openconfigFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "MC Manager Config File (*.mmcfg)|";
            openFileDialog1.FileName = "";
            DialogResult dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                if (File.Exists(openFileDialog1.FileName))
                {
                    loadConfig(openFileDialog1.FileName, true);
                    Application.Restart();
                    Environment.Exit(0);
                }
            }
        }
    }
}
