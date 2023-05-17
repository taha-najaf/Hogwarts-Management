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
    public partial class CourseInfoForm : Form
    {
        public CourseInfoForm()
        {
            InitializeComponent();
        }

        private void LoginoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            DumbledoreForm form = new DumbledoreForm();
            form.ShowDialog();
        }

        private void ProfessorButton_Click(object sender, EventArgs e)
        {
            this.Close();
            TeacherInfoForm form = new TeacherInfoForm();
            form.ShowDialog();
        }

        private void StudentButton_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentsInfoForm form = new StudentsInfoForm();
            form.ShowDialog();
        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            this.Close();
            TrainForm form = new TrainForm();
            form.ShowDialog();
        }

        private void ForestButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ForestForm_add forestForm = new ForestForm_add();
            forestForm.ShowDialog();
        }

        private void DormitoryButton_Click(object sender, EventArgs e)
        {
            this.Close();
            DormitoryInfoForm form = new DormitoryInfoForm();
            form.ShowDialog();
        }
    }
}
