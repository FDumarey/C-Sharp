using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PieChart
{
    public class PieChart
    {
        PieSlice[] slice;

        public PieChart(int n, double[] y, Color[] c)
        {
            //n = number of pie segments
            //y = array of points to chart
            //c = color of pie segments
            slice = new PieSlice[n];
            double sum = 0;
            for (int i=0; i<n; i++)
            {
                sum += y[i];
            }

            for (int i=0;i<n;i++)
            {
                slice[i] = new PieSlice((float)(360.0 * y[i] / sum), c[i]);
            }
        }

        public void Draw(System.Windows.Forms.Panel p)
        {
            Graphics pieChart;
            Brush myBrush;
            Rectangle myRectangle;
            float startAngle;
            if (p.ClientSize.Height < p.ClientSize.Width)
            {
                myRectangle = new Rectangle((int)(0.5 * p.ClientSize.Width - 0.45 * p.ClientSize.Height), (int)(0.05 * p.ClientSize.Height), (int)(0.9 * p.ClientSize.Height), (int)(0.9 * p.ClientSize.Height));

            }
            else
            {
                myRectangle = new Rectangle((int)(0.5 * p.ClientSize.Width - 0.45 * p.ClientSize.Width), (int)(0.5 * p.ClientSize.Height-0.45*p.ClientSize.Width), (int)(0.9 * p.ClientSize.Width), (int)(0.9 * p.ClientSize.Width));
            }

            pieChart = p.CreateGraphics();
            pieChart.Clear(p.BackColor);
            startAngle = 0;
            for (int i=0;i<slice.Length;i++)
            {
                myBrush = new SolidBrush(slice[i].SliceColor);
                pieChart.FillPie(myBrush, myRectangle, startAngle, slice[i].SweepAngle);
                pieChart.DrawPie(Pens.Black, myRectangle, startAngle, slice[i].SweepAngle);
                startAngle += slice[i].SweepAngle;
                myBrush.Dispose();
            }
            pieChart.DrawEllipse(Pens.Black, myRectangle);
            pieChart.Dispose();
        }
    }
}
