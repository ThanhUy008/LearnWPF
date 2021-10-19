using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Books
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : RibbonWindow
    {
        BindingList<Book> _list = new BindingList<Book>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Book book1 = new Book()
            {
                bookName = "Book of triolgy 1",
                coverImg = "./img/book/book1.jpg",
                author = "RealName NotFake",
                publicYear = "2000"
            };
            Book book2 = new Book()
            {
                bookName = "Bonk of Natial",
                coverImg = "./img/book/book2.jpg",
                author = "Henri Richard",
                publicYear = "2000"
            };
            Book book3 = new Book()
            {
                bookName = "What is a joke",
                coverImg = "./img/book/book3.jpg",
                author = "Dinglong BonkBonk",
                publicYear = "2004"
            };
            Book book4 = new Book()
            {
                bookName = "Ten of thounsands way to die",
                coverImg = "./img/book/book4.jpg",
                author = "Depressed Author",
                publicYear = "2002"
            };
            Book book5 = new Book()
            {
                bookName = "Pegasus",
                coverImg = "./img/book/book5.jpg",
                author = "Tinker Bell",
                publicYear = "2010"
            };
            Book book6 = new Book()
            {
                bookName = "Book of triolgy 2",
                coverImg = "./img/book/book6.jpg",
                author = "RealName NotFake",
                publicYear = "2012"
            };
            Book book7 = new Book()
            {
                bookName = "Book of triolgy 3",
                coverImg = "./img/book/book7.jpg",
                author = "RealName NotFake",
                publicYear = "2013"
            };
            Book book8 = new Book()
            {
                bookName = "Rista The Killer Doll",
                coverImg = "./img/book/book8.jpg",
                author = "Henry McName",
                publicYear = "2011"
            };
            Book book9 = new Book()
            {
                bookName = "Book of triolgy 4",
                coverImg = "./img/book/book9.jpg",
                author = "RealName NotFake",
                publicYear = "2020"
            };
            Book book10 = new Book()
            {
                bookName = "Rista 2 : the return of Rista",
                coverImg = "./img/book/book10.jpg",
                author = "Henry McName",
                publicYear = "2022"
            };
            _list.Add(book1);
            _list.Add(book2);
            _list.Add(book3);
            _list.Add(book4);
            _list.Add(book5);
            _list.Add(book6);
            _list.Add(book7);
            _list.Add(book8);
            _list.Add(book9);
            _list.Add(book10);
            bookList.ItemsSource = _list;
        }

        private void contextMenu_DeleteClick(object sender, RoutedEventArgs e)
        {
            if (bookList.SelectedItem != null)
            {
                var i = bookList.SelectedIndex;
                _list.RemoveAt(i);
            }
        }
        private void editBook(Book book,int index)
        {
            _list[index].bookName = book.bookName;
            _list[index].author = book.author;
            _list[index].publicYear = book.publicYear;

        }
        private void addBook(Book book)
        {
            _list.Add(book);

        }
        private void contextMenu_EditClick(object sender, RoutedEventArgs e)
        {
            if (bookList.SelectedItem != null)
            {
                var editScreen = new EditBook((Book)bookList.SelectedItem, bookList.SelectedIndex);
                editScreen.Handler += editBook;

                if (editScreen.ShowDialog() == true)
                {
                    editScreen.Handler -= editBook;

                }
            }
            
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var addScreen = new AddBook();
            addScreen.Handler += addBook;

            if (addScreen.ShowDialog() == true)
            {
                addScreen.Handler -= addBook;

            }
        }
    }
}
