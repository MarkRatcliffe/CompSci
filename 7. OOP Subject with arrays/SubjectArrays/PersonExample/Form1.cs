using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonExample
{
    public partial class Form1 : Form
    {
        private Subject s1; // we create it later, when we have the details
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            maxNumOfStudentsBox.Text = Convert.ToString(50);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Person p1 = new PersonExample.Person(studentNameBox.Text, Convert.ToInt32(studentAgeBox.Text));
            if (s1.addAStudent(p1) == true)
            {
                // now display the current num of students
                currentNumOfStudentsBox.Text = Convert.ToString(s1.getCurrentNumOfStudents());
                studentNameBox.Text = "";
                studentAgeBox.Text = "";
            }

        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(s1.ToString());
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            // Now we have what we need, we can create the subject
            s1 = new Subject(nameBox.Text, 
                             new Person(teacherNameBox.Text, 99), 
                             Convert.ToInt32(maxNumOfStudentsBox.Text));

            // turn on student panel
            studentPanel.Visible = true;
        }
    }
}
