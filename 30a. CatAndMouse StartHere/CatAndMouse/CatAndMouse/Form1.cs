using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatAndMouse
{
    public partial class Form1 : Form
    {
        public Mouse myMouse;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create a mouse, passing in the form as required
            myMouse = new CatAndMouse.Mouse(this);
        }
    }
}
