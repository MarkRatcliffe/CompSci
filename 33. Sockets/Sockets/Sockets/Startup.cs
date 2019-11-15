using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sockets
{
    public partial class Startup : Form
    {
        private ChatForm theForm;
        public Startup()
        {
            InitializeComponent();
            MessageBox.Show("Starting Project");
        }

        private void masterButton_Click(object sender, EventArgs e)
        {
            theForm = new ChatForm(true);
            theForm.Show();
            this.Hide();
        }

        private void slaveButton_Click(object sender, EventArgs e)
        {
            theForm = new ChatForm(false);
            theForm.Show();
            this.Hide();
        }
    }
}
