using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolRecords
{
    public partial class MasterForm : Form
    {
        // create a temporrary school but will then attempt to load from file 
        private School mySchool = new School();

        public MasterForm()
        {
            InitializeComponent();
        }

        private Button teachersButton;
        private Button studentsButton;
        private Button subjectsButton;

        private void MasterForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(300, 250);

            // we start by trying to read in school data created previously

            if (mySchool.LoadFromFile("SchoolDataFile.txt") == 0)
            {
                MessageBox.Show("Reading from file: Success");
            }
            else
            {
                mySchool = new School(20, 20, 200);
                MessageBox.Show("Could not find data. New school created.");
            }

            teachersButton = new Button();
            teachersButton.Text = "Teachers";
            teachersButton.Size = new Size(90, 30);
            teachersButton.Location = new Point(90, 40);
            // we have to register the button to receive events
            this.Controls.Add(teachersButton);


            // Now link in the code for when this button is pressed
            teachersButton.Click += TeachersButton_Click;

            teachersButton.Show();

            studentsButton = new Button();
            studentsButton.Text = "Students";
            studentsButton.Size = new Size(90, 30);
            studentsButton.Location = new Point(90, 80);
            this.Controls.Add(studentsButton);
            // Now link in the code for when this button is pressed
            studentsButton.Click += StudentsButton_Click;
            studentsButton.Show();

            subjectsButton = new Button();
            subjectsButton.Text = "Subjects";
            subjectsButton.Size = new Size(90, 30);
            subjectsButton.Location = new Point(90, 120);
            this.Controls.Add(subjectsButton);
            subjectsButton.Click += SubjectsButton_Click;
            subjectsButton.Show();

            FormClosing += MasterForm_Closing;

            MessageBox.Show("Ready to load");

        }

        private void TeachersButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teachers Button clicked");
        }

        private void StudentsButton_Click(object sender, EventArgs e)
        {
            StudentForm theStudentForm = new SchoolRecords.StudentForm(mySchool);
            theStudentForm.Show();
        }

        private void SubjectsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Subjects Button clicked");
            SubjectForm theSubjectForm = new SchoolRecords.SubjectForm(mySchool);
            theSubjectForm.Show();
        }

        private void MasterForm_Closing(object sender, FormClosingEventArgs e)
        {
            // find out whether to save objects to file
            DialogResult result = 
                MessageBox.Show("Shall I save to file", 
                                "Confirmation", 
                                MessageBoxButtons.OKCancel, 
                                MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                if (mySchool.WriteToFile("SchoolDataFile.txt") == 0)
                    MessageBox.Show("Writing to file: Success");
                else
                    MessageBox.Show("Writing to file: Failure - Could not save");
            }
            else
            {
                MessageBox.Show("File saving abandoned");
            }

        }

    }
}

