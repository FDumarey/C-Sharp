using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BarChart
{
    public class BarChart
    {
        int[] yClient;
        int bClient;

        public BarChart(Panel p, int n, double[] y, double b)
        {
            if (n<1)
            {
                return;
            }

            double yMin, yMax;
            yMin = y[0]; yMax = y[0];
            if (n>1)
            {
                for (int i=1;i<n;i++)
                {
                    if (y[i] < yMin)
                        yMin = y[i];
                    if (y[i] > yMax)
                        yMax = y[i];
                }
            }

            yMin = (double)((1 - 0.05 * Math.Sign(yMin)) * yMin);
            yMax = (double)((1 + 0.05 * Math.Sign(yMax)) * yMax);
            bClient = yUserToyClient(p, b, yMin, yMax);
            yClient = new int[n];
            for (int i=0;i<n;i++)
            {
                yClient[i] = yUserToyClient(p, y[i], yMin, yMax);
            }
        }

        public void Draw(Panel p,Color[] c)
        {
            Graphics barChart;
            Brush myBrush;
            int barWidth;
            barChart = p.CreateGraphics();
            barChart.Clear(p.BackColor);
            barWidth = (int)(2 * (p.ClientSize.Width - 1) / (3 * yClient.Length + 1));
            for (int i=1;i<yClient.Length;i++)
            {
                myBrush = new SolidBrush(c[i]);
                if (bClient > yClient[i])
                {
                    barChart.FillRectangle(myBrush, (int)((1.5 * i + 0.5) * barWidth), yClient[i], barWidth, bClient - yClient[i]);
                }
                else
                {
                    barChart.FillRectangle(myBrush, (int)((1.5 * i + 0.5) * barWidth), bClient, barWidth, yClient[i]-bClient);
                }
                myBrush.Dispose();
            }
            barChart.DrawLine(Pens.Black, 0, bClient, p.ClientSize.Width - 1, bClient);
            barChart.Dispose();
        }

        public int yUserToyClient (Panel p,double yUser, double yMin, double yMax)
        {
            return ((int)((p.ClientSize.Height - 1) * (yMax - yUser) / (yMax - yMin)));
        }
    }
}
