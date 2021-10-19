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

namespace MobilePhones
{
    /// <summary>
    /// Interaction logic for EditPhone.xaml
    /// </summary>
    public partial class EditPhone : Window
    {
        public delegate void UpdatePhoneListClick(Mobile book, int index);
        public event UpdatePhoneListClick Handler;
        public Mobile phoneHolder;
        public int index;
        public EditPhone(Mobile tempPhone, int selected)
        {
            phoneHolder = (Mobile)tempPhone.Clone();
            index = selected;
            InitializeComponent();
        }

        private void editPhone_Click(object sender, RoutedEventArgs e)
        {
            phoneHolder.phoneName = tb_phoneName.Text;
            phoneHolder.manufacture = tb_manufacture.Text;
            phoneHolder.price = tb_price.Text;


            if (Handler != null)
            {
                Handler(phoneHolder, index);
                DialogResult = true;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = phoneHolder;
        }
    }
}
