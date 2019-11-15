using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryptian
{
    public partial class Form1 : Form
    {
        public Encryptor myEncryptor = new Encryptor();

        public Form1()
        {
            InitializeComponent();
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            outputText.Text = myEncryptor.encrypt(inputText.Text, Convert.ToInt32(shiftText.Text));
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            outputText.Text = myEncryptor.decrypt(inputText.Text, Convert.ToInt32(shiftText.Text));
        }
    }
}
