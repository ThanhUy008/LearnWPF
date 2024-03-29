﻿
using MyLib;
using System;

namespace Ellipse
{
    public class EllipseToStringDataConverter : IShapeToStringDataConverter
    {
        public string MagicWord { get => "Ellipse"; }

        public string Convert(IShape shape)
        {
            throw new NotImplementedException();
        }

        // Line ((2, 2), (1, 1))
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

            var p1 = new Point2D.Point2D() { X = int.Parse(tokens1[0]), Y = int.Parse(tokens1[1]) };
            var p2 = new Point2D.Point2D() { X = int.Parse(tokens2[0]), Y = int.Parse(tokens2[1]) };
            IShape result = new Ellipse() { TopLeft = p1, RightBottom = p2 };
            return result;
        }
    }
}
