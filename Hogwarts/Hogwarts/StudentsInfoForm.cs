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
    public partial class StudentsInfoForm : Form
    {
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

        }

        private void LoginoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            DumbledoreForm form = new DumbledoreForm();
            form.ShowDialog();

        }

        private void StudentsInfoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
