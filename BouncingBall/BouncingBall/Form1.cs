using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace BouncingBall
{
    public partial class frmBall : Form
    {
        // ball declarations
        int ballY, ballDir;
        Graphics myDisplay;
        Image myBall;
        int ballSize = 50;
        Rectangle myRectangle;
        
        // scroll declarations
        Graphics viewer;
        Image background;
        int scrollX = 0;

        //sprite declarations
        Image fish;
        ImageAttributes fishAttributes = new ImageAttributes();
        int fishX, fishY;

        //collision declarations
        Rectangle myPaddle;
        int paddleX = 100;

        //sounds
        SoundPlayer missSound;
        SoundPlayer bounceSound;

        public frmBall()
        {
            InitializeComponent();
        }

        private void frmBall_FormClosing(object sender, FormClosingEventArgs e)
        {
            myDisplay.Dispose();
            myBall.Dispose();
            viewer.Dispose();
            background.Dispose();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (timBall.Enabled)
            {
                timBall.Enabled = false;
                btnStart.Text = "&Start";
            }
            else
            {
                timBall.Enabled = true;
                btnStart.Text = "&Stop";
            }
        }

        private void timBall_Tick(object sender, EventArgs e)
        {
            ballY += (int)(ballDir * pnlDisplay.ClientSize.Height / 50);
            if (ballY < 0)
            {
                ballY = 0;
                ballDir = 1;
                bounceSound.Play();
            }
            else
            {
                if (myRectangle.IntersectsWith(myPaddle))
                {
                    ballY = myPaddle.Y - ballSize;
                    ballDir = -1;
                    bounceSound.Play();
                }
            }
            if (ballY > pnlDisplay.ClientSize.Height)
            {
                ballY = -ballSize;
                missSound.PlaySync();
            }
            pnlDisplay_Paint(null, null);
        }

        private void pnlDisplay_Paint(object sender, PaintEventArgs e)
        {
            myRectangle = new Rectangle((int)(0.5 * (pnlDisplay.ClientSize.Width - ballSize)), ballY, ballSize, ballSize);
            myDisplay.Clear(pnlDisplay.BackColor);
            myDisplay.DrawImage(myBall, myRectangle);

            //draw paddle
            myDisplay.FillRectangle(Brushes.Red, myPaddle);
        }

        private void frmBall_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                fishY -= 5;
            }
            else if (e.KeyCode == Keys.Down)
            {
                fishY += 5;
            }
            else if (e.KeyCode == Keys.Q)
            {
                paddleX -= 5;
                myPaddle.X = paddleX;
            }
            else if (e.KeyCode == Keys.D)
            {
                paddleX += 5;
                myPaddle.X = paddleX;
            }
            e.Handled = true;
        }

        private void timScroll_Tick(object sender, EventArgs e)
        {
            int addedWidth;
            Rectangle rectangleDest, rectangleSrc;
            scrollX += hsbScroll.Value;
            if (scrollX > background.Width)
            {
                scrollX = 0;
            }
            if (scrollX > (background.Width - pnlViewer.ClientSize.Width))
            {
                addedWidth = background.Width - scrollX;
                rectangleDest = new Rectangle(0, 0, addedWidth, pnlViewer.ClientSize.Height);
                rectangleSrc = new Rectangle(scrollX, 0, addedWidth, background.Height);
                viewer.DrawImage(background, rectangleDest, rectangleSrc, GraphicsUnit.Pixel);

                rectangleDest = new Rectangle(addedWidth, 0, pnlViewer.ClientSize.Width - addedWidth, pnlViewer.ClientSize.Height);
                rectangleSrc = new Rectangle(0, 0, pnlViewer.ClientSize.Width - addedWidth, background.Height);
                viewer.DrawImage(background, rectangleDest, rectangleSrc, GraphicsUnit.Pixel);
            }
            else
            {
                rectangleDest = new Rectangle(0, 0, pnlViewer.ClientSize.Width, pnlViewer.ClientSize.Height);
                rectangleSrc = new Rectangle(scrollX, 0, pnlViewer.ClientSize.Width, background.Height);
                viewer.DrawImage(background, rectangleDest, rectangleSrc, GraphicsUnit.Pixel);
            }

            //sprite
            Rectangle fishDest = new Rectangle(fishX, fishY, fish.Width, fish.Height);
            viewer.DrawImage(fish, fishDest, 0, 0, fish.Width, fish.Height, GraphicsUnit.Pixel, fishAttributes);
        }

        private void frmBall_Load(object sender, EventArgs e)
        {
            //ball
            ballY = 0;
            ballDir = 1;
            myDisplay = pnlDisplay.CreateGraphics();
            myBall = Image.FromFile(Application.StartupPath + "\\ball.gif");
            pnlDisplay_Paint(null, null);

            //scroll
            background = Image.FromFile(Application.StartupPath + "\\undrsea1.bmp");
            pnlViewer.Height = background.Height;
            viewer = pnlViewer.CreateGraphics();

            //sprite
            fishAttributes.SetColorKey(Color.FromArgb(192, 192, 192), Color.FromArgb(192, 192, 192));
            fish = Image.FromFile(Application.StartupPath + "\\fish.bmp");
            fishX = (int)(0.5 * (pnlViewer.ClientSize.Width - fish.Width));
            fishY = (int)(0.5 * (pnlViewer.ClientSize.Height - fish.Height));

            //paddle
            myPaddle = new Rectangle(paddleX, pnlDisplay.Height - 20, ballSize, 10);
            pnlDisplay_Paint(null, null);

            //sounds
            bounceSound = new SoundPlayer(Application.StartupPath + "\\bong.wav");
            missSound = new SoundPlayer(Application.StartupPath + "\\missed.wav");
        }
    }
}
