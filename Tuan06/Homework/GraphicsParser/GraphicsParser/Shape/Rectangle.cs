using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsParser
{
    class Rectangle : IShape
    {
        public string name => "Rectangle";
        public Point TopLeft { get; set; }
        public Point RightBottom { get; set; }
        public Rectangle(Point a, Point b)
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
