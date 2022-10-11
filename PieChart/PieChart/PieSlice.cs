using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PieChart
{
    class PieSlice
    {
        public float SweepAngle;
        public Color SliceColor;
        
        public PieSlice(float a, Color c)
        {
            this.SweepAngle = a;
            this.SliceColor = c;
        }
    }
}
