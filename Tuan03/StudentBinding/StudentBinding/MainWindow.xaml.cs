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

namespace StudentBinding
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var sv = new Student
            {
                ID = "18120645",
                Name = "Bùi Thanh Uy",
                Address = "Tổ 3, Phường 8, Quận Tân Bình",
                Email = "thanhuy008@gmail.com",
                Phone = "0123456778"
            };
            this.DataContext = sv;
        }
    }
}
