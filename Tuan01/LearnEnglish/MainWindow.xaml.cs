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

namespace LearnEnglish
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> wordList = new List<string>() {"Owl","Crow","Pigeon","Hawk","Penguin","Parrot","Seagull","Swan","Ostrich","Sparrow","Peacock" };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Change_Click(object sender, RoutedEventArgs e)
        {
            var rand = new Random();
            int picNum;

            picNum = rand.Next(1, 11);

            var bitmap = new BitmapImage(new Uri($"/images/{picNum.ToString()}.jpg", UriKind.Relative));
            img_Learn.Source = bitmap;
            tb_Word.Text = wordList.ElementAt(picNum);
        }
    }
}
