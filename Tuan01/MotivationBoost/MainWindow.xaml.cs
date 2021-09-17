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

namespace Tuan01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> quotesList = new List<string>() { "Tough times don’t last. Tough people do. \n -  Robert H. Schuller", "Pain is temporary. Quitting lasts forever. \n -  Lance Armstrong", "A problem is a chance for you to do your best. \n -  Duke Ellington", "Motivation is what gets you started. Habit is what keeps you going. \n -  Jim Rohn", "A little progress each day adds up to big results. \n -  Satya Nani", "If you get tired, learn to rest, not quit. \n -  Unknown", "Success consists of getting up just one more time than you fall. \n -  Oliver Goldsmith", "Don’t stop until you’re proud. \n -  Unknown", "Focus on your goal. Don’t look in any direction but ahead. \n -  Unknown", "Courage is one step ahead of fear. \n -  Coleman Young", "Don’t wish it were easier. Wish you were better. \n -  Jim Rohn", "I find that the harder I work, the more luck I seem to have. \n -  Thomas Jefferson", "Success is the sum of small efforts repeated day-in and day-out. \n -  Robert Collier", "We must embrace pain and burn it as fuel for our journey. \n -  Kenji Miyazawa" };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Generate_Click(object sender, RoutedEventArgs e)
        {
            var rand = new Random();
            int picNum;

            picNum = rand.Next(1, 14);

            var bitmap = new BitmapImage(new Uri($"/images/{picNum.ToString()}.jpg", UriKind.Relative));
            imgName.Source = bitmap;
            tb_Quotes.Text = quotesList.ElementAt(picNum);
        }
    } 
}
