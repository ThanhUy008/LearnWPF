
using MyLib;
using System;
using System.Text;

namespace Point2D
{
    public class PointToStringUIConverter : IShapeToStringUIConverter
    {
        public string MagicWord { get => "Point"; }
        public string convert(IShape shape)
        {
            Point2D line = (Point2D)shape;
            var builder = new StringBuilder();
            builder.Append("(");
            builder.Append(line.X);
            builder.Append(",");
            builder.Append(line.Y);
            builder.Append(")");

            string result = builder.ToString();
            return result;
        }

        public IShape convertBack(string buffer)
        {
            throw new NotImplementedException();
        }
    }
}
