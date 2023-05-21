using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace Hogwarts
{
    public partial class DefineHomeworkForm : Form
    {
        public DefineHomeworkForm()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            ProfessorPanel panel = new ProfessorPanel();
            panel.Show();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string title = TextBox_Title.Text;
            string description = DescriptionTextBox.Text;
            DateTime deadline = DateTimePicker_DeadLine.Value;
            Assignment newAssignment = new Assignment(title, description, deadline);
            Assignment.AllAssignments.Add(newAssignment);
            MessageBox.Show("Assignment submitted successfully!");
            ClearAssignmentForm();

            string filepath = @"D:\programming\Projects\Hogwarts\Hogwarts\Hogwarts\Assignmentjson.json";
            List<Assignment> allAssignments = Assignment.AllAssignments.ToList();

            if (File.Exists(filepath))
            {
                string existingJsonData = File.ReadAllText(filepath);

                if (!string.IsNullOrEmpty(existingJsonData))
                {
                    List<Assignment> existingAssignments = JsonConvert.DeserializeObject<List<Assignment>>(existingJsonData);

                    if (existingAssignments != null)
                    {
                        existingAssignments.AddRange(allAssignments);
                        string updatedJsonData = JsonConvert.SerializeObject(existingAssignments, Formatting.Indented);
                        File.WriteAllText(filepath, updatedJsonData);
                    }
                    else
                    {
                        // Existing JSON data is not in the expected format or empty
                        // Handle the error or log a message as per your requirements
                        MessageBox.Show("Error: Existing JSON data is null or invalid.");
                    }
                }
                else
                {
                    // Existing JSON data is empty
                    // Create a new list with the current assignments
                    string jsondata = JsonConvert.SerializeObject(allAssignments, Formatting.Indented);
                    File.WriteAllText(filepath, jsondata);
                }
            }
            else
            {
                // File doesn't exist, create a new file with the current assignments
                string jsondata = JsonConvert.SerializeObject(allAssignments, Formatting.Indented);
                File.WriteAllText(filepath, jsondata);
            }



        }
        private void ClearAssignmentForm()
        {
            TextBox_Title.Clear();
            DescriptionTextBox.Clear();
           DateTimePicker_DeadLine.Value = DateTime.Now;
        }
    }
}
