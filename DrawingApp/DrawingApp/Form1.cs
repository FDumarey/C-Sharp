using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingApp
{
    public partial class frmLine : Form
    {
        //Lines
        int numberPoints = 0;
        const int maxPoints = 50;
        Random myRandom = new Random();
        EndPoint[] LineEnds = new EndPoint[maxPoints];

        //Rectangles and Ellipses
        Rectangle myRectangle;
        bool isDrawn = false;
        bool isFilled = false;
        int fillRed, fillBlue, fillGreen;

        //Pies
        int numberSlices;
        PieSlice[] slices = new PieSlice[6];
        Color[] myColors = new Color[6];

        public frmLine()
        {
            InitializeComponent();
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            do
            {
                LineEnds[numberPoints] = new EndPoint();
                LineEnds[numberPoints].X = myRandom.Next(pnlDraw.ClientSize.Width);
                LineEnds[numberPoints].Y = myRandom.Next(pnlDraw.ClientSize.Height);
                numberPoints += 1;

            }
            while (numberPoints < 2);
            pnlDraw_Paint(null, null);

            if (numberPoints == maxPoints)
            {
                btnLine.Enabled = false;
            }
        }

        private void btnDrawRE_Click(object sender, EventArgs e)
        {
            int w = (int) (pnlDraw.ClientSize.Width * (myRandom.Next(71)+20)/100);
            int h = (int)(pnlDraw.ClientSize.Height * (myRandom.Next(71) + 20) / 100);
            int l = (int)(0.5 * (pnlDraw.ClientSize.Width - w));
            int t = (int)(0.5 * (pnlDraw.ClientSize.Height - h));
            myRectangle = new Rectangle(l, t, w, h);
            isDrawn = true;
            isFilled = false;
            btnDrawRE.Enabled = false;
            btnFillRE.Enabled = true;
            btnClearRE.Enabled = true;
            pnlDraw_Paint(null, null);
        }

        private void btnFillRE_Click(object sender, EventArgs e)
        {
            isFilled = true;
            btnDrawRE.Enabled = false;
            fillRed = myRandom.Next(256);
            fillGreen = myRandom.Next(256);
            fillBlue = myRandom.Next(256);
            pnlDraw_Paint(null, null);
        }

        private void btnClearRE_Click(object sender, EventArgs e)
        {
            isDrawn = false;
            isFilled = false;
            btnDrawRE.Enabled = true;
            btnFillRE.Enabled = false;
            btnClearRE.Enabled = false;
            pnlDraw_Paint(null, null);
        }

        private void rdoRectangle_CheckedChanged(object sender, EventArgs e)
        {
            btnClearRE_Click(null, null);
        }

        private void frmLine_Load(object sender, EventArgs e)
        {
            myRectangle = new Rectangle(20, 20, pnlDraw.ClientSize.Width - 40, pnlDraw.ClientSize.Height - 40);
            myColors[0] = Color.Red;
            myColors[1] = Color.Green;
            myColors[2] = Color.Yellow;
            myColors[3] = Color.Blue;
            myColors[4] = Color.Magenta;
            myColors[5] = Color.Cyan;
        }

        private void btnClearPie_Click(object sender, EventArgs e)
        {
            isDrawn = false;
            btnDrawPie.Enabled = true;
            btnClearPie.Enabled = false;
            pnlDraw_Paint(null, null);
        }

        private void btnDrawPie_Click(object sender, EventArgs e)
        {
            float degreesRemaining;
            numberSlices = myRandom.Next(5) + 2;
            degreesRemaining = 360;
            for (int n=0;n<numberSlices;n++)
            {
                if (n < numberSlices - 1)
                {
                    slices[n] = new PieSlice(myRandom.Next((int)(0.5 * degreesRemaining)) + 1, myColors[n]);
                }
                else
                {
                    slices[n] = new PieSlice(degreesRemaining, myColors[n]);
                }
                degreesRemaining -= slices[n].SweepAngle;
            }
            isDrawn = true;
            btnDrawPie.Enabled = false;
            btnClearPie.Enabled = true;
            pnlDraw_Paint(null, null);

        }

        private void btnNoLines_Click(object sender, EventArgs e)
        {
            numberPoints = 0;
            btnLine.Enabled = true;
            pnlDraw_Paint(null, null);
        }

        private void pnlDraw_Paint(object sender, PaintEventArgs e)
        {
            Graphics myGraphics;
            Pen myPen;
            Brush myBrush;
            myGraphics = pnlDraw.CreateGraphics();
            
            // Draw Lines
            myPen = new Pen(Color.Blue, 3);

            if (numberPoints != 0)
            {
                for (int i=1; i < numberPoints; i++)
                {
                    myGraphics.DrawLine(myPen, LineEnds[i - 1].X, LineEnds[i - 1].Y, LineEnds[i].X, LineEnds[i].Y);
                }
            }
            else
            {
                myGraphics.Clear(pnlDraw.BackColor);
            }

            // Draw Rectangles and Ellipses
            if (isFilled)
            {
                myBrush = new SolidBrush(Color.FromArgb(fillRed, fillGreen, fillBlue));
                if (rdoRectangle.Checked)
                {
                    myGraphics.FillRectangle(myBrush, myRectangle);
                }
                else
                {
                    myGraphics.FillEllipse(myBrush, myRectangle);
                }
                myBrush.Dispose();

            }
            if (isDrawn)
            {
                if (rdoRectangle.Checked)
                {
                    myGraphics.DrawRectangle(myPen, myRectangle);
                }
                else
                {
                    myGraphics.DrawEllipse(myPen, myRectangle);
                }
            }

            //Draw Pies
            float startAngle;
            if (isDrawn)
            {
                startAngle = 0;
                for (int n = 0; n < numberSlices; n++)
                {
                    myBrush = new SolidBrush(slices[n].SliceColor);
                    myGraphics.FillPie(myBrush, myRectangle, startAngle, slices[n].SweepAngle);
                    myGraphics.DrawPie(Pens.Black, myRectangle, startAngle, slices[n].SweepAngle);
                    startAngle += slices[n].SweepAngle;
                    myBrush.Dispose();
                }
                myGraphics.DrawEllipse(Pens.Black, myRectangle);
            }
            else
            {
                myGraphics.Clear(pnlDraw.BackColor);
            }

            myPen.Dispose();
            myGraphics.Dispose();
        }
    }
}
