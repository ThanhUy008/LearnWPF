using MyLib;

namespace Point2D
{
    public class Point2D : IShape
    {
        public string MagicWord { get => "Point"; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
