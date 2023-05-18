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
    public partial class RegisterStudent : Form
    {
        public RegisterStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentsInfoForm studentsInfoForm = new StudentsInfoForm();
            studentsInfoForm.ShowDialog();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UploadPhotobutton_Click(object sender, EventArgs e)
        {
            //browse photo from PC
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter="Select Photo(*.jpg;*.png;*.gif)| *.jpg; *.png; *.gif";
            if(opf.ShowDialog() == DialogResult.OK)
                pictureBox_student.Image = Image.FromFile(opf.FileName);   
        }

    }
}
