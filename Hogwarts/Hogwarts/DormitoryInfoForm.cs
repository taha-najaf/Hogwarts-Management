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

        private void DormitoryInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        Dormitory dormitory;
        int slytherinDorm = 110, ravenclawDorm = 110, gryffindorDorm = 110, hufflepuffDorm = 110;

        private void btnRavenclaw_Click(object sender, EventArgs e)
        {
            foreach (var student in Student.StudentsList)
            {
                if(student.GroupName==GroupType.Ravenclaw)
                {
                    dormitory = new Dormitory(ravenclawDorm);
                    student.DormitoryNumber = dormitory.GetDormitoryNumber(ravenclawDorm);
                    ravenclawDorm = student.DormitoryNumber;
                }
            }
            MessageBox.Show("Dormitory Managed");
        }

        private void btnHufflepuff_Click(object sender, EventArgs e)
        {
            foreach (var student in Student.StudentsList)
            {
                if (student.GroupName==GroupType.Hufflepuff)
                {
                    dormitory = new Dormitory(hufflepuffDorm);
                    student.DormitoryNumber = dormitory.GetDormitoryNumber(hufflepuffDorm);
                    hufflepuffDorm = student.DormitoryNumber;
                }
            }
            MessageBox.Show("Dormitory Managed");
        }

        private void btnGriffindor_Click(object sender, EventArgs e)
        {
            foreach (var student in Student.StudentsList)
            {
                if (student.GroupName==GroupType.Gryffindor)
                {
                    dormitory = new Dormitory(gryffindorDorm);
                    student.DormitoryNumber = dormitory.GetDormitoryNumber(gryffindorDorm);
                    gryffindorDorm = student.DormitoryNumber;
                }
            }
            MessageBox.Show("Dormitory Managed");
        }

        private void btnSlytherin_Click(object sender, EventArgs e)
        {
            foreach (var student in Student.StudentsList)
            {
                if (student.GroupName==GroupType.Slytherin)
                {
                    dormitory = new Dormitory(slytherinDorm);
                    student.DormitoryNumber = dormitory.GetDormitoryNumber(slytherinDorm);
                    slytherinDorm = student.DormitoryNumber;
                }
            }
            MessageBox.Show("Dormitory Managed");
        }
    }
}
