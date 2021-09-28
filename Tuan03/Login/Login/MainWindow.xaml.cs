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

namespace Login
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(String.IsNullOrEmpty(Username.Text))
            {
                MessageBox.Show("Không được để trống tài khoản","Thông báo",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            else if (String.IsNullOrEmpty(Password.Password))
            {
                MessageBox.Show("Không được để trống mật khẩu", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            else if(Username.Text.Equals("admin")&& Password.Password.Equals("qwe3@1")){

                var dashboard = new Dashboard();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }
    }
}
