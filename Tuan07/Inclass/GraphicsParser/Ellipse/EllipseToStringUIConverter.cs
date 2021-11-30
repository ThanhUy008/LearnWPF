
using MyLib;
using Point2D;
using System;
using System.Text;

namespace Ellipse
{
    public class EllipseToStringUIConverter : IShapeToStringUIConverter
    {
        public string MagicWord { get => "Ellipse"; }

        public string convert(IShape shape)
        {
            Ellipse ellipse = (Ellipse)shape;
            var builder = new StringBuilder();

            var pointConverter = new PointToStringUIConverter();
            builder.Append(shape.MagicWord).Append(": ");
            builder.Append("(").Append(pointConverter.convert(ellipse.TopLeft))
                   .Append("), (").Append(pointConverter.convert(ellipse.RightBottom))
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
