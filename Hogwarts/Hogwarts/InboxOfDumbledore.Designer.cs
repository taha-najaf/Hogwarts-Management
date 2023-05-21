namespace Hogwarts
{
    partial class InboxOfDumbledore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InboxOfDumbledore));
            this.LoginoutButton = new System.Windows.Forms.Button();
            this.LogoutPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_letters = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginoutButton
            // 
            this.LoginoutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LoginoutButton.FlatAppearance.BorderSize = 5;
            this.LoginoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.LoginoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginoutButton.Location = new System.Drawing.Point(358, 377);
            this.LoginoutButton.Name = "LoginoutButton";
            this.LoginoutButton.Size = new System.Drawing.Size(179, 49);
            this.LoginoutButton.TabIndex = 20;
            this.LoginoutButton.Text = "Logout";
            this.LoginoutButton.UseVisualStyleBackColor = true;
            this.LoginoutButton.Click += new System.EventHandler(this.LoginoutButton_Click);
            // 
            // LogoutPictureBox
            // 
            this.LogoutPictureBox.BackColor = System.Drawing.Color.Khaki;
            this.LogoutPictureBox.Image = global::Hogwarts.Properties.Resources.download__4_;
            this.LogoutPictureBox.Location = new System.Drawing.Point(240, 361);
            this.LogoutPictureBox.Name = "LogoutPictureBox";
            this.LogoutPictureBox.Padding = new System.Windows.Forms.Padding(5, 7, 0, 0);
            this.LogoutPictureBox.Size = new System.Drawing.Size(112, 65);
            this.LogoutPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LogoutPictureBox.TabIndex = 19;
            this.LogoutPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(268, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Letters From students ";
            // 
            // listBox_letters
            // 
            this.listBox_letters.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_letters.ForeColor = System.Drawing.Color.SteelBlue;
            this.listBox_letters.FormattingEnabled = true;
            this.listBox_letters.ItemHeight = 29;
            this.listBox_letters.Location = new System.Drawing.Point(12, 106);
            this.listBox_letters.Name = "listBox_letters";
            this.listBox_letters.Size = new System.Drawing.Size(776, 236);
            this.listBox_letters.TabIndex = 23;
            this.listBox_letters.SelectedIndexChanged += new System.EventHandler(this.listBox_letters_SelectedIndexChanged);
            // 
            // InboxOfDumbledore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox_letters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginoutButton);
            this.Controls.Add(this.LogoutPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InboxOfDumbledore";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "InboxOfDumbledore";
            this.Load += new System.EventHandler(this.InboxOfDumbledore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoutPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginoutButton;
        private System.Windows.Forms.PictureBox LogoutPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_letters;
    }
}