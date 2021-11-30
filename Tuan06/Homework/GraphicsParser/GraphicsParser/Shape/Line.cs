using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsParser
{
    class Line : IShape
    {
        public string name => "Line";
       
        Point Start { get; set; }
        Point End { get; set; }
        public Line(Point a, Point b)
        {
            Start = a;
            End = b;
        }
        public override string ToString()
        {
            return name + ": (" + Start.ToString() + ", " + End.ToString() + ")";
        }
    }
}
