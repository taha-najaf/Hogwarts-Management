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
    public partial class ForestForm_add : Form
    {
        public ForestForm_add()
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
            this.Close ();
            TeacherInfoForm teacherInfoForm = new TeacherInfoForm();
            teacherInfoForm.ShowDialog();
        }

        private void StudentButton_Click(object sender, EventArgs e)
        {
            this. Close();
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

        private void DormitoryButton_Click(object sender, EventArgs e)
        {
            this .Close();
            DormitoryInfoForm dormitoryInfoForm = new DormitoryInfoForm();
            dormitoryInfoForm.ShowDialog();
        }

        private void showtable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Plant Name", typeof(string));
            table.Columns.Add("Number of Plant", typeof(int));
            table.Columns.Add("Description", typeof(string));
            foreach (var plant in Plant.Plants)
            {
                table.Rows.Add(plant.Name, plant.Number,plant.Description);
            }
            DataGridView_Forest.DataSource = table;
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            string name = Name_textBox2.Text;
            int num=int.Parse(textBox_num.Text);
            string des=textBox_Description.Text;
            Plant plant=new Plant(name,num,des);
            Plant.Plants.Add(plant);
            showtable();
        }
    }
}
