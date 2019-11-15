using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueExample
{
    public partial class Form1 : Form
    {

        const int sizeOfDisplayBox = 12;
        Queue myQueue = new Queue(12);

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            myQueue.Add(addTextBox.Text);
            lengthLabel.Text = "Length = " + myQueue.Length();
            addTextBox.Text = "";
            queueDisplay.Text = myQueue.ToString();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            removeTextBox.Text = (String) myQueue.Remove();
            lengthLabel.Text = "Length = " + myQueue.Length();
            queueDisplay.Text = myQueue.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
