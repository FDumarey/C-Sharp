using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarChart;
using LineChart;
using PieChart;

namespace PlottingCharts
{
    public partial class frmPlot : Form
    {
        int whichPlot = 0;
        double[] x = new double[200];
        double[] y = new double[200];
        double[] yd = new double[200];
        Color[] plotColor = new Color[10];
        double alpha, beta;
        Color lineColor;
        int numberBars;
        int numberSlices;
        Random myRandom = new Random();

        public frmPlot()
        {
            InitializeComponent();
        }

        private void mnuPlotLine_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem itemClicked = (ToolStripMenuItem)sender;
            mnuPlotLine.Checked = false;
            mnuPlotSpiral.Checked = false;
            mnuPlotBar.Checked = false;
            mnuPlotPie.Checked = false;
            itemClicked.Checked = true;

            alpha = (100.0 - myRandom.Next(200)) / 1000.0;
            beta = myRandom.Next(1000) / 100.0 + 5.0;
            for (int i=0;i<200;i++)
            {
                x[i] = i;
                y[i] = (double)(Math.Exp(-alpha * i) * Math.Sin(Math.PI * i / beta));
                yd[i] = (double)(Math.Exp(-alpha * i) * (Math.PI * Math.Cos(Math.PI * i / beta) / beta - alpha * Math.Sin(Math.PI * i / beta)));
                lineColor = plotColor[myRandom.Next(10)];
                if (mnuPlotLine.Checked)
                {
                    whichPlot = 1;
                }
                else
                {
                    whichPlot = 2;
                }
                pnlPlot_Paint(null, null);
            }
        }

        private void mnuPlotBar_Click(object sender, EventArgs e)
        {
            mnuPlotLine.Checked = false;
            mnuPlotSpiral.Checked = false;
            mnuPlotBar.Checked = true;
            mnuPlotPie.Checked = false;
            numberBars = myRandom.Next(6) + 5;
            for (int i=0;i<numberBars;i++)
            {
                y[i] = (double)(myRandom.Next(2000) / 100.0 - 10.0);
            }
            whichPlot = 3;
            pnlPlot_Paint(null, null);
        }

        private void mnuPlotPie_Click(object sender, EventArgs e)
        {
            mnuPlotLine.Checked = false;
            mnuPlotSpiral.Checked = false;
            mnuPlotBar.Checked = false;
            mnuPlotPie.Checked = true;
            numberSlices = myRandom.Next(8) + 3;
            for (int i=0;i<numberSlices;i++)
            {
                y[i] = (double)(myRandom.Next(5000) / 100.0 + 1.0);
            }
            whichPlot = 4;
            pnlPlot_Paint(null, null);
        }

        private void pnlPlot_Paint(object sender, PaintEventArgs e)
        {
            switch(whichPlot)
            {
                case 0:
                    return;
                case 1:
                    LineChart.LineChart myLineChart;
                    myLineChart = new LineChart.LineChart(pnlPlot, 200, x, y);
                    myLineChart.Draw(pnlPlot, lineColor);
                    break;
                case 2:
                    LineChart.LineChart mySpiralChart;
                    mySpiralChart = new LineChart.LineChart(pnlPlot, 200, y, yd);
                    mySpiralChart.Draw(pnlPlot, lineColor);
                    break;
                case 3:
                    BarChart.BarChart myBarChart;
                    myBarChart = new BarChart.BarChart(pnlPlot, numberBars, y, 0);
                    myBarChart.Draw(pnlPlot, plotColor);
                    break;
                case 4:
                    PieChart.PieChart myPieChart;
                    myPieChart = new PieChart.PieChart(numberSlices, y, plotColor);
                    myPieChart.Draw(pnlPlot);
                    break;
            }
        }

        private void mnuPlotExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPlot_Load(object sender, EventArgs e)
        {
            plotColor[0] = Color.Black;
            plotColor[1] = Color.DarkBlue;
            plotColor[2] = Color.DarkGreen;
            plotColor[3] = Color.DarkCyan;
            plotColor[4] = Color.DarkRed;
            plotColor[5] = Color.DarkMagenta;
            plotColor[6] = Color.Brown;
            plotColor[7] = Color.Blue;
            plotColor[8] = Color.Gray;
            plotColor[9] = Color.Red;
        }
    }
}
