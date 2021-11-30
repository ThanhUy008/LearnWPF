
using MyLib;
using Point2D;
using System;
using System.Text;

namespace Rectangle
{
    public class RectangleToStringUIConverter : IShapeToStringUIConverter
    {
        public string MagicWord { get => "Rectangle"; }

        public string convert(IShape shape)
        {
            Rectangle rectangle = (Rectangle)shape;
            var builder = new StringBuilder();

            var pointConverter = new PointToStringUIConverter();
            builder.Append(shape.MagicWord).Append(": ");
            builder.Append("(").Append(pointConverter.convert(rectangle.TopLeft))
                   .Append("), (").Append(pointConverter.convert(rectangle.RightBottom))
                   .Append(")");

            string result = builder.ToString();
            return result;
        }

        public IShape convertBack(string buffer)
        {
            throw new NotImplementedException();
        }
    }
}
