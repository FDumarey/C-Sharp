using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp
{
    class PieSlice
    {
        public float SweepAngle;
        public System.Drawing.Color SliceColor;
        
        public PieSlice(float a, System.Drawing.Color c)
        {
            this.SweepAngle = a;
            this.SliceColor = c;
        }
    }
}
