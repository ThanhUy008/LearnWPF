using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsParser
{
    public class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        int X { get; set; }
        int Y { get; set; }

        public override string ToString()
        {
            return "("+X+", "+Y+")";
        }
    }
}
