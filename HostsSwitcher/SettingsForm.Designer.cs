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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAddHost = new System.Windows.Forms.Button();
            this.btnRemoveHost = new System.Windows.Forms.Button();
            this.btnRemoveHostEntry = new System.Windows.Forms.Button();
            this.btnAddHostEntry = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpHosts = new System.Windows.Forms.TabPage();
            this.tpHostEntries = new System.Windows.Forms.TabPage();
            this.gvHosts = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvHostEntries = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tpHosts.SuspendLayout();
            this.tpHostEntries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvHosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHostEntries)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(295, 245);
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
            this.btnAddHost.Click += new System.EventHandler(this.btnAddHost_Click);
            // 
            // btnRemoveHost
            // 
            this.btnRemoveHost.Enabled = false;
            this.btnRemoveHost.Location = new System.Drawing.Point(87, 172);
            this.btnRemoveHost.Name = "btnRemoveHost";
            this.btnRemoveHost.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveHost.TabIndex = 7;
            this.btnRemoveHost.Text = "Remove";
            this.btnRemoveHost.UseVisualStyleBackColor = true;
            this.btnRemoveHost.Click += new System.EventHandler(this.btnRemoveHost_Click);
            // 
            // btnRemoveHostEntry
            // 
            this.btnRemoveHostEntry.Enabled = false;
            this.btnRemoveHostEntry.Location = new System.Drawing.Point(87, 172);
            this.btnRemoveHostEntry.Name = "btnRemoveHostEntry";
            this.btnRemoveHostEntry.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveHostEntry.TabIndex = 10;
            this.btnRemoveHostEntry.Text = "Remove";
            this.btnRemoveHostEntry.UseVisualStyleBackColor = true;
            this.btnRemoveHostEntry.Click += new System.EventHandler(this.btnRemoveHostEntry_Click);
            // 
            // btnAddHostEntry
            // 
            this.btnAddHostEntry.Location = new System.Drawing.Point(6, 172);
            this.btnAddHostEntry.Name = "btnAddHostEntry";
            this.btnAddHostEntry.Size = new System.Drawing.Size(75, 23);
            this.btnAddHostEntry.TabIndex = 8;
            this.btnAddHostEntry.Text = "Add";
            this.btnAddHostEntry.UseVisualStyleBackColor = true;
            this.btnAddHostEntry.Click += new System.EventHandler(this.btnAddHostEntry_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpHosts);
            this.tabControl1.Controls.Add(this.tpHostEntries);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(360, 227);
            this.tabControl1.TabIndex = 8;
            // 
            // tpHosts
            // 
            this.tpHosts.Controls.Add(this.gvHosts);
            this.tpHosts.Controls.Add(this.btnRemoveHost);
            this.tpHosts.Controls.Add(this.btnAddHost);
            this.tpHosts.Location = new System.Drawing.Point(4, 22);
            this.tpHosts.Name = "tpHosts";
            this.tpHosts.Padding = new System.Windows.Forms.Padding(3);
            this.tpHosts.Size = new System.Drawing.Size(352, 201);
            this.tpHosts.TabIndex = 0;
            this.tpHosts.Text = "Hosts";
            this.tpHosts.UseVisualStyleBackColor = true;
            // 
            // tpHostEntries
            // 
            this.tpHostEntries.Controls.Add(this.gvHostEntries);
            this.tpHostEntries.Controls.Add(this.btnRemoveHostEntry);
            this.tpHostEntries.Controls.Add(this.btnAddHostEntry);
            this.tpHostEntries.Location = new System.Drawing.Point(4, 22);
            this.tpHostEntries.Name = "tpHostEntries";
            this.tpHostEntries.Padding = new System.Windows.Forms.Padding(3);
            this.tpHostEntries.Size = new System.Drawing.Size(352, 201);
            this.tpHostEntries.TabIndex = 1;
            this.tpHostEntries.Text = "HostEntries";
            this.tpHostEntries.UseVisualStyleBackColor = true;
            // 
            // gvHosts
            // 
            this.gvHosts.AllowUserToAddRows = false;
            this.gvHosts.AllowUserToDeleteRows = false;
            this.gvHosts.AllowUserToResizeColumns = false;
            this.gvHosts.AllowUserToResizeRows = false;
            this.gvHosts.ColumnHeadersHeight = 25;
            this.gvHosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gvHosts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colIP});
            this.gvHosts.Location = new System.Drawing.Point(6, 6);
            this.gvHosts.MultiSelect = false;
            this.gvHosts.Name = "gvHosts";
            this.gvHosts.RowHeadersWidth = 24;
            this.gvHosts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvHosts.Size = new System.Drawing.Size(340, 160);
            this.gvHosts.TabIndex = 9;
            this.gvHosts.SelectionChanged += new System.EventHandler(this.gvHosts_SelectionChanged);
            // 
            // colName
            // 
            this.colName.FillWeight = 194F;
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 194;
            this.colName.Name = "colName";
            this.colName.Width = 194;
            // 
            // colIP
            // 
            this.colIP.FillWeight = 120F;
            this.colIP.HeaderText = "IP";
            this.colIP.MinimumWidth = 120;
            this.colIP.Name = "colIP";
            this.colIP.Width = 120;
            // 
            // gvHostEntries
            // 
            this.gvHostEntries.AllowUserToAddRows = false;
            this.gvHostEntries.AllowUserToDeleteRows = false;
            this.gvHostEntries.AllowUserToResizeColumns = false;
            this.gvHostEntries.AllowUserToResizeRows = false;
            this.gvHostEntries.ColumnHeadersHeight = 25;
            this.gvHostEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gvHostEntries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.gvHostEntries.Location = new System.Drawing.Point(6, 6);
            this.gvHostEntries.MultiSelect = false;
            this.gvHostEntries.Name = "gvHostEntries";
            this.gvHostEntries.RowHeadersWidth = 24;
            this.gvHostEntries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvHostEntries.Size = new System.Drawing.Size(340, 160);
            this.gvHostEntries.TabIndex = 11;
            this.gvHostEntries.SelectionChanged += new System.EventHandler(this.gvHostEntries_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 314F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 314;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 314;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 276);
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
            ((System.ComponentModel.ISupportInitialize)(this.gvHosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHostEntries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddHost;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnRemoveHost;
        private System.Windows.Forms.Button btnRemoveHostEntry;
        private System.Windows.Forms.Button btnAddHostEntry;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpHosts;
        private System.Windows.Forms.TabPage tpHostEntries;
        private System.Windows.Forms.DataGridView gvHosts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIP;
        private System.Windows.Forms.DataGridView gvHostEntries;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

    }
}