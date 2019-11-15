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
        public Cat myCat;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create a cat, passing in the form as required
            myCat = new CatAndMouse.Cat(this);

            // Create a mouse, passing in the form as required, and the Cat as the enemy
            myMouse = new CatAndMouse.Mouse(this, myCat);

        }
    }
}
