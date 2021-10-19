using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace Books
{
    
    
    /// <summary>
    /// Interaction logic for AddBook.xaml
    /// </summary>
    public partial class AddBook : Window
    {
        public delegate void AddBookListClick(Book book);
        public event AddBookListClick Handler;
        
        BindingList<Book> imgList = new BindingList<Book>();
        public AddBook()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            for(int i = 1; i < 11;i++)
            {
                Book temp = new Book()
                {
                    coverImg = "./img/book/book" + i.ToString() + ".jpg"
                };

                imgList.Add(temp);
            }
            coverList.ItemsSource = imgList;
        }

        private void addBook_Click(object sender, RoutedEventArgs e)
        {
            if (tb_bookName.Text != "" && tb_author.Text != "" && tb_publicYear.Text != "")
            {
                Book temp = new Book()
                {
                    bookName = tb_bookName.Text,
                    coverImg = imgList[coverList.SelectedIndex].coverImg,
                    author = tb_author.Text,
                    publicYear = tb_publicYear.Text
                };
                if (Handler != null)
                {
                    Handler(temp);
                    DialogResult = true;
                }
            }
        }
    }
}
