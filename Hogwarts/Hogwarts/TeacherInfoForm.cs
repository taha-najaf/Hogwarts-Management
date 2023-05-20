using System;
using System.Data;
using System.Windows.Forms;

namespace Hogwarts
{
    public partial class TeacherInfoForm : Form
    {
        public TeacherInfoForm()
        {
            InitializeComponent();
        }

        private void LoginoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            DumbledoreForm dumbledoreForm = new DumbledoreForm();
            dumbledoreForm.ShowDialog();
        }

        private void TeacherInfoForm_Load(object sender, EventArgs e)
        {
            showtable();
        }

        private void StudentButton_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentsInfoForm studentsInfoForm = new StudentsInfoForm();
            studentsInfoForm.ShowDialog();
        }

        private void CoursesButton_Click(object sender, EventArgs e)
        {
            this.Close();
            CourseInfoForm courseInfoForm = new CourseInfoForm();
            courseInfoForm.ShowDialog();
        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            this.Close();
            TrainForm trainForm = new TrainForm();
            trainForm.ShowDialog();
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
            DormitoryInfoForm dormitoryInfoForm = new DormitoryInfoForm();
            dormitoryInfoForm.ShowDialog();
        }
        private void showtable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("First Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("Date Of Birth", typeof(string));
            table.Columns.Add("Father Name", typeof(string));
            table.Columns.Add("Gender", typeof(string));
            table.Columns.Add("Username", typeof(string));
            table.Columns.Add("Password", typeof(string));
            table.Columns.Add("Group Name");
            table.Columns.Add("Pet");
            foreach (var teacher in Teacher.TeacherList)
            {
                table.Rows.Add(teacher.FirstName, teacher.LastName, teacher.Birthday, teacher.FatherName, teacher.Gender
                    , teacher.Username, teacher.Password, teacher.GroupName, teacher.Pet);
            }

            DataGridView_Teacher.DataSource = table;

        }
    }
}
