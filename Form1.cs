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

namespace Makgopa_Leonard_PRG262_ST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // TextBox1 to TextBox6

        private void PatientID_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(PatientID.Text, out int PatID))
            {
                Console.WriteLine($"Enter Patient ID: {PatID}");
            }
            else
            {
                Console.WriteLine("Invalid Patient ID");
            }
        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Diagnosis_TextChanged(object sender, EventArgs e)
        {

        }

        private void DoctorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void NotesOrDate_TextChanged(object sender, EventArgs e)
        {

        }

        // label1 to label8

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        // button1 to button5

        // Add New Patient
        private void Add_Click(object sender, EventArgs e)
        {
            string filePath = "PatientDetails.txt";

            string newRecord = $"{PatientID.Text},{FirstName.Text},{LastName.Text},{Diagnosis.Text},{DoctorName.Text},{NotesOrDate.Text}";

            File.AppendAllText(filePath, newRecord + Environment.NewLine);
            MessageBox.Show("Patient record added successfully!");
        }

        // Clear form
        private void Clear_Click(object sender, EventArgs e)
        {
            PatientID.Clear();
            FirstName.Clear();
            LastName.Clear();
            Diagnosis.Clear();
            DoctorName.Clear();
            NotesOrDate.Clear();
        }

        // Save to a file
        private void Save_Click(object sender, EventArgs e)
        {
            string filePath = "PatientDetails.txt";

            var record = $"{PatientID.Text},{FirstName.Text},{LastName.Text},{Diagnosis.Text},{DoctorName.Text},{NotesOrDate.Text}";

            File.WriteAllText(filePath, record + Environment.NewLine);
            MessageBox.Show("Data saved successfully.");
        }

        // Load from file
        private void Load_Click(object sender, EventArgs e)
        {
            string filePath = "PatientDetails.txt";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("File not found.");
                return;
            }

            var lines = File.ReadAllLines(filePath);

            StringBuilder builder = new StringBuilder();
            foreach (string line in lines)
            {
                builder.AppendLine(line);
            }

            MessageBox.Show(builder.ToString(), "All Patients");
        }

        // Search by Patient ID
        private void Search_Click(object sender, EventArgs e)
        {

            string searchID = PatientID.Text.Trim();
            string filePath = "PatientDetails.txt";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("File not found.");
                return;
            }

            var lines = File.ReadAllLines(filePath);
            bool found = false;

            foreach (var line in lines)
            {
                var data = line.Split(',');

                if (data[0] == searchID)
                {
                    FirstName.Text = data[1];
                    LastName.Text = data[2];
                    Diagnosis.Text = data[3];
                    DoctorName.Text = data[4];
                    NotesOrDate.Text = data[5];
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("Patient ID not found.");
            }

        }
    }

}