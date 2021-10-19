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

namespace Employees.View
{
    /// <summary>
    /// Interaction logic for AddEmployee.xaml
    /// </summary>
    public partial class AddEmployee : Window
    {
        public delegate void AddEmployeeListClick(Employee employee);
        public event AddEmployeeListClick Handler;

        BindingList<Employee> imgList = new BindingList<Employee>();
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void addEmployee_Click(object sender, RoutedEventArgs e)
        {
            if (tb_fullName.Text != "" && tb_address.Text != "" && tb_address.Text != "" && tb_phoneNum.Text != "")
            {
                Employee temp = new Employee()
                {
                    fullName = tb_fullName.Text,
                    avatar = imgList[avatarList.SelectedIndex].avatar,
                    address = tb_address.Text,
                    email = tb_email.Text,
                    phoneNum = tb_phoneNum.Text
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
                Employee temp = new Employee()
                {
                    avatar = "./img/employee/employee" + i.ToString() + ".jpg"
                };

                imgList.Add(temp);
            }
            avatarList.ItemsSource = imgList;
            
        }
    }
}
