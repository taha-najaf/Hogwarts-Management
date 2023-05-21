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
    public partial class SellectUnitForm : Form
    {
        public SellectUnitForm()
        {
            InitializeComponent();
        }

        private void SellectUnitForm_Load(object sender, EventArgs e)
        {
            table();
        }
        private void table()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Id",typeof(int));
            table.Columns.Add("Course Name", typeof(string));
            table.Columns.Add("Course Day", typeof(string));
            table.Columns.Add("Course Time", typeof(string));
            table.Columns.Add("Course Term", typeof(int));
            table.Columns.Add("Course Capacity", typeof(int));
            table.Columns.Add("Number of Students", typeof(int));
            table.Columns.Add("Teacher First Name", typeof(string));
            table.Columns.Add("Teacher Last Name", typeof(string));
            int id = 1;
            foreach (var lesson in Lesson.AllLessons)
            {
                table.Rows.Add(id,lesson.CourseName, lesson.CourseDay, lesson.CourseHour, lesson.PresentationSemester, lesson.Capacity, lesson.NumberOfStudents, lesson.ProfessorFirstName, lesson.ProfessorLastName);
                id++;
            }
            DataGridView_Lessons.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox_Id.Text);
            if (textBox_Id.Text=="")
                MessageBox.Show("Enter Id Number","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {
                foreach (var lesson in LoginForm.student.Curriculum)
                {
                    if (lesson.CourseHour != Lesson.AllLessons[id-1].CourseHour && lesson.CourseName != Lesson.AllLessons[id-1].CourseName)
                    {
                        LoginForm.student.Curriculum.Add(Lesson.AllLessons[id-1]);
                        
                    }
                    else if (lesson.CourseHour == Lesson.AllLessons[id-1].CourseHour)
                    {
                        MessageBox.Show("Your chosen course may interfere with your previous chosen courses","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                MessageBox.Show("Lessons were selected successfuly");
               
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentPanel panel = new StudentPanel();
            panel.ShowDialog();
        }
    }
}
