﻿namespace Hogwarts
{
    partial class StudentPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.FirstNamelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PassedUnits = new System.Windows.Forms.ListBox();
            this.Grouptypelabel = new System.Windows.Forms.Label();
            this.LastNmaelabel = new System.Windows.Forms.Label();
            this.Dormitorylabel = new System.Windows.Forms.Label();
            this.Termlabel = new System.Windows.Forms.Label();
            this.Petlabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SendLetterButton = new System.Windows.Forms.Button();
            this.SellectUnitButton = new System.Windows.Forms.Button();
            this.UploadHomeworkButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.DataGridView_Lessons = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Lessons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Location = new System.Drawing.Point(243, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(12, 672);
            this.panel1.TabIndex = 0;
            // 
            // FirstNamelabel
            // 
            this.FirstNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNamelabel.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.FirstNamelabel.Location = new System.Drawing.Point(23, 33);
            this.FirstNamelabel.Name = "FirstNamelabel";
            this.FirstNamelabel.Size = new System.Drawing.Size(146, 38);
            this.FirstNamelabel.TabIndex = 2;
            this.FirstNamelabel.Text = "Firstname:";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(485, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome to Student Panel";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PassedUnits);
            this.panel2.Controls.Add(this.Grouptypelabel);
            this.panel2.Controls.Add(this.LastNmaelabel);
            this.panel2.Controls.Add(this.Dormitorylabel);
            this.panel2.Controls.Add(this.Termlabel);
            this.panel2.Controls.Add(this.Petlabel);
            this.panel2.Controls.Add(this.FirstNamelabel);
            this.panel2.Location = new System.Drawing.Point(270, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(989, 203);
            this.panel2.TabIndex = 4;
            // 
            // PassedUnits
            // 
            this.PassedUnits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.PassedUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassedUnits.ForeColor = System.Drawing.Color.Khaki;
            this.PassedUnits.FormattingEnabled = true;
            this.PassedUnits.ItemHeight = 25;
            this.PassedUnits.Location = new System.Drawing.Point(343, 164);
            this.PassedUnits.Name = "PassedUnits";
            this.PassedUnits.Size = new System.Drawing.Size(172, 29);
            this.PassedUnits.Sorted = true;
            this.PassedUnits.TabIndex = 3;
            // 
            // Grouptypelabel
            // 
            this.Grouptypelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grouptypelabel.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.Grouptypelabel.Location = new System.Drawing.Point(699, 33);
            this.Grouptypelabel.Name = "Grouptypelabel";
            this.Grouptypelabel.Size = new System.Drawing.Size(146, 38);
            this.Grouptypelabel.TabIndex = 2;
            this.Grouptypelabel.Text = "Group Type:";
            // 
            // LastNmaelabel
            // 
            this.LastNmaelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNmaelabel.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.LastNmaelabel.Location = new System.Drawing.Point(369, 33);
            this.LastNmaelabel.Name = "LastNmaelabel";
            this.LastNmaelabel.Size = new System.Drawing.Size(146, 38);
            this.LastNmaelabel.TabIndex = 2;
            this.LastNmaelabel.Text = "Lastname:";
            // 
            // Dormitorylabel
            // 
            this.Dormitorylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dormitorylabel.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.Dormitorylabel.Location = new System.Drawing.Point(699, 113);
            this.Dormitorylabel.Name = "Dormitorylabel";
            this.Dormitorylabel.Size = new System.Drawing.Size(225, 38);
            this.Dormitorylabel.TabIndex = 2;
            this.Dormitorylabel.Text = "Dormitory Code:";
            // 
            // Termlabel
            // 
            this.Termlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Termlabel.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.Termlabel.Location = new System.Drawing.Point(369, 113);
            this.Termlabel.Name = "Termlabel";
            this.Termlabel.Size = new System.Drawing.Size(146, 38);
            this.Termlabel.TabIndex = 2;
            this.Termlabel.Text = "Term:";
            // 
            // Petlabel
            // 
            this.Petlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Petlabel.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.Petlabel.Location = new System.Drawing.Point(23, 113);
            this.Petlabel.Name = "Petlabel";
            this.Petlabel.Size = new System.Drawing.Size(146, 38);
            this.Petlabel.TabIndex = 2;
            this.Petlabel.Text = "Pet:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(2, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 83);
            this.button1.TabIndex = 5;
            this.button1.Text = "Inbox";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SendLetterButton
            // 
            this.SendLetterButton.AutoSize = true;
            this.SendLetterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.SendLetterButton.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.SendLetterButton.FlatAppearance.BorderSize = 3;
            this.SendLetterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SendLetterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SendLetterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendLetterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendLetterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SendLetterButton.Location = new System.Drawing.Point(94, 303);
            this.SendLetterButton.Name = "SendLetterButton";
            this.SendLetterButton.Size = new System.Drawing.Size(143, 39);
            this.SendLetterButton.TabIndex = 5;
            this.SendLetterButton.Text = "Send Letter";
            this.SendLetterButton.UseVisualStyleBackColor = false;
            this.SendLetterButton.Click += new System.EventHandler(this.SendLetterButton_Click);
            // 
            // SellectUnitButton
            // 
            this.SellectUnitButton.AutoSize = true;
            this.SellectUnitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.SellectUnitButton.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.SellectUnitButton.FlatAppearance.BorderSize = 3;
            this.SellectUnitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SellectUnitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SellectUnitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellectUnitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellectUnitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SellectUnitButton.Location = new System.Drawing.Point(94, 402);
            this.SellectUnitButton.Name = "SellectUnitButton";
            this.SellectUnitButton.Size = new System.Drawing.Size(143, 39);
            this.SellectUnitButton.TabIndex = 5;
            this.SellectUnitButton.Text = "Sellect Unit";
            this.SellectUnitButton.UseVisualStyleBackColor = false;
            this.SellectUnitButton.Click += new System.EventHandler(this.SellectUnitButton_Click);
            // 
            // UploadHomeworkButton
            // 
            this.UploadHomeworkButton.AutoSize = true;
            this.UploadHomeworkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.UploadHomeworkButton.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.UploadHomeworkButton.FlatAppearance.BorderSize = 3;
            this.UploadHomeworkButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UploadHomeworkButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UploadHomeworkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadHomeworkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadHomeworkButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UploadHomeworkButton.Location = new System.Drawing.Point(94, 499);
            this.UploadHomeworkButton.Name = "UploadHomeworkButton";
            this.UploadHomeworkButton.Size = new System.Drawing.Size(143, 39);
            this.UploadHomeworkButton.TabIndex = 5;
            this.UploadHomeworkButton.Text = "Upload Homework";
            this.UploadHomeworkButton.UseVisualStyleBackColor = false;
            this.UploadHomeworkButton.Click += new System.EventHandler(this.UploadHomeworkButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.LogoutButton.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.LogoutButton.FlatAppearance.BorderSize = 3;
            this.LogoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LogoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogoutButton.Location = new System.Drawing.Point(94, 606);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(143, 39);
            this.LogoutButton.TabIndex = 5;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // DataGridView_Lessons
            // 
            this.DataGridView_Lessons.AllowUserToAddRows = false;
            this.DataGridView_Lessons.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_Lessons.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_Lessons.BackgroundColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Lessons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_Lessons.ColumnHeadersHeight = 30;
            this.DataGridView_Lessons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_Lessons.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_Lessons.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_Lessons.Location = new System.Drawing.Point(270, 389);
            this.DataGridView_Lessons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridView_Lessons.Name = "DataGridView_Lessons";
            this.DataGridView_Lessons.RowHeadersVisible = false;
            this.DataGridView_Lessons.RowHeadersWidth = 51;
            this.DataGridView_Lessons.RowTemplate.Height = 80;
            this.DataGridView_Lessons.Size = new System.Drawing.Size(980, 273);
            this.DataGridView_Lessons.TabIndex = 14;
            this.DataGridView_Lessons.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_Lessons.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_Lessons.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_Lessons.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_Lessons.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_Lessons.ThemeStyle.BackColor = System.Drawing.Color.DimGray;
            this.DataGridView_Lessons.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_Lessons.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_Lessons.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_Lessons.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_Lessons.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_Lessons.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_Lessons.ThemeStyle.HeaderStyle.Height = 30;
            this.DataGridView_Lessons.ThemeStyle.ReadOnly = false;
            this.DataGridView_Lessons.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_Lessons.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_Lessons.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_Lessons.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_Lessons.ThemeStyle.RowsStyle.Height = 80;
            this.DataGridView_Lessons.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_Lessons.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(626, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 45);
            this.label1.TabIndex = 15;
            this.label1.Text = "Courses";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox5.Image = global::Hogwarts.Properties.Resources.download__4_1;
            this.pictureBox5.Location = new System.Drawing.Point(2, 576);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(86, 69);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox4.Image = global::Hogwarts.Properties.Resources.download__14_;
            this.pictureBox4.Location = new System.Drawing.Point(2, 469);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(86, 69);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox3.Image = global::Hogwarts.Properties.Resources.download__3_1;
            this.pictureBox3.Location = new System.Drawing.Point(2, 372);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(86, 69);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox2.Image = global::Hogwarts.Properties.Resources.download__13_;
            this.pictureBox2.Location = new System.Drawing.Point(2, 273);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Hogwarts.Properties.Resources.rsz_1download_27;
            this.pictureBox1.Location = new System.Drawing.Point(2, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // StudentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridView_Lessons);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.UploadHomeworkButton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.SellectUnitButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.SendLetterButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Khaki;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentPanel";
            this.Load += new System.EventHandler(this.StudentPanel_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Lessons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label FirstNamelabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Grouptypelabel;
        private System.Windows.Forms.Label LastNmaelabel;
        private System.Windows.Forms.Label Petlabel;
        private System.Windows.Forms.Label Dormitorylabel;
        private System.Windows.Forms.Label Termlabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button SendLetterButton;
        private System.Windows.Forms.Button SellectUnitButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button UploadHomeworkButton;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ListBox PassedUnits;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_Lessons;
        private System.Windows.Forms.Label label1;
    }
}