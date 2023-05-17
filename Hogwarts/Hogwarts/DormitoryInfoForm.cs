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
    public partial class DormitoryInfoForm : Form
    {
        public DormitoryInfoForm()
        {
            InitializeComponent();
        }

        private void LoginoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            DumbledoreForm dumbledoreForm = new DumbledoreForm();
            dumbledoreForm.ShowDialog();
        }

        private void ProfessorButton_Click(object sender, EventArgs e)
        {
            this.Close();
            TeacherInfoForm teacherInfoForm = new TeacherInfoForm();
            teacherInfoForm.ShowDialog();
        }

        private void StudentButton_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentsInfoForm studentsInfoForm = new StudentsInfoForm();
            studentsInfoForm.ShowDialog();
        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            this.Close();
            TrainForm trainForm = new TrainForm();
            trainForm.ShowDialog();
        }

        private void CoursesButton_Click(object sender, EventArgs e)
        {
            this.Close();
            CourseInfoForm courseInfoForm = new CourseInfoForm();
            courseInfoForm.ShowDialog();
        }

        private void ForestButton_Click(object sender, EventArgs e)
        {
            this .Close();
            ForestForm_add forestForm = new ForestForm_add();
            forestForm.ShowDialog();
        }
    }
}
