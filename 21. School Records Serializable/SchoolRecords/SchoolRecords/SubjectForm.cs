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
    public partial class SubjectForm : Form
    {
        private School theSchool;
        public SubjectForm(School theSchoolRecords)
        {
            theSchool = theSchoolRecords;
            InitializeComponent();
        }

        // iterPosition is used to navigate up and down the array with next, prev
        private int iterPosition = 0;

        private void DisplaySubjectDetail(Subject theSubject)
        {
            subjectTextBox.Text = theSubject.GetName();
            levelTextBox.Text = theSubject.GetLevel();

        }

        private void ClearSubjectDetail()
        {
            subjectTextBox.Text = "";
            levelTextBox.Text = "";
        }

        // getSubjectDetails creates and returns a Subject based on all the text areas (Address cannot be set here)
        private Subject GetSubjectDetails()
        {
            return new Subject(subjectTextBox.Text,
                               levelTextBox.Text);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Subject tempSubject;

            // cannot display if the list is empty, so just leave
            if (theSchool.GetSubjects().GetCurrentSize() == 0)
                return;

            if (iterPosition < theSchool.GetSubjects().GetCurrentSize() - 1)
            {
                iterPosition = iterPosition + 1;
                infoLabel.Text = "info: at position" + iterPosition;
            }
            else
            {
                infoLabel.Text = "info: already at end";
            }
 

            // get the student indexed by iterPos
            tempSubject = theSchool.GetSubjects().GetSubject(iterPosition);

            // display subject details
            DisplaySubjectDetail(tempSubject);

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Subject tempSubject = GetSubjectDetails();

            // Check that subject doesn't already exist in the collection
            if (theSchool.GetSubjects().GetSubject(subjectTextBox.Text, levelTextBox.Text) != null)
            {
                // inform user that duplicate subjects are not allowed
                MessageBox.Show("Student is already in the list - ket must be unique");
            }
            else
            {
                // add the Subject to the  Subject List
                if (theSchool.GetSubjects().AddSubject(tempSubject) == -1)
                {
                    MessageBox.Show("Sorry - the school is too full");
                }
                else
                {
                    // reset iter position to last entry
                    iterPosition = theSchool.GetSubjects().GetCurrentSize() -1;
                    infoLabel.Text = "info: subject added";
                }
            }
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            Subject tempSubject;

            // cannot display if the list is empty, so just leave
            if (theSchool.GetSubjects().GetCurrentSize() == 0)
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
            tempSubject = theSchool.GetSubjects().GetSubject(iterPosition);

            // display subject details
            DisplaySubjectDetail(tempSubject);


        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearSubjectDetail();
            infoLabel.Text = "info: ";
        }

        private void SubjectForm_Load(object sender, EventArgs e)
        {
            Subject tempSubject;
            iterPosition = 0;
            // On loading the form, load up any existing subjects
            if (theSchool.GetSubjects().GetCurrentSize() > 0)
            {
                // get the student indexed by iterPos
                tempSubject = theSchool.GetSubjects().GetSubject(0);

                // display subject details
                DisplaySubjectDetail(tempSubject);
                infoLabel.Text = "info: loaded from file";
            }
            else
            {
                infoLabel.Text = "info: no subjects loaded from file";
            }


        }
    }
}
