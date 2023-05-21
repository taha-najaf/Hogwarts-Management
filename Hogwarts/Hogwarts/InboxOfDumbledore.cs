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
    public partial class InboxOfDumbledore : Form
    {
        public InboxOfDumbledore()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Letters");
            foreach(var letter in Dumbledore.letterFromStudents)
            {
                table.Rows.Add(letter);
            }
            dataGridView1.DataSource = table;
        }

        private void LoginoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            DumbledoreForm form = new DumbledoreForm();
            form.ShowDialog();
        }
    }
}
