
using MyLib;
using System;

namespace Ellipse
{
    public class Ellipse : IShape
    {
        public string MagicWord { get => "Ellipse"; }
        public Point2D.Point2D TopLeft { get; set; }
        public Point2D.Point2D RightBottom { get; set; }
    }
}
