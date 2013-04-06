namespace HostsSwitcher
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.lvHosts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAddHost = new System.Windows.Forms.Button();
            this.btnEditHost = new System.Windows.Forms.Button();
            this.btnRemoveHost = new System.Windows.Forms.Button();
            this.btnRemoveHostEntry = new System.Windows.Forms.Button();
            this.btnEditHostEntry = new System.Windows.Forms.Button();
            this.btnAddHostEntry = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpHosts = new System.Windows.Forms.TabPage();
            this.tpHostEntries = new System.Windows.Forms.TabPage();
            this.lvHostEntries = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tpHosts.SuspendLayout();
            this.tpHostEntries.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvHosts
            // 
            this.lvHosts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvHosts.FullRowSelect = true;
            this.lvHosts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvHosts.Location = new System.Drawing.Point(6, 6);
            this.lvHosts.MultiSelect = false;
            this.lvHosts.Name = "lvHosts";
            this.lvHosts.ShowGroups = false;
            this.lvHosts.Size = new System.Drawing.Size(340, 160);
            this.lvHosts.TabIndex = 4;
            this.lvHosts.UseCompatibleStateImageBehavior = false;
            this.lvHosts.View = System.Windows.Forms.View.Details;
            this.lvHosts.SelectedIndexChanged += new System.EventHandler(this.lvHosts_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 220;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "IP";
            this.columnHeader2.Width = 96;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(299, 245);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAddHost
            // 
            this.btnAddHost.Location = new System.Drawing.Point(6, 172);
            this.btnAddHost.Name = "btnAddHost";
            this.btnAddHost.Size = new System.Drawing.Size(75, 23);
            this.btnAddHost.TabIndex = 5;
            this.btnAddHost.Text = "Add";
            this.btnAddHost.UseVisualStyleBackColor = true;
            // 
            // btnEditHost
            // 
            this.btnEditHost.Enabled = false;
            this.btnEditHost.Location = new System.Drawing.Point(87, 172);
            this.btnEditHost.Name = "btnEditHost";
            this.btnEditHost.Size = new System.Drawing.Size(75, 23);
            this.btnEditHost.TabIndex = 6;
            this.btnEditHost.Text = "Edit";
            this.btnEditHost.UseVisualStyleBackColor = true;
            // 
            // btnRemoveHost
            // 
            this.btnRemoveHost.Enabled = false;
            this.btnRemoveHost.Location = new System.Drawing.Point(168, 172);
            this.btnRemoveHost.Name = "btnRemoveHost";
            this.btnRemoveHost.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveHost.TabIndex = 7;
            this.btnRemoveHost.Text = "Remove";
            this.btnRemoveHost.UseVisualStyleBackColor = true;
            // 
            // btnRemoveHostEntry
            // 
            this.btnRemoveHostEntry.Enabled = false;
            this.btnRemoveHostEntry.Location = new System.Drawing.Point(169, 172);
            this.btnRemoveHostEntry.Name = "btnRemoveHostEntry";
            this.btnRemoveHostEntry.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveHostEntry.TabIndex = 10;
            this.btnRemoveHostEntry.Text = "Remove";
            this.btnRemoveHostEntry.UseVisualStyleBackColor = true;
            // 
            // btnEditHostEntry
            // 
            this.btnEditHostEntry.Enabled = false;
            this.btnEditHostEntry.Location = new System.Drawing.Point(87, 172);
            this.btnEditHostEntry.Name = "btnEditHostEntry";
            this.btnEditHostEntry.Size = new System.Drawing.Size(75, 23);
            this.btnEditHostEntry.TabIndex = 9;
            this.btnEditHostEntry.Text = "Edit";
            this.btnEditHostEntry.UseVisualStyleBackColor = true;
            // 
            // btnAddHostEntry
            // 
            this.btnAddHostEntry.Location = new System.Drawing.Point(6, 172);
            this.btnAddHostEntry.Name = "btnAddHostEntry";
            this.btnAddHostEntry.Size = new System.Drawing.Size(75, 23);
            this.btnAddHostEntry.TabIndex = 8;
            this.btnAddHostEntry.Text = "Add";
            this.btnAddHostEntry.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpHosts);
            this.tabControl1.Controls.Add(this.tpHostEntries);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(362, 227);
            this.tabControl1.TabIndex = 8;
            // 
            // tpHosts
            // 
            this.tpHosts.Controls.Add(this.btnRemoveHost);
            this.tpHosts.Controls.Add(this.lvHosts);
            this.tpHosts.Controls.Add(this.btnEditHost);
            this.tpHosts.Controls.Add(this.btnAddHost);
            this.tpHosts.Location = new System.Drawing.Point(4, 22);
            this.tpHosts.Name = "tpHosts";
            this.tpHosts.Padding = new System.Windows.Forms.Padding(3);
            this.tpHosts.Size = new System.Drawing.Size(354, 201);
            this.tpHosts.TabIndex = 0;
            this.tpHosts.Text = "Hosts";
            this.tpHosts.UseVisualStyleBackColor = true;
            // 
            // tpHostEntries
            // 
            this.tpHostEntries.Controls.Add(this.lvHostEntries);
            this.tpHostEntries.Controls.Add(this.btnRemoveHostEntry);
            this.tpHostEntries.Controls.Add(this.btnEditHostEntry);
            this.tpHostEntries.Controls.Add(this.btnAddHostEntry);
            this.tpHostEntries.Location = new System.Drawing.Point(4, 22);
            this.tpHostEntries.Name = "tpHostEntries";
            this.tpHostEntries.Padding = new System.Windows.Forms.Padding(3);
            this.tpHostEntries.Size = new System.Drawing.Size(354, 201);
            this.tpHostEntries.TabIndex = 1;
            this.tpHostEntries.Text = "HostEntries";
            this.tpHostEntries.UseVisualStyleBackColor = true;
            // 
            // lvHostEntries
            // 
            this.lvHostEntries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.lvHostEntries.FullRowSelect = true;
            this.lvHostEntries.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvHostEntries.Location = new System.Drawing.Point(6, 6);
            this.lvHostEntries.MultiSelect = false;
            this.lvHostEntries.Name = "lvHostEntries";
            this.lvHostEntries.ShowGroups = false;
            this.lvHostEntries.Size = new System.Drawing.Size(340, 160);
            this.lvHostEntries.TabIndex = 11;
            this.lvHostEntries.UseCompatibleStateImageBehavior = false;
            this.lvHostEntries.View = System.Windows.Forms.View.Details;
            this.lvHostEntries.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvHostEntries_ItemSelectionChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 324;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 275);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpHosts.ResumeLayout(false);
            this.tpHostEntries.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvHosts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnEditHost;
        private System.Windows.Forms.Button btnAddHost;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnRemoveHost;
        private System.Windows.Forms.Button btnRemoveHostEntry;
        private System.Windows.Forms.Button btnEditHostEntry;
        private System.Windows.Forms.Button btnAddHostEntry;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpHosts;
        private System.Windows.Forms.TabPage tpHostEntries;
        private System.Windows.Forms.ListView lvHostEntries;
        private System.Windows.Forms.ColumnHeader columnHeader3;

    }
}