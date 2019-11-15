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

namespace WordCounting
{
    public partial class Form1 : Form
    {
        private WordCounter wordCount = new WordCounter(100);
        public Form1()
        {
            InitializeComponent();
        }

        private void loadButton_Click_1(object sender, EventArgs e)
        {
            //open file
            try
            {
                StreamReader theInputStream = new StreamReader(fileNameTextBox.Text);
                String theLines = "";
                while (!theInputStream.EndOfStream)
                {
                    theLines = theLines + theInputStream.ReadLine() + Environment.NewLine;
                }
                fileTextBox.Text = theLines;
            }
            catch (Exception error)
            {
                MessageBox.Show("Incorrect filename - try again");
            }
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            if (wordCount.loadWordsFromFile(fileNameTextBox.Text) != 0)
            {
                MessageBox.Show("Could not find file");
            }
            outputTextBox.Text = wordCount.ToString();
        }
    }
}
