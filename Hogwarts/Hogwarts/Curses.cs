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
    public partial class Curses : Form
    {
        public Curses()
        {
            InitializeComponent();
        }

        private void Curses_Load(object sender, EventArgs e)
        {

        }

        private void FinishHourtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            string cname=CoursecomboBox.Text;
            string day=DaycomboBox.Text;
            string time=TimecomboBox.Text;
            int term = int.Parse(TermcomboBox.Text);
            int capacity=int.Parse(CapacitycomboBox.Text);
            string teacherfirstname=FirsttextBox.Text;
            string teacherlastname=LastName.Text;

                
        }

        private void TermcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
    }
}
