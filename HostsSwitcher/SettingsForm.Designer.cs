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
            this.lblHosts = new System.Windows.Forms.Label();
            this.lblHostEntries = new System.Windows.Forms.Label();
            this.lbHostEntries = new System.Windows.Forms.ListBox();
            this.lvHosts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblHosts
            // 
            this.lblHosts.AutoSize = true;
            this.lblHosts.Location = new System.Drawing.Point(13, 13);
            this.lblHosts.Name = "lblHosts";
            this.lblHosts.Size = new System.Drawing.Size(34, 13);
            this.lblHosts.TabIndex = 1;
            this.lblHosts.Text = "Hosts";
            // 
            // lblHostEntries
            // 
            this.lblHostEntries.AutoSize = true;
            this.lblHostEntries.Location = new System.Drawing.Point(13, 245);
            this.lblHostEntries.Name = "lblHostEntries";
            this.lblHostEntries.Size = new System.Drawing.Size(64, 13);
            this.lblHostEntries.TabIndex = 3;
            this.lblHostEntries.Text = "Host Entries";
            // 
            // lbHostEntries
            // 
            this.lbHostEntries.FormattingEnabled = true;
            this.lbHostEntries.Location = new System.Drawing.Point(12, 261);
            this.lbHostEntries.Name = "lbHostEntries";
            this.lbHostEntries.Size = new System.Drawing.Size(381, 95);
            this.lbHostEntries.TabIndex = 2;
            // 
            // lvHosts
            // 
            this.lvHosts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvHosts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvHosts.Location = new System.Drawing.Point(12, 29);
            this.lvHosts.MultiSelect = false;
            this.lvHosts.Name = "lvHosts";
            this.lvHosts.ShowGroups = false;
            this.lvHosts.Size = new System.Drawing.Size(381, 97);
            this.lvHosts.TabIndex = 4;
            this.lvHosts.UseCompatibleStateImageBehavior = false;
            this.lvHosts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 163;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "IP";
            this.columnHeader2.Width = 195;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 411);
            this.Controls.Add(this.lvHosts);
            this.Controls.Add(this.lblHostEntries);
            this.Controls.Add(this.lbHostEntries);
            this.Controls.Add(this.lblHosts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHosts;
        private System.Windows.Forms.Label lblHostEntries;
        private System.Windows.Forms.ListBox lbHostEntries;
        private System.Windows.Forms.ListView lvHosts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;

    }
}