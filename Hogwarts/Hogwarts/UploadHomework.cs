using Newtonsoft.Json;
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
using Newtonsoft.Json;

namespace Hogwarts
{
    public partial class UploadHomework : Form
    {
        private List<Assignment> assignments;
        public UploadHomework()
        {
            InitializeComponent();
            assignments = new List<Assignment>();
        }

        private void UploadHomework_Load(object sender, EventArgs e)
        {
            LoadAssignments();
        }
        private void LoadAssignments()
        {
            string filePath = @"D:\programming\Projects\Hogwarts\Hogwarts\Hogwarts\Assignmentjson.json";

            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);

                // Deserialize the JSON data into a list of Assignment objects
                List<Assignment> assignmentList = JsonConvert.DeserializeObject<List<Assignment>>(jsonData);

                // Populate the combo box with assignments
                cmbAssignments.DataSource = assignmentList;
                cmbAssignments.DisplayMember = "Title";
                cmbAssignments.ValueMember = "Title"; // 
            }
            else
            {
                MessageBox.Show("Assignment data file not found.");
            }
        }

        private void cmbAssignments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Assignment selectedAssignment = cmbAssignments.SelectedItem as Assignment;
            if (selectedAssignment == null)
            {
                MessageBox.Show("Please select an assignment.");
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (selectedAssignment.Deadline > DateTime.Now)
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;



                    MessageBox.Show("Homework uploaded successfully!", "successful",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Deadline passed,it is not possible to upload homework","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentPanel studentPanel = new StudentPanel();
            studentPanel.Show();
        }
    }
}
