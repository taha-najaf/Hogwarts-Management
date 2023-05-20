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
    public partial class FrmSendLetterToDumbledore : Form
    {
        public FrmSendLetterToDumbledore()
        {
            InitializeComponent();
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentPanel panel = new StudentPanel();
            panel.ShowDialog();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            LoginForm.student.SendLetterToDumbledor(LoginForm.student.FirstName, LoginForm.student.LastName);
            MessageBox.Show("Letter Sent to Dumbledore");
        }
    }
}
