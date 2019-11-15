using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hashing
{
    public partial class Form1 : Form
    {
        public const int theTableSize = 17;
        private HashTable theTable = new HashTable(theTableSize);

        public Form1()
        {
            InitializeComponent();
            theTable = new HashTable(theTableSize);
        }

        public void updateTableDisplay()
        {
            tableBox.Text = theTable.ToString();
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            HashableString theKey = new HashableString(keyEntryBox.Text);
            theTable.addToTable(theKey, dataEntryBox.Text);
            updateTableDisplay();
            keyEntryBox.Text = "";
            dataEntryBox.Text = "";

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            HashableString theKey = new HashableString(keyEntryBox.Text);
            theTable.removeFromTable(theKey);
            updateTableDisplay();
            keyEntryBox.Text = "";
            dataEntryBox.Text = "";
        }
    }
}
