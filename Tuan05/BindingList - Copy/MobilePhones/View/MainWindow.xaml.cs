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

namespace MobilePhones
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        BindingList<Mobile> _list = new BindingList<Mobile>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Mobile Mobile1 = new Mobile()
            {
                phoneName = "Trask Phone",
                phoneImg = "./img/mobile/phone1.jpg",
                manufacture = "China",
                price = "200000"
            };
            Mobile Mobile2 = new Mobile()
            {
                phoneName = "Iphone 10",
                phoneImg = "./img/mobile/phone2.jpg",
                manufacture = "America",
                price = "200000000"
            };
            Mobile Mobile3 = new Mobile()
            {
                phoneName = "ViVo 123",
                phoneImg = "./img/mobile/phone3.jpg",
                manufacture = "Hong Kong",
                price = "240010000"
            };
            Mobile Mobile4 = new Mobile()
            {
                phoneName = "Nulelar 123",
                phoneImg = "./img/mobile/phone4.jpg",
                manufacture = "Depressed manufacture",
                price = "22000000"
            };
            Mobile Mobile5 = new Mobile()
            {
                phoneName = "Pegasus",
                phoneImg = "./img/mobile/phone5.jpg",
                manufacture = "VietNam",
                price = "215400000"
            };
            Mobile Mobile6 = new Mobile()
            {
                phoneName = "Mobile",
                phoneImg = "./img/mobile/phone6.jpg",
                manufacture = "Afica",
                price = "210200000"
            };
            Mobile Mobile7 = new Mobile()
            {
                phoneName = "IThorn6",
                phoneImg = "./img/mobile/phone7.jpg",
                manufacture = "Ligma",
                price = "21320000"
            };
            Mobile Mobile8 = new Mobile()
            {
                phoneName = "Iphone12",
                phoneImg = "./img/mobile/phone8.jpg",
                manufacture = "China",
                price = "210120240000"
            };
            Mobile Mobile9 = new Mobile()
            {
                phoneName = "Nokia",
                phoneImg = "./img/mobile/phone9.jpg",
                manufacture = "Korea",
                price = "2020000"
            };
            Mobile Mobile10 = new Mobile()
            {
                phoneName = "Tulado",
                phoneImg = "./img/mobile/phone10.jpg",
                manufacture = "China",
                price = "2022000"
            };
            _list.Add(Mobile1);
            _list.Add(Mobile2);
            _list.Add(Mobile3);
            _list.Add(Mobile4);
            _list.Add(Mobile5);
            _list.Add(Mobile6);
            _list.Add(Mobile7);
            _list.Add(Mobile8);
            _list.Add(Mobile9);
            _list.Add(Mobile10);
            phoneList.ItemsSource = _list;
        }
        private void addPhone(Mobile phone)
        {
            _list.Add(phone);

        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var addScreen = new AddPhone();
            addScreen.Handler += addPhone;

            if (addScreen.ShowDialog() == true)
            {
                addScreen.Handler -= addPhone;

            }
        }
        private void editPhone(Mobile phone, int index)
        {
            _list[index].phoneName = phone.phoneName;
            _list[index].manufacture = phone.manufacture;
            _list[index].price = phone.price;

        }
        private void contextMenu_EditClick(object sender, RoutedEventArgs e)
        {

            if (phoneList.SelectedItem != null)
            {
                var editScreen = new EditPhone((Mobile)phoneList.SelectedItem, phoneList.SelectedIndex);
                editScreen.Handler += editPhone;

                if (editScreen.ShowDialog() == true)
                {
                    editScreen.Handler -= editPhone;

                }
            }
        }

        private void contextMenu_DeleteClick(object sender, RoutedEventArgs e)
        {
            if (phoneList.SelectedItem != null)
            {
                var i = phoneList.SelectedIndex;
                _list.RemoveAt(i);
            }
        }
    }
}
