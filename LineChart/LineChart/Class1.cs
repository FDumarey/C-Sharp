using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace LineChart
{
    public class LineChart
    {
        private int[] xClient;
        private int[] yClient;

        public LineChart(Panel p, int n, double[] x, double[] y)
        {
            //p = panel to draw
            //n = number of points
            //x = array of x points
            //y = array of y points
            if (n<2)
            {
                return;
            }
            double xMin, xMax;
            double yMin, yMax;
            xMin = x[0]; xMax = x[0];
            yMin = y[0]; yMax = y[0];
            for (int i=1; i<n; i++)
            {
                if (x[i] < xMin)
                {
                    xMin = x[i];
                }
                if (x[i] > xMax)
                {
                    xMax = x[i];
                }
                if (y[i] < yMin)
                {
                    yMin = y[i];
                }
                if (y[i] > yMax)
                {
                    yMax = y[i];
                }
            }
            yMin = (double)((1 - 0.05 * Math.Sign(yMin)) * yMin);
            yMax = (double)((1 + 0.05 * Math.Sign(yMax)) * yMax);
            xClient = new int[n];
            yClient = new int[n];
            for(int i=0;i<n;i++)
            {
                xClient[i] = xUserToxClient(p, x[i], xMin, xMax);
                yClient[i] = yUserToyClient(p, y[i], yMin, yMax);
            }
        }

        public void Draw(Panel p, Color c)
        {
            Graphics lineChart;
            Pen myPen;
            lineChart = p.CreateGraphics();
            myPen = new Pen(c);
            lineChart.Clear(p.BackColor);
            for (int i=0;i<xClient.Length-1;i++)
            {
                lineChart.DrawLine(myPen, xClient[i], yClient[i], xClient[i + 1], yClient[i + 1]);
            }
            lineChart.Dispose();
            myPen.Dispose();
        }

        public int xUserToxClient(Panel p, double xUser, double xMin, double xMax)
        {
            return ((int)((p.ClientSize.Width - 1) * (xUser - xMin) / (xMax - xMin)));
        }

        public int yUserToyClient(Panel p, double yUser, double yMin, double yMax)
        {
            return ((int)((p.ClientSize.Height - 1) * (yMax - yUser) / (yMax - yMin)));
        }
    }
}
