using MyLib;

namespace Line
{
    public class Line : IShape
    {
        
        public string MagicWord { get => "Line"; }
        public Point2D.Point2D Start { get; set; }
        public Point2D.Point2D End { get; set; }
    }
}
