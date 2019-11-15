using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackUI
{
    public partial class Form1 : Form
    {
        const int sizeOfDisplayBox = 12;
        Stack myStack = new Stack(12);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // We want the stack to look as though it's growing from the bottom
        private void fillTextBox()
        {
            String displayString = "";
            int numOfBlanksLinesRequired = sizeOfDisplayBox - myStack.Depth();
            for (int i=0; i < numOfBlanksLinesRequired; i++)
            {
                displayString = displayString + Environment.NewLine;
            }
            // now add in my Stack
            displayString = displayString + myStack.ToString();
            stackDisplay.Text = displayString;    
        }

        private void pushButton_Click(object sender, EventArgs e)
        {
            myStack.Push(dataEntry.Text);
            fillTextBox();
            topLabel.Text = "Top = " + myStack.Depth();
        }

        private void popButton_Click(object sender, EventArgs e)
        {
            Object temp = myStack.Pop();  // in this example we dont use returned value

            // Now display Stack
            fillTextBox();

            topLabel.Text = "Top = " + myStack.Depth();


        }

    }
}
