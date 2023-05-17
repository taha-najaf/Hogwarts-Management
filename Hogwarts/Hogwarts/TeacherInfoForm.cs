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
    }
}
