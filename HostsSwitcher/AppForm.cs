using System;
using System.IO;
using System.Windows.Forms;

namespace HostsSwitcher
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();

            string hostsPath = Environment.GetFolderPath(Environment.SpecialFolder.System) + @"\drivers\etc\hosts";
            // Backup original file if does not exist
            string originalHostsPath = hostsPath + ".original";
            if (!File.Exists(originalHostsPath))
            {
                File.Copy(hostsPath, originalHostsPath);
            }
            string a = string.Empty;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
