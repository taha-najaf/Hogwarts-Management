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
    public partial class Courses : Form
    {
        public Courses()
        {
            InitializeComponent();
        }

        private void Curses_Load(object sender, EventArgs e)
        {
            showtable();
            FirsttextBox.Text = LoginForm.professor.FirstName;
            LastName.Text=LoginForm.professor.LastName;
        }

        private void FinishHourtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ProfessorPanel professor = new ProfessorPanel();
            professor.Show();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            int stnunm = 0;
            string cname=CoursecomboBox.Text;
            string day=DaycomboBox.Text;
            string time=TimecomboBox.Text;
            int term = int.Parse(TermcomboBox.Text);
            int capacity=int.Parse(CapacitycomboBox.Text);
            string teacherfirstname=FirsttextBox.Text;
            string teacherlastname=LastName.Text;
            Lesson lesson=new Lesson(cname,day,time,term,capacity,stnunm,teacherfirstname,teacherlastname);
            Lesson.AllLessons.Add(lesson);
            showtable();
                
        }

        private void TermcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            CoursecomboBox.ResetText();
            DaycomboBox.Text = string.Empty;
            TimecomboBox.Text = string.Empty;
            TermcomboBox.Text = string.Empty;
            CapacitycomboBox.Text = string.Empty;
            FirsttextBox.Text = string.Empty;
            LastName.Text = string.Empty;
        }
        public void showtable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Course Name",typeof(string));
            table.Columns.Add("Course Day",typeof (string));
            table.Columns.Add("Course Time", typeof(string));
            table.Columns.Add("Course Term", typeof(int));
            table.Columns.Add("Course Capacity", typeof(int));
            table.Columns.Add("Number of Students",typeof(int));
            table.Columns.Add("Teacher First Name",typeof(string));
            table.Columns.Add("Teacher Last Name", typeof(string));
            foreach (var lesson in Lesson.AllLessons)
            {
                table.Rows.Add(lesson.CourseName,lesson.CourseDay,lesson.CourseHour,lesson.PresentationSemester,lesson.Capacity,lesson.NumberOfStudents,lesson.ProfessorFirstName,lesson.ProfessorLastName);
            }
            DataGridView_Student.DataSource = table;
        }
    }
}
