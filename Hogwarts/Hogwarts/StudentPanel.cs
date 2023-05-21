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
    public partial class StudentPanel : Form
    {
        public StudentPanel()
        {
            InitializeComponent();
        }

        private void StudentPanel_Load(object sender, EventArgs e)
        {
            try
            {
                FirstNamelabel.Text = "First Name : " + LoginForm.student.FirstName;
                LastNmaelabel.Text = "Last Name : " + LoginForm.student.LastName;
                Grouptypelabel.Text = "Group Type : " + LoginForm.student.GroupName;
                Petlabel.Text = "Pet : " + LoginForm.student.Pet;
                Termlabel.Text = "Term : " + LoginForm.student.Term;
                Dormitorylabel.Text = "Dormitory Code : " + LoginForm.student.DormitoryNumber;
                PassedUnits.Text = "Passed Units : " + LoginForm.student.PassedUnits;
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void SendLetterButton_Click(object sender, EventArgs e)
        {

        }

        private void SellectUnitButton_Click(object sender, EventArgs e)
        {
            SellectUnitForm sellectUnitForm = new SellectUnitForm();
            sellectUnitForm.ShowDialog();
            this.Close();
        }
    }
}
