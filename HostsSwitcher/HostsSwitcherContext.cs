using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HostsSwitcher
{
    public class HostsSwitcherContext : ApplicationContext
    {
        private static string IconFileName = "HostsSwitcher.ico";

        private IContainer _components;
        private ToolStripMenuItem _currentHostMenuItem;
        private ToolStripMenuItem _switchMenuItem;
        private ToolStripMenuItem _settingsMenuItem;
        private ToolStripMenuItem _exitMenuItem;
        private ContextMenuStrip _trayMenu;
        private NotifyIcon _trayIcon;

        public HostsSwitcherContext()
        {
            InitializeContext();
        }
        
        private void InitializeContext()
        {
            _components = new Container();

            _currentHostMenuItem = new ToolStripMenuItem()
            {
                Name = "currentHostMenuItem",
                Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold),
                Enabled = false,
                Size = new System.Drawing.Size(138, 22),
                Text = "Host"
            };

            _switchMenuItem = new ToolStripMenuItem()
            {
                Name = "switchMenuItem",
                Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold),
                Enabled = false,
                Size = new System.Drawing.Size(138, 22),
                Text = "Switch To..."
            };

            _settingsMenuItem = new ToolStripMenuItem()
            {
                Name = "settingsMenuItem",
                Size = new System.Drawing.Size(138, 22),
                Text = "Settings"
            };
            _settingsMenuItem.Click += new EventHandler(SettingsMenuItem_Click);

            _exitMenuItem = new ToolStripMenuItem()
            {
                Name = "exitMenuItem",
                Size = new System.Drawing.Size(138, 22),
                Text = "Exit"
            };
            _exitMenuItem.Click += new EventHandler(ExitMenuItem_Click);

            _trayMenu = new ContextMenuStrip(_components)
            {
                Name = "trayMenu",
                Size = new System.Drawing.Size(138, 104)
            };
            _trayMenu.Items.AddRange(new ToolStripItem[] {
                _currentHostMenuItem,
                new ToolStripSeparator() { Size = new System.Drawing.Size(138, 22) },
                _switchMenuItem,
                new ToolStripSeparator() { Size = new System.Drawing.Size(138, 22) },
                _settingsMenuItem,
                _exitMenuItem
            });
            _trayMenu.Opening += TrayMenu_Opening;

            _trayIcon = new NotifyIcon(_components)
            {
                ContextMenuStrip = _trayMenu,
                Icon = new Icon(IconFileName),
                Text = "Hosts Switcher App",
                Visible = true
            };
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && _components != null)
            {
                _components.Dispose();
            }
        }

        private void TrayMenu_Opening(object sender, CancelEventArgs e)
        {
        }

        private void SettingsMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
