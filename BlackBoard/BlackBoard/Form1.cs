using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackBoard
{
    public partial class frmBlackBoard : Form
    {
        Graphics blackboard;
        Pen myPen;
        bool drawingOn;
        int xPrevious, yPrevious;
        Color leftColor, rightColor;

        //Polygons
        Point[] clickedPoint = new Point[30];
        Point[] drawingPoint;
        int maximumPoint;
        bool isDrawn;
        Random myRandom = new Random();
        Brush myBrush;

        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to start a new drawing?","New Drawing",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                pnlDraw.BackgroundImage = new Bitmap(pnlDraw.ClientSize.Width, pnlDraw.ClientSize.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                blackboard = Graphics.FromImage(pnlDraw.BackgroundImage);
            }
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit this application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Error,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmBlackBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            blackboard.Dispose();
            myPen.Dispose();
        }

        private void LblColor_MouseDown(object sender, MouseEventArgs e)
        {
            Label colorClicked = (Label)sender;
            if (e.Button == MouseButtons.Left)
            {
                leftColor = colorClicked.BackColor;
                lblLeftColor.BackColor = leftColor;
            }
            else if (e.Button==MouseButtons.Right)
            {
                rightColor = colorClicked.BackColor;
                lblRightColor.BackColor = rightColor;
            }
        }

        private void pnlDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Left || e.Button == MouseButtons.Right) && !chkPolygons.Checked)
            {
                drawingOn = true;
                xPrevious = e.X;
                yPrevious = e.Y;
                if (e.Button == MouseButtons.Left)
                {
                    myPen.Color = leftColor;
                }
                else
                {
                    myPen.Color = rightColor;
                }
            }
            else
            {
                if (isDrawn)
                {
                    timCurve.Enabled = false;
                    btnDraw.Enabled = true;
                    btnClose.Enabled = false;
                    btnFill.Enabled = false;
                    rdoLines.Enabled = true;
                    rdoCurves.Enabled = true;
                    isDrawn = false;
                    maximumPoint = 0;
                    blackboard = Graphics.FromImage(pnlDraw.BackgroundImage);
                }
                else if (maximumPoint >29)
                {
                    MessageBox.Show("Maximum points exceeded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                clickedPoint[maximumPoint].X = e.X;
                clickedPoint[maximumPoint].Y = e.Y;
                blackboard.FillEllipse(Brushes.Red, clickedPoint[maximumPoint].X - 1, clickedPoint[maximumPoint].Y - 1, 3, 3);
                pnlDraw.Refresh();
                maximumPoint++;
            }

        }

        private void pnlDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawingOn)
            {
                blackboard.DrawLine(myPen, xPrevious, yPrevious, e.X, e.Y);
                pnlDraw.Refresh();
                xPrevious = e.X;
                yPrevious = e.Y;
            }
        }

        private void pnlDraw_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawingOn && (e.Button==MouseButtons.Left || e.Button==MouseButtons.Right))
            {
                blackboard.DrawLine(myPen, xPrevious, yPrevious, e.X, e.Y);
                pnlDraw.Refresh();
                drawingOn = false;
            }
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            drawingPoint = new Point[maximumPoint];
            for (int n=0;n<maximumPoint;n++)
            {
                drawingPoint[n] = new Point(clickedPoint[n].X, clickedPoint[n].Y);
            }

            if (maximumPoint<3)
            {
                return;
            }
            else
            {
                rdoLines.Enabled = false;
                rdoCurves.Enabled = false;
                btnDraw.Enabled = false;
                btnClose.Enabled = true;
                if (rdoLines.Checked)
                {
                    blackboard.DrawLines(Pens.White, drawingPoint);
                    pnlDraw.Refresh();
                }
                else
                {
                    blackboard.DrawCurve(Pens.White, drawingPoint);
                    pnlDraw.Refresh();
                }
                isDrawn = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnClose.Enabled = false;
            btnFill.Enabled = true;
            if (rdoLines.Checked)
            {
                blackboard.DrawPolygon(Pens.White, drawingPoint);
                pnlDraw.Refresh();
            }
            else
            {
                blackboard.DrawClosedCurve(Pens.White, drawingPoint);
                pnlDraw.Refresh();
            }
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            myBrush = new SolidBrush(Color.FromArgb(myRandom.Next(256), myRandom.Next(256), myRandom.Next(256)));
            if (rdoLines.Checked)
            {
                blackboard.FillPolygon(myBrush, drawingPoint);
                blackboard.DrawPolygon(Pens.White, drawingPoint);
                pnlDraw.Refresh();
            }
            else
            {
                blackboard.FillClosedCurve(myBrush, drawingPoint);
                blackboard.DrawClosedCurve(Pens.White, drawingPoint);
                pnlDraw.Refresh();
            }
            if (chkAnimation.Checked) timCurve.Enabled = true;
        }

        private void timCurve_Tick(object sender, EventArgs e)
        {
            for (int i=0;i<maximumPoint;i++)
            {
                drawingPoint[i].X += myRandom.Next(21) - 10;
                drawingPoint[i].Y += myRandom.Next(21) - 10;
            }
            //pnlDraw.BackgroundImage = new Bitmap(pnlDraw.ClientSize.Width, pnlDraw.ClientSize.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            blackboard = Graphics.FromImage(pnlDraw.BackgroundImage);
            pnlDraw.Refresh();
            if (rdoLines.Checked)
            {
                blackboard.FillPolygon(myBrush, drawingPoint);
                blackboard.DrawPolygon(Pens.White, drawingPoint);
                pnlDraw.Refresh();
            }
            else
            {
                blackboard.FillClosedCurve(myBrush, drawingPoint);
                blackboard.DrawClosedCurve(Pens.White, drawingPoint);
                pnlDraw.Refresh();
            }
        }

        private void frmBlackBoard_Paint(object sender, PaintEventArgs e)
        {
            //gradient background
            Graphics myGraphics;
            Rectangle myRectangle;
            LinearGradientBrush myBrush;
            myGraphics = this.CreateGraphics();
            myRectangle = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            myBrush = new LinearGradientBrush(myRectangle, Color.Gray, Color.White, LinearGradientMode.Vertical);
            myGraphics.FillRectangle(myBrush, 0, 0, this.ClientSize.Width, this.ClientSize.Height);
            myBrush.Dispose();
            myGraphics.Dispose();
        }

        public frmBlackBoard()
        {
            InitializeComponent();
        }

        private void frmBlackBoard_Load(object sender, EventArgs e)
        {
            lblGray.BackColor = Color.Gray;
            lblBlue.BackColor = Color.Blue;
            lblGreen.BackColor = Color.LightGreen;
            lblCyan.BackColor = Color.Cyan;
            lblRed.BackColor = Color.Red;
            lblMagenta.BackColor = Color.Magenta;
            lblYellow.BackColor = Color.Yellow;
            lblWhite.BackColor = Color.White;

            leftColor = Color.Gray;
            lblLeftColor.BackColor = leftColor;
            rightColor = Color.White;
            lblRightColor.BackColor = rightColor;

            pnlDraw.BackgroundImage = new Bitmap(pnlDraw.ClientSize.Width, pnlDraw.ClientSize.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            blackboard = Graphics.FromImage(pnlDraw.BackgroundImage);
            myPen = new Pen(leftColor);

            //Polygons
            isDrawn = true;

            
        }
    }
}
