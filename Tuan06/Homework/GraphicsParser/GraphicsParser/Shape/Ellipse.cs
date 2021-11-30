using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsParser
{
    class Ellipse : IShape
    {
        public string name => "Ellipse";
        public Point TopLeft { get; set; }
        public Point RightBottom { get; set; }

        public Ellipse(Point a, Point b)
        {
            TopLeft = a;
            RightBottom = b;
        }
        
        public override string ToString()
        {
            return name + ": (" + TopLeft.ToString() + ", " + RightBottom.ToString() + ")";
        }

    }
}
