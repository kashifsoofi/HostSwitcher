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
    public partial class HostForm : Form
    {
        private bool IsUpdate { get; set; }
        private HostElement Host { get; set; }

        public HostForm()
            : this(null)
        {
        }

        public HostForm(HostElement host)
        {
            InitializeComponent();

            IsUpdate = host != null;
            Host = IsUpdate ? host : new HostElement();
            if (IsUpdate)
                this.Text = "Update Host";
            else
                this.Text = "Add Host";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Host.Name = tbxHostName.Text;
            Host.IP = tbxHostIP.Text;

            HostsSwitcherSection hostsConfig = HostsSwitcherSection.Open();
            if (hostsConfig == null)
                hostsConfig = new HostsSwitcherSection();

            if (IsUpdate)
            {
            }
            else
            {
                int index = hostsConfig.Hosts.Count;
                hostsConfig.Hosts[index] = Host;
                hostsConfig.Save();
            }
        }
    }
}
