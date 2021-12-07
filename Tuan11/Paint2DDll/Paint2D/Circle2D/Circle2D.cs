using Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
namespace Circle2D
{
    class Circle2D : IShape
    {
        private Point2D _leftTop = new Point2D();
        private Point2D _rightBottom = new Point2D();

        public string Name => "Circle";

        public UIElement Draw()
        {
            int flag1 = 1;
            int flag2 = 1;
            if (_leftTop.X >= _rightBottom.X)
                flag1 = -1;


            if (_leftTop.Y >= _rightBottom.Y)
                flag2 = -1;
            var circle = new Ellipse()
            {
                Width = (_rightBottom.X - _leftTop.X) * flag1,
                Height = (_rightBottom.X - _leftTop.X) * flag1,
                Stroke = new SolidColorBrush(Colors.Red),
                StrokeThickness = 1
            };
            if (flag1 == 1)
                Canvas.SetLeft(circle, _leftTop.X);
            else
                Canvas.SetLeft(circle, _rightBottom.X);
            if (flag2 == 1)
                Canvas.SetTop(circle, _leftTop.Y);
            else
                Canvas.SetTop(circle, _rightBottom.Y);

            return circle;
        }

        public void HandleStart(double x, double y)
        {
            _leftTop.X = x;
            _leftTop.Y = y;
        }

        public void HandleEnd(double x, double y)
        {
            _rightBottom.X = x;
            _rightBottom.Y = y;
        }

        public IShape Clone()
        {
            return new Circle2D();
        }
    }
}
