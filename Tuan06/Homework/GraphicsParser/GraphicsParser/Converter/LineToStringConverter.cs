using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsParser
{
    class LineToStringConverter : IShapeToStringConverter
    {
        public string Convert(IShape shape)
        {
            Line line = (Line)shape;

            string result = line.ToString();
            return result;
        }

        public IShape ConvertBack(string buffer)
        {
            // Remove first word
            int firstSpaceIndex = buffer.IndexOf(" ");
            // 2, 2), (1, 1
            string temp = buffer.Substring(firstSpaceIndex + 3,
                buffer.Length - firstSpaceIndex - 5);

            // 2, 2
            // 1, 1
            string[] parts = temp.Split(new string[] { "), (" }, StringSplitOptions.None);
            string[] tokens1 = parts[0].Split(new string[] { ", " }, StringSplitOptions.None);
            string[] tokens2 = parts[1].Split(new string[] { ", " }, StringSplitOptions.None);

            var p1 = new Point(int.Parse(tokens1[0]), int.Parse(tokens1[1]));
            var p2 = new Point(int.Parse(tokens2[0]), int.Parse(tokens2[1]));
            IShape result = new Line(p1, p2);
            return result;
        }
    }
}
