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

namespace StudentBindingNotify
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Student student;
        private static Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            student = new Student()
            {
                MSSV = "",
                Name = "",
                Address = "",
                Phone = "",
                Email = "",
                avatarPath = ""
            };
            studentPanel.DataContext = student;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
             string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            student.MSSV = "MSSV : " + new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());
            student.Name = "Tên: " + new string(Enumerable.Repeat(chars, 12).Select(s => s[random.Next(s.Length)]).ToArray());
            student.Address = "Adress : " + new string(Enumerable.Repeat(chars, 22).Select(s => s[random.Next(s.Length)]).ToArray());
            student.Phone = "SĐT : " + new string(Enumerable.Repeat(chars, 15).Select(s => s[random.Next(s.Length)]).ToArray());
            student.Email = "Email: " + new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray()) + "@gmail.com";
            student.avatarPath ="./images/avatar" + random.Next(1,4).ToString() + ".jpg" ;
        }
    }
}
