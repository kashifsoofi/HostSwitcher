using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HostsSwitcher
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            HostsSwitcherSection config = HostsSwitcherSection.Open();
            for (int i = 0; i < config.Hosts.Count; i++)
            {
                HostElement host = config.Hosts[i];
                ListViewItem lvi = new ListViewItem(new string[] { host.Name, host.IP });
                lvi.Tag = i;
                lvHosts.Items.Add(lvi);
            }

            for (int i = 0; i < config.HostEntries.Count; i++)
            {
                HostEntryElement hostEntry = config.HostEntries[i];
                ListViewItem lvi = new ListViewItem(hostEntry.Name);
                lvi.Tag = i;
                lvHostEntries.Items.Add(lvi);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvHosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditHost.Enabled = lvHosts.SelectedItems.Count > 0;
            btnRemoveHost.Enabled = lvHosts.SelectedItems.Count > 0;
        }

        private void lvHostEntries_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            btnEditHostEntry.Enabled = lvHostEntries.SelectedItems.Count > 0;
            btnRemoveHostEntry.Enabled = lvHostEntries.SelectedItems.Count > 0;
        }

        private void btnAddHost_Click(object sender, EventArgs e)
        {
            HostForm hostForm = new HostForm();
            hostForm.ShowDialog();
        }

        private void btnEditHost_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveHost_Click(object sender, EventArgs e)
        {

        }
    }
}
