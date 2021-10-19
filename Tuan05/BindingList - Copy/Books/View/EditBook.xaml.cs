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
using System.Windows.Shapes;

namespace Books
{
    
    /// <summary>
    /// Interaction logic for EditBook.xaml
    /// </summary>
    public partial class EditBook : Window
    {
        public delegate void UpdateBookListClick(Book book,int index);
        public event UpdateBookListClick Handler;
        public Book bookHolder;
        public int index;
        public EditBook(Book tempBook,int selected)
        {
            bookHolder = (Book)tempBook.Clone();
            index = selected;
            
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = bookHolder;
        }

        private void editBook_Click(object sender, RoutedEventArgs e)
        {

            bookHolder.bookName = tb_bookName.Text;
            bookHolder.author = tb_author.Text;
            bookHolder.publicYear = tb_publicYear.Text;
           

            if (Handler != null)
            {
                Handler(bookHolder, index);
                DialogResult = true;
            }
            
        }
    }
}
