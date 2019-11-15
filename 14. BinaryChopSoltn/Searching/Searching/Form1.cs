using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Searching
{
    public partial class Form1 : Form
    {
        private Searching mySearching = new Searching();

        private String[] theListToSearch;
        private int numOfItems = 7;

        public Form1()
        {
            InitializeComponent();
            theListToSearch = new String[numOfItems];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            resultsLabel1.Text = " ";
            resultsLabel2.Text = " ";
            int result = mySearching.serialSearch(theListToSearch, searchText.Text);
            if (result == -1)
            {
                resultsLabel1.Text = "String not found";
            }
            else
            {
                resultsLabel1.Text = "String found at: ";
                resultsLabel2.Text = result.ToString();
            }

        }

        private void stringList_TextChanged(object sender, EventArgs e)
        {
            for (int lineNum = 0; lineNum < stringList.Lines.Length; lineNum++)
            {
                // transfer each line into my array for searching
                theListToSearch[lineNum] = stringList.Lines[lineNum];
            }
        }


    }
}
