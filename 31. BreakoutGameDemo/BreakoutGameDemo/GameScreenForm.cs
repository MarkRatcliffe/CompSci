using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakoutGameDemo
{
    public partial class GameScreenForm : Form
    {
        private MoveableGameObject ball;
        private MoveableGameObject paddle;
        private GameObject[,] arrBricks;
        public GameScreenForm()
        {
            InitializeComponent();
            InitialiseGameScreenForm();
        }

        private void InitialiseGameScreenForm()
        {
            tmrGame.Tick += new EventHandler(onTick);
            this.KeyDown += new KeyEventHandler(onKeyDown);
            this.MouseMove += new MouseEventHandler(onMouseMove);
            this.MouseClick += new MouseEventHandler(onMouseClick);
            this.Paint += new PaintEventHandler(onPaint);

            DoubleBuffered = true;
            KeyPreview = true;

            this.MinimizeBox = false;
            this.MaximizeBox = false;

            this.BackColor = Color.SkyBlue;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Size = new Size(640, 482);
            this.Text = "Breakout Game";

            int intBrickRows = 5;
            int intBrickColumns = 5;
            int intBrickWidth = 80;
            int intBrickHeight = 20;
            int paddleWidth = 80;
            int paddleHeight = 15;
            int paddleX = 300;
            int paddleY = 434;
            int ballWidth = 20;
            int ballHeight = 20;
            int ballX = paddleX + paddleHeight / 2 - (ballHeight / 2);
            int ballY = paddleY - ballWidth;

            float defaultSpeed = 20;
            float defaultXVel = (float)Math.Cos(defaultSpeed) * defaultSpeed;
            float defaultYVel = (float)Math.Cos(defaultSpeed) * defaultSpeed;

            paddle = new MoveableGameObject(paddleX, paddleY,     
                                            paddleWidth, paddleHeight, 
                                            true, 
                                            defaultSpeed, 
                                            0, 0, 
                                            false, 
                                            Brushes.Pink);

            ball = new MoveableGameObject(ballX, ballY, 
                                          ballWidth, ballHeight, 
                                          true, 
                                          defaultSpeed, 
                                          defaultXVel, defaultYVel, 
                                          true, 
                                          Brushes.Yellow);

            arrBricks = new GameObject[intBrickRows, intBrickColumns];

            tmrGame.Interval = 20;
            tmrGame.Start();

            int intXOffset = (intBrickWidth / 2) + 1;
            int intYOffset = 100;

            for (int intRow = 0; intRow <= arrBricks.GetUpperBound(0); intRow++)
            {
                for (int intColumn = 0; intColumn <= arrBricks.GetUpperBound(1); intColumn++)
                {
                    arrBricks[intRow, intColumn] = new GameObject(intXOffset, intYOffset,          
                                                                  intBrickWidth, intBrickHeight, 
                                                                  true, 
                                                                  Brushes.Red);
                    intXOffset += intBrickWidth + 10;

                }
                intYOffset += intBrickHeight + 10;
                intXOffset = (intBrickWidth / 2) + 1;
            }
        }

        private void onKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }

            if (e.KeyCode == Keys.P)
            {
                if (tmrGame.Enabled)
                {
                    tmrGame.Stop();
                }
                else
                {
                    tmrGame.Start();
                }
            }
        }

        private void onMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ball.GetBlnIsGlued() == true)
                {
                    ball.UnGlue();
                }
            }
        }

        private void onMouseMove(object sender, MouseEventArgs e)
        {
            if (e.X > 0 && e.X < this.Width - 80)
            {
                paddle.ChangePosition(e.X);
            }
            if (ball.GetBlnIsGlued() == true)
            {
                ball.ChangePosition(paddle.GetRecPosition().X + 80 / 2 - (ball.GetRecPosition().Width / 2), 
                432 - 16);
            }
        }

        public int GetBrickCount()
        {
            int intCount = 0;
            foreach (GameObject brick in arrBricks)
            {
                if (brick.GetBlnIsVisible() == true)
                {
                    intCount += 1;
                }
            }
            return intCount;
        }

        // onPaint is called automatically (if form requires an update) but is forced by the Refresh call 
        // onPaint is responsible for all the drawing on the Graphics 
        private void onPaint(object sender, PaintEventArgs e)
        {
            for (int intRow = 0; intRow <= arrBricks.GetUpperBound(0); intRow++)
            {
                for (int intColumn = 0; intColumn <= arrBricks.GetUpperBound(1); intColumn++)
                {
                    if (arrBricks[intRow, intColumn].GetBlnIsVisible() == true)
                    {
                        e.Graphics.FillRectangle(arrBricks[intRow, intColumn].GetDrawingBrushColour(), arrBricks[intRow, intColumn].GetRecPosition());
                    }


                }

            }
            e.Graphics.FillRectangle(ball.GetDrawingBrushColour(), ball.GetRecPosition());
            e.Graphics.FillRectangle(paddle.GetDrawingBrushColour(), paddle.GetRecPosition());
        }

        private void onTick(object sender, EventArgs e)
        {
            if (!ball.GetBlnIsGlued())
            {
                ball.ChangePosition((int)(ball.GetRecPosition().X + ball.GetfltXVel()), 
                                    (int)(ball.GetRecPosition().Y + ball.GetfltYVel()));
            }

            if (ball.GetRecPosition().Y < 0)
            {
                ball.ChangePosition(ball.GetRecPosition().X, 0);
                ball.SetFltYVel(-ball.GetfltYVel());
            }

            if (ball.GetRecPosition().Y - ball.GetRecPosition().Height > this.Height)
            {
                ball.Glue();
                ball.ChangePosition(paddle.GetRecPosition().X + 72 / 2 - (ball.GetRecPosition().Width / 2), 
                                    432 - 16);

            }

            if (ball.GetRecPosition().X < 0)
            {
                ball.ChangePosition(0, ball.GetRecPosition().Y);
                ball.SetFltXVel(-ball.GetfltXVel());
            }

            if (ball.GetRecPosition().X + ball.GetRecPosition().Width > this.Width)
            {
                ball.ChangePosition(this.Width - ball.GetRecPosition().Width, ball.GetRecPosition().Y);
                ball.SetFltXVel(-ball.GetfltXVel());

            }

            if (ball.CheckForIntersect(paddle.GetRecPosition()))
            {
                ball.ChangePosition(ball.GetRecPosition().X, 
                                    ball.GetRecPosition().Y - ball.GetRecPosition().Height);
                ball.SetFltYVel(-ball.GetfltYVel());

            }

            for (int intRow = 0; intRow <= arrBricks.GetUpperBound(0); intRow++)
            {
                for (int intColumn = 0; intColumn <= arrBricks.GetUpperBound(1); intColumn++)
                {
                    if (arrBricks[intRow, intColumn].GetBlnIsVisible())
                    {

                        if (ball.CheckForIntersect(arrBricks[intRow, intColumn].GetRecPosition()))
                        {
                            arrBricks[intRow, intColumn].MakeInvisible();
                            if (ball.GetRecPosition().X + 10 < arrBricks[intRow, intColumn].GetRecPosition().X || 
                                ball.GetRecPosition().X > arrBricks[intRow, intColumn].GetRecPosition().X 
                                + arrBricks[intRow, intColumn].GetRecPosition().Width)
                            {
                                ball.SetFltXVel(-ball.GetfltXVel());
                            }
                            else
                            {
                                ball.SetFltYVel(-ball.GetfltYVel());
                            }

                        }
                    }

                }
            }

            if (GetBrickCount() == 0)
            {
                tmrGame.Stop();
                Cursor.Show();
                if (MessageBox.Show("Would you like to play again?", "Play Again?", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    InitialiseGameScreenForm();
                }
                else
                {
                    Application.Exit();
                }
            }

            this.Refresh();

        }

    }
}
