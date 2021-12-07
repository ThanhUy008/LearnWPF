using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Paint2D
{
    public class Line2D : IShape
    {
        private Point2D _start = new Point2D();
        private Point2D _end = new Point2D();

        public string Name => "Line";

        public void HandleStart(double x, double y)
        {
            _start = new Point2D() { X = x, Y = y };
        }

        public void HandleEnd(double x, double y)
        {
            _end = new Point2D() { X = x, Y = y };
        }

        public UIElement Draw()
        {
            Line l = new Line()
            {
                X1 = _start.X,
                Y1 = _start.Y,
                X2 = _end.X,
                Y2 = _end.Y,
                StrokeThickness = 1,
                Stroke = new SolidColorBrush(Colors.Red),
            };

            return l;
        }
    }
}
