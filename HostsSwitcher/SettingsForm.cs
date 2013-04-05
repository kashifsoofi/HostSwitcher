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
            HostsSwitcherConfiguration config = (HostsSwitcherConfiguration)ConfigurationManager.GetSection("HostsSwitcherConfiguration");
            foreach (HostElement host in config.Hosts)
            {
                lvHosts.Items.Add(new ListViewItem(new string[] { host.Name, host.IP }));
            }

            foreach (HostEntryElement hostEntry in config.HostEntries)
            {
                lbHostEntries.Items.Add(hostEntry.Name);
            }
        }
    }
}
