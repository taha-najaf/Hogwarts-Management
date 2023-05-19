using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Hogwarts
{
    public partial class StudentsInfoForm : Form
    {
        Student Student =new Student();
        public StudentsInfoForm()
        {
            InitializeComponent();
        }

        private void StudentButton_Click(object sender, EventArgs e)
        {

        }

        private void TrainPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void CoursesButton_Click(object sender, EventArgs e)
        {
            this.Close();
            CourseInfoForm courseInfoForm = new CourseInfoForm();
            courseInfoForm.ShowDialog();
        }

        private void LoginoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            DumbledoreForm form = new DumbledoreForm();
            form.ShowDialog();

        }

        private void StudentsInfoForm_Load(object sender, EventArgs e)
        {
            totalstudent.Text = "Total Students: " + Student.totalstudent();
            Malelabel.Text= "Male : "+Student.malestudent();
            femalelabel.Text="Female: "+Student.femalestudent();
            showdata(new MySqlCommand("SELECT * FROM `student`"));


        }

        private void ProfessorButton_Click(object sender, EventArgs e)
        {
            this.Close();
            TeacherInfoForm teacherInfoForm = new TeacherInfoForm();
            teacherInfoForm.ShowDialog();
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
            ForestForm_add forestForm_Add = new ForestForm_add();   
            forestForm_Add.ShowDialog();
        }

        private void DormitoryButton_Click(object sender, EventArgs e)
        {
            this.Close();
            DormitoryInfoForm dormitoryInfoForm = new DormitoryInfoForm();
            dormitoryInfoForm.ShowDialog();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // show student
        public void showdata(MySqlCommand command)
        {
            DataGridView_Student.ReadOnly = true;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            //DataGridView_Student.Height = 80;
            DataGridView_Student.DataSource = Student.getlist(command);
            imageColumn = (DataGridViewImageColumn)DataGridView_Student.Columns[11];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }
    }
}
