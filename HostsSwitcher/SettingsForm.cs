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
                string[] rowData = new string[] { host.Name, host.IP };
                gvHosts.Rows.Add(rowData);
            }

            for (int i = 0; i < config.HostEntries.Count; i++)
            {
                HostEntryElement hostEntry = config.HostEntries[i];
                string[] rowData = new string[] { hostEntry.Name };
                gvHostEntries.Rows.Add(rowData);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvHosts_SelectionChanged(object sender, EventArgs e)
        {
            btnRemoveHost.Enabled = gvHosts.SelectedRows.Count > 0;
        }

        private void btnAddHost_Click(object sender, EventArgs e)
        {
            gvHosts.Rows.Add();
        }

        private void btnRemoveHost_Click(object sender, EventArgs e)
        {
            if (gvHosts.SelectedRows.Count > 0 &&
                gvHosts.SelectedRows[0].Index < gvHosts.Rows.Count)
            {
                int indexToRemove = gvHosts.SelectedRows[0].Index;
                HostsSwitcherSection config = HostsSwitcherSection.Open();
                config.Hosts.RemoveAt(indexToRemove);
                config.Save();
                // Update gridview
                gvHosts.Rows.RemoveAt(indexToRemove);
            }
        }

        private void gvHostEntries_SelectionChanged(object sender, EventArgs e)
        {
            btnRemoveHostEntry.Enabled = gvHostEntries.SelectedRows.Count > 0;
        }

        private void btnAddHostEntry_Click(object sender, EventArgs e)
        {
            gvHostEntries.Rows.Add();
        }

        private void btnRemoveHostEntry_Click(object sender, EventArgs e)
        {
            if (gvHostEntries.SelectedRows.Count > 0 &&
                gvHostEntries.SelectedRows[0].Index < gvHostEntries.Rows.Count)
            {
                int indexToRemove = gvHostEntries.SelectedRows[0].Index;
                HostsSwitcherSection config = HostsSwitcherSection.Open();
                config.HostEntries.RemoveAt(indexToRemove);
                config.Save();
                // Update gridview
                gvHostEntries.Rows.RemoveAt(indexToRemove);
            }
        }
    }
}
