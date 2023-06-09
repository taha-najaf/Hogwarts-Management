﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hogwarts
{
    public partial class LoginForm : Form
    {
        public static Teacher professor=new Teacher();
        public static Student student = new Student();
        public LoginForm() 
        {
            InitializeComponent();
            //Panel overlayPanel = new Panel();
            //overlayPanel.Dock = DockStyle.Fill;
            //overlayPanel.BackColor=Color.FromArgb(25,Color.Blue);
            //this.Controls.Add(overlayPanel);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void LoginButtun_Click(object sender, EventArgs e)
        {

            if (UsernameTextbox.Text == string.Empty && PasswordTextbox.Text == string.Empty)
                MessageBox.Show("Please enter username and password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (UsernameTextbox.Text == string.Empty)
                MessageBox.Show("Please enter username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (PasswordTextbox.Text == string.Empty)
                MessageBox.Show("Please enter password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //=============================find user

            int result = User.FindUser(UsernameTextbox.Text, PasswordTextbox.Text);
            if (result == 0)
                MessageBox.Show("User not found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (result == 1)
            {
                //MessageBox.Show("Dumbledore");
                DumbledoreForm dumbledoreForm = new DumbledoreForm();
                UsernameTextbox.Text = string.Empty;
                PasswordTextbox.Text = string.Empty;
                dumbledoreForm.ShowDialog();

            }
            else if (result == 2)
            {
                StudentPanel studentPanel = new StudentPanel();
                student=User.TakeStudentObject(UsernameTextbox.Text,PasswordTextbox.Text);
                UsernameTextbox.Text = string.Empty;
                PasswordTextbox.Text = string.Empty;
                studentPanel.ShowDialog();
            }
            else if (result == 3)
            { 
                ProfessorPanel pro =new ProfessorPanel();
                professor=User.TakeTeacherObject(UsernameTextbox.Text,PasswordTextbox.Text);
                UsernameTextbox.Text = string.Empty;
                PasswordTextbox.Text = string.Empty;
                pro.ShowDialog();
            }
        }

        private void Resetlabel_Click(object sender, EventArgs e)
        {
            UsernameTextbox.Text = string.Empty;
            PasswordTextbox.Text = string.Empty;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
