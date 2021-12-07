using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Paint2D
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        bool _isDrawing = false;
        double _lastX = -1;
        double _lastY = -1;
        int _choice = Shapes.Line;
        List<IShape> _shapes = new List<IShape>();
        IShape _preview = new Line2D();


        

        
        

        

        

      

        

        private void lineButton_Click(object sender, RoutedEventArgs e)
        {
            _choice = Shapes.Line;
            _preview = new Line2D();
        }

        private void rectangleButton_Click(object sender, RoutedEventArgs e)
        {
            _choice = Shapes.Rectangle;
            _preview = new Rectangle2D();
        }

        private void ellipseButton_Click(object sender, RoutedEventArgs e)
        {
            _choice = Shapes.Ellipse;
            _preview = new Ellipse2D();
        }

        private void canvas_MouseDown(object sender,
            MouseButtonEventArgs e)
        {
            _isDrawing = true;

            Point pos = e.GetPosition(canvas);
            _lastX = pos.X;
            _lastY = pos.Y;

            _preview.HandleStart(pos.X, pos.Y);

            Title = "Mouse down";
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDrawing)
            {
                Point pos = e.GetPosition(canvas);
                _preview.HandleEnd(pos.X, pos.Y);

                // Xoá hết các hình vẽ cũ
                canvas.Children.Clear();

                // Vẽ lại các hình trước đó
                foreach (var shape in _shapes)
                {
                    UIElement element = shape.Draw();
                    canvas.Children.Add(element);
                }

                // Vẽ hình preview đè lên
                canvas.Children.Add(_preview.Draw());

                Title = $"{pos.X} {pos.Y}";
            }
        }

        private void canvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            _isDrawing = false;

            // Thêm đối tượng cuối cùng vào mảng quản lí
            Point pos = e.GetPosition(canvas);
            _preview.HandleEnd(pos.X, pos.Y);
            _shapes.Add(_preview);

            if (_choice == Shapes.Line)
            {
                _preview = new Line2D(); // TODO
            }
            else if (_choice == Shapes.Rectangle)
            {
                _preview = new Rectangle2D();
            }
            else if (_choice == Shapes.Ellipse)
            {
                _preview = new Ellipse2D();
            }
            else if (_choice == Shapes.Square)
            {
                _preview = new Square2D();
            }
            else if (_choice == Shapes.Circle)
            {
                _preview = new Circle2D();
            }

            // Ve lai Xoa toan bo
            canvas.Children.Clear();

            // Ve lai tat ca cac hinh
            foreach (var shape in _shapes)
            {
                var element = shape.Draw();
                canvas.Children.Add(element);
            }

        }





        private void squareButton_Click(object sender, RoutedEventArgs e)
        {
            _choice = Shapes.Square;
            _preview = new Square2D();
        }

        private void circleButton_Click(object sender, RoutedEventArgs e)
        {
            _choice = Shapes.Circle;
            _preview = new Circle2D();
        }
    }
}

