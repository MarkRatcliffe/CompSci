using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Bring in the Windows Form library
using System.Windows.Forms;

namespace SchoolRecords
{
    class SubjectPanel : Panel
    {
        private int maximumSubjects;
        private Subjects fullListOfSubjects;
        private Label[] subjectLabel;
        private ComboBox[] subjectEntry;


        // Constructor to create a subject entry/display panel
        // theMaxSubs defines the number to be displayed.
        public SubjectPanel(Subjects theSubjects,  int theMaxSubs)
        {
            fullListOfSubjects = theSubjects;
            maximumSubjects = theMaxSubs;
            subjectLabel = new Label[maximumSubjects]; 
            subjectEntry = new ComboBox[maximumSubjects];

            // First define the properties of the Panel
            this.Size = new Size(300, 120);

            MessageBox.Show("Creating the subjects");

            for (int i = 0; i < maximumSubjects; i++)
            {
                subjectLabel[i] = new Label();
                subjectLabel[i].Text = "Subject " + i;
                subjectLabel[i].Size = new Size(90, 20);
                subjectLabel[i].Location = new Point(15, 25 + (i * 25));
                this.Controls.Add(subjectLabel[i]);
                subjectLabel[i].Show();

                subjectEntry[i] = new ComboBox();
                subjectEntry[i].Size = new Size(115, 20);
                subjectEntry[i].Location = new Point(140, 25 + (i * 25));
                this.Controls.Add(subjectEntry[i]);
                subjectEntry[i].Show();

                // Now populate the pull down with all subjects
                SetSubjectPullDown(i);
            }

        }

        // SetSubjectPullDown sets the main pull down lists for set of subjects
        // only needs to be updated if lists change
        // fullSet should be the full set of subjects on offer
        private void SetSubjectPullDown(int comboToUpdate)
        {
            for (int i = 0; i < fullListOfSubjects.GetCurrentSize(); i++)
            {
                subjectEntry[comboToUpdate].Items.Add(fullListOfSubjects.GetSubject(i));
                subjectEntry[comboToUpdate].Text = "Select from list";
            }

        }

        // SetIndSubjects is called to update choice for a single student
        // chosenSet should be set of subjects taken by an individual student
        public void SetIndSubjects(Subjects chosenSet)
        {
            // set the choices that have been set for a single student
            for (int i = 0; i < chosenSet.GetCurrentSize(); i++)
            {
                subjectEntry[i].Text = chosenSet.GetSubject(i).ToString();
            }
        }
        // clearIndSubjects is called to clear choice for a single student
        public void ClearIndSubjects()
        {
            //set the choices that have been set for a single student
            for (int i = 0; i < maximumSubjects; i++)
            {
                subjectEntry[i].Text = "Please choose";
            }
        }


        // getIndSubjects is called to get a set of subjects for an individual student
        // chosenSet should be set of subjects taken by an individual student
        public Subjects GetIndSubjects()
        {
            Subjects tempSubjects = new Subjects(School.MaxSubjectsPerPupil);
            Subject tempSubject;
            // set the choices that have been set for a single student
            for (int i = 0; i < maximumSubjects; i++)
            {
                tempSubject = (Subject)subjectEntry[i].SelectedItem;
                //Only add to collection if not null
                if (tempSubject != null)
                {
                    tempSubjects.AddSubject((Subject)subjectEntry[i].SelectedItem);
                }
            }
            return tempSubjects;
        }
    }
}
