using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMAPstuff
{
    public partial class Form1 : Form
    {
        // Clone a portion of the Bitmap object and place in miniDisplay
        Bitmap mainBitMap = new Bitmap(Properties.Resources.HerefordMap);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // we now load hereford map into mainDisplay
            // I have adjusted image to be same size as PictureBox within Microsoft Paint
            mainDisplay.Image = Properties.Resources.HerefordMap;

            // Clone a portion of the Bitmap object and place in miniDisplay
            Rectangle cloneRect = new Rectangle(0, 0, 107, 90);
            System.Drawing.Imaging.PixelFormat format =
                mainBitMap.PixelFormat;
            Bitmap cloneBitmap = mainBitMap.Clone(cloneRect, format);

            miniDisplay.Image = cloneBitmap;

            // setup the mouse click operation
            mainDisplay.MouseClick += new MouseEventHandler(onMouseClick);
        }

        private void onMouseClick(object sender, MouseEventArgs e)
        {
            Point clickPoint = mainDisplay.PointToClient(Cursor.Position);
            Color pixelColor = mainBitMap.GetPixel(clickPoint.X, clickPoint.Y);
            colourBox.Text = pixelColor.ToString();
        }
    }
}
