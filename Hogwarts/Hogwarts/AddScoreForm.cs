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
    public partial class AddScoreForm : Form
    {
        Student std = new Student();
        public AddScoreForm()
        {
            InitializeComponent();
        }

        private void textBox_firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_LastNmae_Click(object sender, EventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ProfessorPanel professorPanel = new ProfessorPanel();
            professorPanel.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            
        }

        public void button_search_Click(object sender, EventArgs e)
        {
            int id = 1;
            try
            {
                string fname=textBox_firstname.Text;
                string lname = textBox_lastname.Text;
             
                std=User.TakeStudentObject_ForScore(fname, lname);
                if (std != null )
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("Id");
                    table.Columns.Add("Course Name");
                    table.Columns.Add("Course Day");
                    table.Columns.Add("Course Time");
                    table.Columns.Add("Course ProfessorFirstName");
                    table.Columns.Add("Course Professor LastName");
                    table.Columns.Add("Score");
                    foreach (var lesson in std.Curriculum)
                    {
                        table.Rows.Add(id,lesson.CourseName,lesson.CourseDay,lesson.CourseHour,lesson.ProfessorFirstName,lesson.ProfessorLastName,lesson.StudentScore);
                        id++;
                    }
                    DataGridView_StudentList.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Student Isn't in list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_firstname.Text = string.Empty;
                    textBox_lastname.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Id_TextChanged(object sender, EventArgs e)
        {
        }

        private void button_Set_Click(object sender, EventArgs e)
        {
            int id=int.Parse(textBox_Id.Text);
            string fname = textBox_firstname.Text;
            string lname = textBox_lastname.Text;

            std = User.TakeStudentObject_ForScore(fname, lname);

            if (textBox_Id.Text==string.Empty)
            {
                MessageBox.Show("Enter Id Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (std.Curriculum[id - 1].ProfessorFirstName == LoginForm.professor.FirstName && std.Curriculum[id - 1].ProfessorLastName == LoginForm.professor.LastName)
                {
                    std.Curriculum[id - 1].StudentScore = ComboBox_score.Text;
                    MessageBox.Show("Score Add");
                    // show table
                    DataTable table = new DataTable();
                    table.Columns.Add("Id");
                    table.Columns.Add("Course Name");
                    table.Columns.Add("Course Day");
                    table.Columns.Add("Course Time");
                    table.Columns.Add("Course ProfessorFirstName");
                    table.Columns.Add("Course Professor LastName");
                    table.Columns.Add("Score");
                    foreach (var lesson in std.Curriculum)
                    {
                        table.Rows.Add(id, lesson.CourseName, lesson.CourseDay, lesson.CourseHour, lesson.ProfessorFirstName, lesson.ProfessorLastName,lesson.StudentScore);
                        id++;
                    }
                    DataGridView_StudentList.DataSource = table;
                }
                else
                    MessageBox.Show("You Can Just Score Your lessos");
            }
        }
    }
}
