using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hogwarts
{
    public partial class RegisterStudent : Form
    {
        Student student = new Student();
        string pet;
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
        private void Addbutton_Click(object sender, EventArgs e)
        {
            //add new student
            string fname = FirstNametextBox.Text;
            string Lastname = LastName.Text;
            string fathername = FatherNametextBox.Text;
            DateTime dateTime = dateTimePicker1.Value;
            string gender = MaleradioButton.Checked ? "Male" : "Female";
            string blood = BloodcomboBox.Text;
            string username = UsernametextBox.Text;
            string password = PasswordtextBox.Text;
            string term = TermcomboBox.Text;
            string Pet = this.pet;
           
            //to check time between 10 to 18
            //int born_year = dateTimePicker1.Value.Year;
            //int this_year = DateTime.Now.Year;
            //if ((this_year - born_year) < 10 || (this_year - born_year > 18))
            //{
            //    MessageBox.Show("The student must be between 10 and 18", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            if (verify())
            {
                try
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox_student.Image.Save(ms, pictureBox_student.Image.RawFormat);

                    byte[] img = ms.ToArray();
                    if (student.insertStudent(fname, Lastname, fathername, dateTime, gender, Pet, blood, username, password, term, img))
                    {
                        MessageBox.Show("New student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //create a function to verify
        bool verify()
        {
            if ((FirsttextBox.Text == string.Empty) || (LastName.Text == string.Empty) || (FatherNametextBox.Text == string.Empty) || (UsernametextBox.Text == string.Empty) ||
                (PasswordtextBox.Text == string.Empty) || (BloodcomboBox.Text == string.Empty) || pictureBox_student.Image == null)
                return false;
            else
                return true;
        }

        private void PetgroupBox_Enter(object sender, EventArgs e)
        {
            
            if (OwlPetradioButton.Checked)
                 pet = "owl";
            else if (CatradioButton.Checked)
                pet = "cat";
            else if (RatradioButton.Checked)
                pet = "rat";

        }
    }
}
