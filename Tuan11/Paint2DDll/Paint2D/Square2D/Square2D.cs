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

namespace Square2D
{
    public class Square2D : IShape
    {
        private Point2D _leftTop = new Point2D();
        private Point2D _rightBottom = new Point2D();

        public string Name => "Square";


        public void HandleStart(double x, double y)
        {
            _leftTop = new Point2D() { X = x, Y = y };
        }

        public void HandleEnd(double x, double y)
        {
            _rightBottom = new Point2D() { X = x, Y = y };
        }

        public UIElement Draw()
        {
            int flag1 = 1;
            int flag2 = 1;
            if (_leftTop.X >= _rightBottom.X)
                flag1 = -1;


            if (_leftTop.Y >= _rightBottom.Y)
                flag2 = -1;
            var square = new Rectangle()
            {
                Width = (_rightBottom.X - _leftTop.X) * flag1,
                Height = (_rightBottom.X - _leftTop.X) * flag1,
                Stroke = new SolidColorBrush(Colors.Red),
                StrokeThickness = 1
            };
            if (flag1 == 1)
                Canvas.SetLeft(square, _leftTop.X);
            else
                Canvas.SetLeft(square, _rightBottom.X);
            if (flag2 == 1)
                Canvas.SetTop(square, _leftTop.Y);
            else
                Canvas.SetTop(square, _rightBottom.Y);

            return square;
        }
        public IShape Clone()
        {
            return new Square2D();
        }
    }
}
