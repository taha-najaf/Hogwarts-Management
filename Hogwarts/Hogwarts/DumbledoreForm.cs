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
    public partial class DumbledoreForm : Form
    {
        public DumbledoreForm()
        {
            InitializeComponent();
            //Panel overlayPanel = new Panel();
            //overlayPanel.Dock = DockStyle.Fill;
            //overlayPanel.BackColor = Color.FromArgb(31,47,48);
            //this.Controls.Add(overlayPanel);
            //===============labrl
            //DateTime dateTime = DateTime.Now;
            //label10.Text = "Time Entered is:";
            //label10.Text += dateTime.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void StudentButton_Click(object sender, EventArgs e)
        {

        }

        private void DumbledoreForm_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void StudentPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void ForestButton_Click(object sender, EventArgs e)
        {
            ForestForm_add forestForm = new ForestForm_add();
            forestForm.ShowDialog();
        }

        private void StudentInfolabel_Click(object sender, EventArgs e)
        {

        }

        private void BloodInfolabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CoursesButton_Click(object sender, EventArgs e)
        {
            CourseInfoForm form = new CourseInfoForm();
            form.ShowDialog();
        }

        private void ProfessorButton_Click(object sender, EventArgs e)
        {
            TeacherInfoForm form = new TeacherInfoForm();
            form.ShowDialog();
        }

        private void StudentButton_Click_1(object sender, EventArgs e)
        {
            StudentsInfoForm form = new StudentsInfoForm();
            form.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void TrainPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void JunglePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void CoursesPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            TrainForm trainForm = new TrainForm();
            trainForm.Show();
        }

        private void DormitoryButton_Click(object sender, EventArgs e)
        {
            DormitoryInfoForm dormitoryInfoForm = new DormitoryInfoForm();
            dormitoryInfoForm.Show();
            
        }
    }
}
