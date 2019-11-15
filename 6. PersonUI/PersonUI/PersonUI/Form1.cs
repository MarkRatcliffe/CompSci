using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonUI
{
    public partial class Form1 : Form
    {
        public Person p1; // defines my person
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // called when the form loads
            p1 = new Person();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            p1.setName(nameBox.Text);
            p1.setAge(Convert.ToInt32(ageBox.Text));
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameBox.Text = "";
            ageBox.Text = "";
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            nameBox.Text = p1.getName();
            ageBox.Text = Convert.ToString(p1.getAge());
        }
    }
}
