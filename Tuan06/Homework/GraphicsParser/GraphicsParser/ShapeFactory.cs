using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsParser
{
    public class ShapeFactory
    {
        public IShape CreateShape (string name,string cors)
        {
            IShapeToStringConverter converter;
            IShape result = null;
            switch(name)
            {
                case "Line":
                    converter = new LineToStringConverter();
                    result = converter.ConvertBack(cors);

                    break;
                case "Rectangle":
                    converter = new RectangleToStringConverter();
                    result = converter.ConvertBack(cors);
                    break;
                case "Ellipse":
                    converter = new EllipseToStringConverter();
                    result = converter.ConvertBack(cors);
                    break;
                default:
                    break;
            }
            
            return result;
        }
        public string ReadShape(IShape shape)
        {
            IShapeToStringConverter converter;
            string result = null;
            switch (shape.name)
            {
                case "Line":
                    converter = new LineToStringConverter();
                    result = converter.Convert(shape);

                    break;
                case "Rectangle":
                    converter = new RectangleToStringConverter();
                    result = converter.Convert(shape);
                    break;
                case "Ellipse":
                    converter = new EllipseToStringConverter();
                    result = converter.Convert(shape); ;
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
