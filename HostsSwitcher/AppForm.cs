using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace HostsSwitcher
{
    public partial class AppForm : Form
    {
        private string _hostsFilePath = Environment.GetFolderPath(Environment.SpecialFolder.System) + @"\drivers\etc\hosts";
        private string _liveHostsFilePath = Environment.GetFolderPath(Environment.SpecialFolder.System) + @"\drivers\etc\hosts.live";

        private List<ToolStripMenuItem> _hostsMenuItems = new List<ToolStripMenuItem>();

        public AppForm()
        {
            InitializeComponent();

            // Backup original file if does not exist
            if (!File.Exists(_liveHostsFilePath))
            {
                File.Copy(_hostsFilePath, _liveHostsFilePath);
                File.AppendAllLines(_hostsFilePath, new List<string> { "#Live" });
            }
        }

        private void TrayMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Update Current hostname
            string[] arrHosts = File.ReadAllLines(_hostsFilePath);
            string currentHostname = arrHosts[arrHosts.Length - 1].Trim(new char[] { '#' });
            currentHostToolStripMenuItem.Text = "Current: " + currentHostname;

            // Clear Context Menu before adding items
            HostsSwitcherSection config = HostsSwitcherSection.Open();
            foreach (ToolStripMenuItem mi in _hostsMenuItems)
            {
                TrayMenu.Items.Remove(mi);
            }
            _hostsMenuItems.Clear();

            int insertIndex = TrayMenu.Items.IndexOf(switchToStripMenuItem);
            bool currentHostIsLive = currentHostname.ToLower() == "live";
            // Add Live Host entry
            ToolStripMenuItem miLive = new ToolStripMenuItem(" - Live");
            miLive.Tag = "Live";
            miLive.Enabled = !currentHostIsLive;
            miLive.Click += new EventHandler(switchToToolStripMenuItem_Click);
            _hostsMenuItems.Add(miLive);
            TrayMenu.Items.Insert(++insertIndex, miLive);

            for (int i = 0; i < config.Hosts.Count; i++)
            {
                HostElement host = config.Hosts[i];
                ToolStripMenuItem mi = new ToolStripMenuItem(" - " + host.Name);
                mi.Tag = host.Name;
                mi.Enabled = host.Name.ToLower() != currentHostname.ToLower();
                mi.Click += new EventHandler(switchToToolStripMenuItem_Click);
                _hostsMenuItems.Add(mi);

                TrayMenu.Items.Insert(++insertIndex, mi);
            }
        }

        private void switchToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem mi = sender as ToolStripMenuItem;
            string hostname = mi.Tag.ToString();

            List<string> contentEntries = new List<string>();
            if (hostname.ToLower() != "live")
            {
                HostsSwitcherSection config = HostsSwitcherSection.Open();
                HostElement host = config.Hosts[hostname];

                foreach (HostEntryElement hostEntry in config.HostEntries)
                {
                    contentEntries.Add(string.Format("{0}\t{1}", host.IP, hostEntry.Name));
                }
            }
            contentEntries.Add("#" + hostname);

            // Copy live file
            File.Copy(_liveHostsFilePath, _hostsFilePath, true);
            File.AppendAllLines(_hostsFilePath, contentEntries);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
