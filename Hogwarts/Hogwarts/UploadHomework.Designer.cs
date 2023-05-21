namespace Hogwarts
{
    partial class UploadHomework
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadHomework));
            this.cmbAssignments = new System.Windows.Forms.ComboBox();
            this.BtnUpload = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbAssignments
            // 
            this.cmbAssignments.FormattingEnabled = true;
            this.cmbAssignments.Location = new System.Drawing.Point(65, 197);
            this.cmbAssignments.Name = "cmbAssignments";
            this.cmbAssignments.Size = new System.Drawing.Size(200, 24);
            this.cmbAssignments.TabIndex = 0;
            this.cmbAssignments.SelectedIndexChanged += new System.EventHandler(this.cmbAssignments_SelectedIndexChanged);
            // 
            // BtnUpload
            // 
            this.BtnUpload.BorderColor = System.Drawing.Color.Khaki;
            this.BtnUpload.BorderRadius = 15;
            this.BtnUpload.BorderThickness = 5;
            this.BtnUpload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnUpload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnUpload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnUpload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnUpload.FillColor = System.Drawing.Color.Gray;
            this.BtnUpload.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpload.ForeColor = System.Drawing.Color.Khaki;
            this.BtnUpload.Location = new System.Drawing.Point(356, 126);
            this.BtnUpload.Name = "BtnUpload";
            this.BtnUpload.Size = new System.Drawing.Size(191, 115);
            this.BtnUpload.TabIndex = 1;
            this.BtnUpload.Text = "Upload";
            this.BtnUpload.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(59, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Homeworks";
            // 
            // BtnLogout
            // 
            this.BtnLogout.BorderColor = System.Drawing.Color.Khaki;
            this.BtnLogout.BorderRadius = 15;
            this.BtnLogout.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.BtnLogout.BorderThickness = 5;
            this.BtnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLogout.FillColor = System.Drawing.Color.Gray;
            this.BtnLogout.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.ForeColor = System.Drawing.Color.Khaki;
            this.BtnLogout.Location = new System.Drawing.Point(187, 295);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(230, 54);
            this.BtnLogout.TabIndex = 5;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(59, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(531, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sellect Homework and upload the answer";
            // 
            // UploadHomework
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(628, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnUpload);
            this.Controls.Add(this.cmbAssignments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UploadHomework";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "UploadHomework";
            this.Load += new System.EventHandler(this.UploadHomework_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAssignments;
        private Guna.UI2.WinForms.Guna2Button BtnUpload;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button BtnLogout;
        private System.Windows.Forms.Label label2;
    }
}