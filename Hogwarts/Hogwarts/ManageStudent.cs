using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Hogwarts
{
    public partial class ManageStudent : Form
    {
        Student student=new Student();
        string pet;
        public ManageStudent()
        {
            InitializeComponent();
        }

        private void ManageStudent_Load(object sender, EventArgs e)
        {
            ShowTable();
        }
        public void ShowTable()
        {
            DataGridView_Student.DataSource = student.getStudentList();

            DataGridViewImageColumn imagecolumn = new DataGridViewImageColumn();
            imagecolumn = (DataGridViewImageColumn)DataGridView_Student.Columns[11];
            imagecolumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        //display student data from student to text box
        private void DataGridView_Student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDtextBox.Text = DataGridView_Student.CurrentRow.Cells[0].Value.ToString();
            FirstNametextBox.Text = DataGridView_Student.CurrentRow.Cells[1].Value.ToString();
            LastNametextBox.Text = DataGridView_Student.CurrentRow.Cells[2].Value.ToString();
            FatherNametextBox.Text = DataGridView_Student.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker1.Text = DataGridView_Student.CurrentRow.Cells[4].Value.ToString();
            if (DataGridView_Student.CurrentRow.Cells[5].Value.ToString() == "Male")
            {
                MaleradioButton.Checked = true;
            }
            else
            {
                FemaleradioButton.Checked = true;
            }
            switch (DataGridView_Student.CurrentRow.Cells[6].Value.ToString())
            {
                case "owl":
                    OwlPetradioButton.Checked = true;
                    break;
                case "cat":
                    CatradioButton.Checked = true;
                    break;
                case "rat":
                    RatradioButton.Checked = true;
                    break;
            }
            switch (DataGridView_Student.CurrentRow.Cells[7].Value.ToString())
            {
                case "HalfBlood":
                    BloodcomboBox.SelectedIndex = 0;
                    break;
                case "MuggleBlood":
                    BloodcomboBox.SelectedIndex = 1;
                    break;
                case "PureBlood":
                    BloodcomboBox.SelectedIndex = 2;
                    break;
            }
                    
            UsernametextBox.Text = DataGridView_Student.CurrentRow.Cells[8].Value.ToString();

            PasswordtextBox.Text = DataGridView_Student.CurrentRow.Cells[9].Value.ToString();
            switch(DataGridView_Student.CurrentRow.Cells[10].Value.ToString())
            {
                case "1":
                    TermcomboBox.SelectedIndex = 0; break;
                case "2":
                    TermcomboBox.SelectedIndex = 1; break;
                case "3":
                    TermcomboBox.SelectedIndex = 2; break;
                case "4":
                    TermcomboBox.SelectedIndex = 3; break;
                case "5":
                    TermcomboBox.SelectedIndex = 4; break;
                case "6":
                    TermcomboBox.SelectedIndex = 5; break;
                case "7":
                    TermcomboBox.SelectedIndex = 6; break;
                case "8":
                    TermcomboBox.SelectedIndex = 7; break;
            }
            byte[] img = (byte[])DataGridView_Student.CurrentRow.Cells[11].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox_student.Image=Image.FromStream(ms);
        }

        private void FirsttextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            IDtextBox.Clear();
            FirstNametextBox.Clear();
            LastNametextBox.Clear();
            FatherNametextBox.Clear();
            UsernametextBox.Clear();
            PasswordtextBox.Clear();
            BloodcomboBox.SelectedIndex = -1;
            TermcomboBox.SelectedIndex = -1;
            dateTimePicker1.Value=DateTime.Now;
            pictureBox_student.Image = null;
        }

        private void UploadPhotobutton_Click(object sender, EventArgs e)
        {
            //browse photo from PC
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif)| *.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
                pictureBox_student.Image = Image.FromFile(opf.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridView_Student.DataSource = student.SearchStudent(data_textBox.Text);

            DataGridViewImageColumn imagecolumn = new DataGridViewImageColumn();
            imagecolumn = (DataGridViewImageColumn)DataGridView_Student.Columns[11];
            imagecolumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            //update student
            int id=Convert.ToInt32(IDtextBox.Text);
            string fname = FirstNametextBox.Text;
            string Lastname = LastNametextBox.Text;
            string fathername = FatherNametextBox.Text;
            DateTime dateTime = dateTimePicker1.Value;
            string gender = MaleradioButton.Checked ? "Male" : "Female";
            string blood = BloodcomboBox.Text;
            string username = UsernametextBox.Text;
            string password = PasswordtextBox.Text;
            string term = TermcomboBox.Text;
            string Pet = this.pet;

          
            if (verify())
            {
                try
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox_student.Image.Save(ms, pictureBox_student.Image.RawFormat);

                    byte[] img = ms.ToArray();
                    if (student.updateStudent(id,fname, Lastname, fathername, dateTime, gender, Pet, blood, username, password, term, img))
                    {
                        ShowTable();
                        MessageBox.Show("Student data update", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        bool verify()
        {
            if ((FirstNametextBox.Text == string.Empty) || (LastNametextBox.Text == string.Empty) || (FatherNametextBox.Text == string.Empty) || (UsernametextBox.Text == string.Empty) ||
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
