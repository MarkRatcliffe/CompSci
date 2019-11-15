using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;                // You need this for file handling
using FileExample.Properties;   // You need this to access your Resources
namespace FileExample
{
    public partial class FileHandler : Form
    {
        private String[] theDictionary = new String[100];
        private int nextFreeLocation = 0;

        public FileHandler()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            string fileContent = Resources.hangman;
            String line;
            StringReader reader = new StringReader(fileContent);

            // read in the strings and store in my dictionary array
            while ((line = reader.ReadLine()) != null)
                {

                     theDictionary[nextFreeLocation] = line;
                     nextFreeLocation++;
                }

            // just for this example, I want to build a large string with linebreaks for the textbox
            String textBoxString = "";
            for (int i=0; i < nextFreeLocation; i++)
            {
                textBoxString = textBoxString + theDictionary[i] + Environment.NewLine;
            }
            // now display in my textbox
            namesTextBox.Text = textBoxString;
        }
    }
}
