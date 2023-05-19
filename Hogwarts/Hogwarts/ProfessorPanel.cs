using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hogwarts
{
    public partial class ProfessorPanel : Form
    {
        public ProfessorPanel()
        {
            InitializeComponent();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void DefineLessonButton_Click(object sender, EventArgs e)
        {
            Courses courses = new Courses();
            courses.ShowDialog();
        }

        private void ProfessorPanel_Load(object sender, EventArgs e)
        {
            FirstNamelabel.Text = LoginForm.professor.FirstName;
            LastNmaelabel.Text=LoginForm.professor.LastName;
            Grouptypelabel.Text = LoginForm.professor.GroupName.ToString();
        }
    }
}
