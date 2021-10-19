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

namespace MobilePhones
{
    /// <summary>
    /// Interaction logic for AddPhone.xaml
    /// </summary>
    public partial class AddPhone : Window
    {
        public delegate void AddPhoneListClick(Mobile book);
        public event AddPhoneListClick Handler;

        BindingList<Mobile> imgList = new BindingList<Mobile>();
        public AddPhone()
        {
            InitializeComponent();
        }

        private void addPhone_Click(object sender, RoutedEventArgs e)
        {
            if (tb_phoneName.Text != "" && tb_manufacture.Text != "" && tb_price.Text != "")
            {
                Mobile temp = new Mobile()
                {
                    phoneName = tb_phoneName.Text,
                    phoneImg = imgList[phoneList.SelectedIndex].phoneImg,
                    manufacture = tb_manufacture.Text,
                    price = tb_price.Text
                };
                if (Handler != null)
                {
                    Handler(temp);
                    DialogResult = true;
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 1; i < 11; i++)
            {
                Mobile temp = new Mobile()
                {
                    phoneImg = "./img/mobile/phone" + i.ToString() + ".jpg"
                };

                imgList.Add(temp);
            }
            phoneList.ItemsSource = imgList;
        }
    }
}
