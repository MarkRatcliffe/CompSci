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
    public partial class StudentForm : Form
    {
        // Subject Panel is used to display all subjects for a particular student
        private SubjectPanel subjectDisplay;

        // iterPosition is used to navigate up and down the array with next, prev
        private int iterPosition = 0;


        // we need to maintain a link to the school system so we can access data
        // This is set by the constructor
        private School theSchool;

        public StudentForm(School schoolPassedIn)
        {
            InitializeComponent();
            theSchool = schoolPassedIn;
            subjectDisplay = new SubjectPanel(theSchool.GetSubjects(), theSchool.GetSubjects().GetCurrentSize());
            // add the subjectPanel
            this.Controls.Add(subjectDisplay);
            subjectDisplay.Location = new Point(12, 450);
            subjectDisplay.Show();
        }

        private void DisplayStudentDetail(Student theStudent)
        {
            subjectDisplay.ClearIndSubjects();
            ClearStudentDetail();
            firstNameTextBox.Text = theStudent.GetFirstName();
            lastNameTextBox.Text = theStudent.GetLastName();
            ageTextBox.Text = theStudent.GetAge().ToString();
            houseTextBox.Text = theStudent.GetAddress().GetHouseNameOrNumber();
            streetTextBox.Text = theStudent.GetAddress().GetStreet();
            countyTextBox.Text = theStudent.GetAddress().GetCounty();
            postCodeTextBox.Text = theStudent.GetAddress().GetPostCode();

            //now update the subjectPanel to show student's subjects
            subjectDisplay.SetIndSubjects(theStudent.GetSubjects());
        }

        private void ClearStudentDetail()
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            ageTextBox.Text = "";
            houseTextBox.Text = "";
            streetTextBox.Text = "";
            countyTextBox.Text = "";
            postCodeTextBox.Text = "";
            subjectDisplay.ClearIndSubjects();
        }

        // getStudentDetails creates and return a Student based on all the text areas (Address cannot be set here)
        private Student GetStudentDetails()
        {
            Student temp = new Student(firstNameTextBox.Text,
                                       lastNameTextBox.Text,
                                       Convert.ToInt32(ageTextBox.Text),
                                       new Address(houseTextBox.Text,
                                                   streetTextBox.Text,
                                                   countyTextBox.Text,
                                                   postCodeTextBox.Text));
            temp.SetSubjects(subjectDisplay.GetIndSubjects());
            return temp;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Student tempStudent;
            // cannot display if the list is empty, so just leave
            if (theSchool.GetStudents().GetCurrentSize() == 0)
                return;

            if (iterPosition < theSchool.GetStudents().GetCurrentSize() - 1)
            {
                iterPosition = iterPosition + 1;
                infoLabel.Text = "info: at position" + iterPosition;
            }
            else
            {
                infoLabel.Text = "info: already at end";
            }
            // get the student indexed by iterPos
            tempStudent = theSchool.GetStudents().GetStudent(iterPosition);

            // display subject details
            DisplayStudentDetail(tempStudent);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Student tempStudent = GetStudentDetails();

            // Check that studnet doesn't already exist in the collection
            if (theSchool.GetStudents().GetStudent(firstNameTextBox.Text, lastNameTextBox.Text) != null)
            {
                // inform user that duplicate students are not allowed
                MessageBox.Show("Student is already in the list - names must be unique");
            }
            else
            {
                // add the Student to the Students List
                if (theSchool.GetStudents().AddStudent(tempStudent) == -1)
                {
                    MessageBox.Show("Sorry - the school is too full");
                }
                else
                {
                    // reset iter position to last entry
                    iterPosition = theSchool.GetStudents().GetCurrentSize() - 1;
                    infoLabel.Text = "info: student added";
                }
            }
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            Student tempStudent;

            // cannot display if the list is empty, so just leave
            if (theSchool.GetStudents().GetCurrentSize() == 0)
                return;

            if (iterPosition > 0)
            {
                iterPosition = iterPosition - 1;
                infoLabel.Text = "info: at position" + iterPosition;
            }
            else
            {
                infoLabel.Text = "info: already at start";
            }
            // get the student indexed by iterPos
            tempStudent = theSchool.GetStudents().GetStudent(iterPosition);

            // display subject details
            DisplayStudentDetail(tempStudent);

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearStudentDetail();
            infoLabel.Text = "info: ";
        }

    }
}
