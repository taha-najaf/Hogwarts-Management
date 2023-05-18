namespace Hogwarts
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.NameSchoolLabel = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.LoginButtun = new System.Windows.Forms.Button();
            this.Resetlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameSchoolLabel
            // 
            this.NameSchoolLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameSchoolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameSchoolLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NameSchoolLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NameSchoolLabel.Location = new System.Drawing.Point(132, 135);
            this.NameSchoolLabel.Name = "NameSchoolLabel";
            this.NameSchoolLabel.Size = new System.Drawing.Size(985, 116);
            this.NameSchoolLabel.TabIndex = 0;
            this.NameSchoolLabel.Text = "Hogwarts School of Witchcraft and Wizardry";
            this.NameSchoolLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NameSchoolLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.CadetBlue;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Username.Location = new System.Drawing.Point(303, 394);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(117, 25);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username:";
            this.Username.Click += new System.EventHandler(this.Username_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(303, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password: ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UsernameTextbox.Location = new System.Drawing.Point(468, 394);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(248, 22);
            this.UsernameTextbox.TabIndex = 3;
            this.UsernameTextbox.Tag = "0";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PasswordTextbox.Location = new System.Drawing.Point(468, 487);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '+';
            this.PasswordTextbox.Size = new System.Drawing.Size(248, 22);
            this.PasswordTextbox.TabIndex = 3;
            this.PasswordTextbox.Tag = "1";
            // 
            // LoginButtun
            // 
            this.LoginButtun.BackColor = System.Drawing.Color.Transparent;
            this.LoginButtun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginButtun.BackgroundImage")));
            this.LoginButtun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginButtun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButtun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LoginButtun.Location = new System.Drawing.Point(792, 417);
            this.LoginButtun.Name = "LoginButtun";
            this.LoginButtun.Size = new System.Drawing.Size(122, 45);
            this.LoginButtun.TabIndex = 4;
            this.LoginButtun.Tag = "2";
            this.LoginButtun.Text = "Login";
            this.LoginButtun.UseVisualStyleBackColor = false;
            this.LoginButtun.Click += new System.EventHandler(this.LoginButtun_Click);
            // 
            // Resetlabel
            // 
            this.Resetlabel.AutoSize = true;
            this.Resetlabel.BackColor = System.Drawing.Color.Transparent;
            this.Resetlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resetlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Resetlabel.Location = new System.Drawing.Point(819, 483);
            this.Resetlabel.Name = "Resetlabel";
            this.Resetlabel.Size = new System.Drawing.Size(62, 25);
            this.Resetlabel.TabIndex = 5;
            this.Resetlabel.Text = "Reset";
            this.Resetlabel.Click += new System.EventHandler(this.Resetlabel_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.Resetlabel);
            this.Controls.Add(this.LoginButtun);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.UsernameTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.NameSchoolLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameSchoolLabel;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.Button LoginButtun;
        private System.Windows.Forms.Label Resetlabel;
    }
}

