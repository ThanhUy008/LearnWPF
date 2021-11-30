
using MyLib;
using Point2D;
using System;
using System.Text;

namespace Line
{
    public class LineToStringUIConverter : IShapeToStringUIConverter
    {
        public string MagicWord { get => "Line"; }

        public string convert(IShape shape)
        {
            Line line = (Line)shape;
            var builder = new StringBuilder();

            var pointConverter = new PointToStringUIConverter();
            builder.Append(shape.MagicWord).Append(": ");
            builder.Append("(").Append(pointConverter.convert(line.Start))
                   .Append("), (").Append(pointConverter.convert(line.End))
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
