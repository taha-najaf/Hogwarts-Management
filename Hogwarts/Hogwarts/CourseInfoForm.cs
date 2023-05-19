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
        private void showtable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Course Name", typeof(string));
            table.Columns.Add("Course Day", typeof(string));
            table.Columns.Add("Course Time", typeof(string));
            table.Columns.Add("Course Term", typeof(int));
            table.Columns.Add("Course Capacity", typeof(int));
            table.Columns.Add("Number of Students", typeof(int));
            table.Columns.Add("Teacher First Name", typeof(string));
            table.Columns.Add("Teacher Last Name", typeof(string));
            foreach (var lesson in Lesson.AllLessons)
            {
                table.Rows.Add(lesson.CourseName, lesson.CourseDay, lesson.CourseHour, lesson.PresentationSemester, lesson.Capacity, lesson.NumberOfStudents, lesson.ProfessorFirstName, lesson.ProfessorLastName);
            }
            DataGridView_Student.DataSource = table;
        }

        private void CourseInfoForm_Load(object sender, EventArgs e)
        {
            showtable();
        }
    }
}
