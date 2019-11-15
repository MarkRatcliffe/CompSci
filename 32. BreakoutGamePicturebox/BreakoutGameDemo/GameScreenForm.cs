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
        private GameObject[,] bricks;
        private Timer timer = new Timer();

        public GameScreenForm()
        {
            InitializeComponent();
            InitialiseGameScreenForm();
        }

        private void InitialiseGameScreenForm()
        {  
            timer.Tick += new EventHandler(onTick);
            this.KeyDown += new KeyEventHandler(onKeyDown);
            this.MouseMove += new MouseEventHandler(onMouseMove);
            this.MouseClick += new MouseEventHandler(onMouseClick);

            this.MinimizeBox = false;
            this.MaximizeBox = false;

            this.BackColor = Color.SkyBlue;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Size = new Size(640, 482);
            this.Text = "Breakout Game";

            int brickRows = 5;
            int brickCols = 5;
            int brickWidth = 80;
            int brickHeight = 20;
            int paddleWidth = 80;
            int paddleHeight = 15;
            int paddleX = 300;
            int paddleY = 434;
            int ballWidth = 20;
            int ballHeight = 20;
            int ballX = paddleX + paddleHeight / 2 - (ballHeight / 2);
            int ballY = paddleY - ballWidth;

            float defaultSpeed = 20;
            float defaultXVel = (float)Math.Cos(45) * defaultSpeed;
            float defaultYVel = (float)Math.Sin(45) * defaultSpeed;

            paddle = new MoveableGameObject(this,                        // the current form
                                            paddleX, paddleY,
                                            paddleWidth, paddleHeight,
                                            true,                        // visibility
                                            defaultSpeed,
                                            0, 0,                        // initial velocities
                                            false,                       // glued or not
                                            System.Drawing.Color.Pink);

            ball = new MoveableGameObject(this,
                                          ballX, ballY,
                                          ballWidth, ballHeight,
                                          true,
                                          defaultSpeed,
                                          defaultXVel, defaultYVel,
                                          true,
                                          System.Drawing.Color.Yellow);

            bricks = new GameObject[brickRows, brickCols];

            timer.Interval = 20;
            timer.Start();

            int xOffset = (brickWidth / 2) + 1;
            int yOffset = 100;

            for (int row = 0; row <= bricks.GetUpperBound(0); row++)
            {
                for (int column = 0; column <= bricks.GetUpperBound(1); column++)
                {
                    bricks[row, column] = new GameObject(this,
                                                         xOffset, yOffset,
                                                         brickWidth, brickHeight,
                                                         true,
                                                         System.Drawing.Color.Red);
                    xOffset += brickWidth + 10;
                }
                yOffset += brickHeight + 10;
                xOffset = (brickWidth / 2) + 1;
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
                if (timer.Enabled)
                {
                    timer.Stop();
                }
                else
                {
                    timer.Start();
                }
            }
        }

        // onMouseClick the ball is released (unglued) from the paddle and drops
        private void onMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ball.IsGlued())
                {
                    ball.UnGlue();
                }
            }
        }

        // onMouseMove the paddle is repositioned in the direction of the mouse.
        private void onMouseMove(object sender, MouseEventArgs e)
        {
            if (e.X > 0 && e.X < this.Width - 80)
            {
                paddle.ChangePosition(e.X);
            }
            if (ball.IsGlued())  // if ball is glued, it needs to stick with paddle
            {
                ball.ChangePosition(
                    paddle.GetPosition().X + 80 / 2 - (ball.GetPosition().Width / 2),
                    432 - 40);
            }
        }

        // GetBrickCount returns the number of bricks still available (visible) 
        public int GetBrickCount()
        {
            int brickCount = 0;
            foreach (GameObject brick in bricks)
            {
                if (brick.IsVisible())
                {
                    brickCount += 1;
                }
            }
            return brickCount;
        }

        private void onTick(object sender, EventArgs e)
        {
            // if ball is glued, then it follows movement of paddle
            if (!ball.IsGlued())   
            {
                ball.ChangePosition((int)(ball.GetPosition().X + ball.GetXVelocity()),
                                    (int)(ball.GetPosition().Y + ball.GetYVelocity()));
            }

            // if ball falls off bottom, glue it back above paddle
            if (ball.GetPosition().Y - ball.GetPosition().Height > this.Height)
            {
                ball.Glue();

                ball.ChangePosition(paddle.GetPosition().X + 72 / 2 - (ball.GetPosition().Width / 2),
                                    432 - 16);
            }

            // if Y < 0, then ball's gone off top of screen so it comes back down
            if (ball.GetPosition().Y < 0) 
            {
                ball.ChangePosition(ball.GetPosition().X, 0);
                ball.SetYVelocity(-ball.GetYVelocity());
            }

            // if X < 0, then ball's gone off the left
            if (ball.GetPosition().X < 0)
            {
                ball.ChangePosition(0, ball.GetPosition().Y);
                ball.SetXVelocity(-ball.GetXVelocity());
            }

            // if X > Width, then ball's gone off the right
            if (ball.GetPosition().X + ball.GetPosition().Width > this.Width)
            {
                ball.ChangePosition(this.Width - ball.GetPosition().Width, ball.GetPosition().Y);
                ball.SetXVelocity(-ball.GetXVelocity());
            }

            // Check to see if its hit the paddle 
            if (ball.CheckForIntersect(paddle))
            {
                ball.ChangePosition(ball.GetPosition().X,
                                    ball.GetPosition().Y - ball.GetPosition().Height);
                ball.SetYVelocity(-ball.GetYVelocity());

            }

            // Now deal with the bricks
            for (int row = 0; row <= bricks.GetUpperBound(0); row++)
            {
                for (int col = 0; col <= bricks.GetUpperBound(1); col++)
                {
                    if (bricks[row, col].IsVisible())
                    {
                        if (ball.CheckForIntersect(bricks[row, col]))
                        {
                            bricks[row, col].SetVisibility(false);
                            if (ball.GetPosition().X + 10 < bricks[row, col].GetPosition().X ||
                                ball.GetPosition().X > bricks[row, col].GetPosition().X
                                + bricks[row, col].GetPosition().Width)
                            {
                                ball.SetXVelocity(-ball.GetXVelocity());
                            }
                            else
                            {
                                ball.SetYVelocity(-ball.GetYVelocity());
                            }

                        }
                    }

                }
            }

            if (GetBrickCount() == 0)
            {
                timer.Stop();
                Cursor.Show();
                if (MessageBox.Show("Would you like to play again?", "Play Again?", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ball.SetVisibility(false);   // turn off the current ball
                    paddle.SetVisibility(false); // turn off the paddle
                    InitialiseGameScreenForm();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

    }
}
