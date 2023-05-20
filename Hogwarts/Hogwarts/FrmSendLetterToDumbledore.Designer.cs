namespace Hogwarts
{
    partial class FrmSendLetterToDumbledore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSendLetterToDumbledore));
            this.BtnSend = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GradientTileButton1 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.SuspendLayout();
            // 
            // BtnSend
            // 
            this.BtnSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSend.FillColor = System.Drawing.Color.Khaki;
            this.BtnSend.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSend.ForeColor = System.Drawing.Color.Black;
            this.BtnSend.Location = new System.Drawing.Point(210, 49);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnSend.Size = new System.Drawing.Size(172, 118);
            this.BtnSend.TabIndex = 0;
            this.BtnSend.Text = "Send";
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(125, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Send request to go home to Dumbledore";
            // 
            // guna2GradientTileButton1
            // 
            this.guna2GradientTileButton1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2GradientTileButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientTileButton1.FillColor = System.Drawing.Color.Red;
            this.guna2GradientTileButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2GradientTileButton1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientTileButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton1.Location = new System.Drawing.Point(210, 179);
            this.guna2GradientTileButton1.Name = "guna2GradientTileButton1";
            this.guna2GradientTileButton1.Size = new System.Drawing.Size(166, 53);
            this.guna2GradientTileButton1.TabIndex = 2;
            this.guna2GradientTileButton1.Text = "Logout";
            this.guna2GradientTileButton1.Click += new System.EventHandler(this.guna2GradientTileButton1_Click);
            // 
            // FrmSendLetterToDumbledore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(614, 244);
            this.Controls.Add(this.guna2GradientTileButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSendLetterToDumbledore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmSendLetterToDumbledore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton BtnSend;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton1;
    }
}