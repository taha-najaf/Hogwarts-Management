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
            string description=DescriptionTextBox.Text;
            DateTime deadline = DateTimePicker_DeadLine.Value;
            Assignment newAssignment = new Assignment(title, description, deadline);
            Assignment.AllAssignments.Add(newAssignment);
            MessageBox.Show("Assignment submitted successfully!");
            ClearAssignmentForm();
            string filepath = @"D:\programming\Projects\Hogwarts\Hogwarts\Hogwarts\Assignmentjson.json";
            string jsondata = JsonConvert.SerializeObject(newAssignment, Formatting.Indented);
            File.WriteAllText(filepath, jsondata);


        }
        private void ClearAssignmentForm()
        {
            TextBox_Title.Clear();
            DescriptionTextBox.Clear();
           DateTimePicker_DeadLine.Value = DateTime.Now;
        }
    }
}
