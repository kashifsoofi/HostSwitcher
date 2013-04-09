namespace HostsSwitcher
{
    partial class HostForm
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
            this.lblHostName = new System.Windows.Forms.Label();
            this.tbxHostName = new System.Windows.Forms.TextBox();
            this.tbxHostIP = new System.Windows.Forms.TextBox();
            this.lblHostIP = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHostName
            // 
            this.lblHostName.Location = new System.Drawing.Point(14, 16);
            this.lblHostName.Name = "lblHostName";
            this.lblHostName.Size = new System.Drawing.Size(67, 17);
            this.lblHostName.TabIndex = 0;
            this.lblHostName.Text = "Host Name";
            this.lblHostName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxHostName
            // 
            this.tbxHostName.Location = new System.Drawing.Point(87, 13);
            this.tbxHostName.Name = "tbxHostName";
            this.tbxHostName.Size = new System.Drawing.Size(161, 20);
            this.tbxHostName.TabIndex = 1;
            // 
            // tbxHostIP
            // 
            this.tbxHostIP.Location = new System.Drawing.Point(87, 39);
            this.tbxHostIP.Name = "tbxHostIP";
            this.tbxHostIP.Size = new System.Drawing.Size(161, 20);
            this.tbxHostIP.TabIndex = 3;
            // 
            // lblHostIP
            // 
            this.lblHostIP.Location = new System.Drawing.Point(14, 42);
            this.lblHostIP.Name = "lblHostIP";
            this.lblHostIP.Size = new System.Drawing.Size(67, 13);
            this.lblHostIP.TabIndex = 2;
            this.lblHostIP.Text = "Host IP";
            this.lblHostIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(173, 65);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(92, 65);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // HostForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(277, 102);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbxHostIP);
            this.Controls.Add(this.lblHostIP);
            this.Controls.Add(this.tbxHostName);
            this.Controls.Add(this.lblHostName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HostForm";
            this.Text = "Host";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHostName;
        private System.Windows.Forms.TextBox tbxHostName;
        private System.Windows.Forms.TextBox tbxHostIP;
        private System.Windows.Forms.Label lblHostIP;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}