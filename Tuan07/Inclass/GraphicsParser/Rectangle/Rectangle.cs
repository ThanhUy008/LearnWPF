
using MyLib;
using System;

namespace Rectangle
{
    public class Rectangle : IShape
    {
        public string MagicWord { get => "Rectangle"; }
        public Point2D.Point2D TopLeft { get; set; }
        public Point2D.Point2D RightBottom { get; set; }
    }
}
