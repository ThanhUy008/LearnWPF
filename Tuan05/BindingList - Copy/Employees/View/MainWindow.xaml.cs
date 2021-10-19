using Employees.View;
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

namespace Employees
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        BindingList<Employee> _list = new BindingList<Employee>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Employee Employee1 = new Employee()
            {
                fullName = "Hẻnry McGuyver",
                avatar = "./img/employee/employee1.jpg",
                address = "123, China",
                phoneNum = "91201230",
                email = "HenMc@email.com"
            };
            Employee Employee2 = new Employee()
            {
                fullName = "Bittot Chariot",
                avatar = "./img/employee/employee2.jpg",
                address = "America",
                phoneNum = "9123941",
                email = "BitCh@email.com"
            };
            Employee Employee3 = new Employee()
            {
                fullName = "Hong Kong",
                avatar = "./img/employee/employee3.jpg",
                address = "Hong Kong",
                phoneNum = "24012421",
                email = "HonKo@email.com"
            };
            Employee Employee4 = new Employee()
            {
                fullName = "Nulelar Tempda",
                avatar = "./img/employee/employee4.jpg",
                address = "Depressed address",
                phoneNum = "2212321",
                email = "NulTe@email.com"
            };
            Employee Employee5 = new Employee()
            {
                fullName = "Pegasus",
                avatar = "./img/employee/employee5.jpg",
                address = "VietNam",
                phoneNum = "21541231",
                email = "provjpHCM123@email.com"
            };
            Employee Employee6 = new Employee()
            {
                fullName = "Tendo Tekkai",
                avatar = "./img/employee/employee6.jpg",
                address = "Afica",
                phoneNum = "2102213",
                email = "TenTe@email.com"
            };
            Employee Employee7 = new Employee()
            {
                fullName = "IThorn Thomas",
                avatar = "./img/employee/employee7.jpg",
                address = "Ligma",
                phoneNum = "21322130",
                email = "Thorny@email.com"
            };
            Employee Employee8 = new Employee()
            {
                fullName = "LMao LMFao",
                avatar = "./img/employee/employee8.jpg",
                address = "China",
                phoneNum = "2101202412",
                email = "LMLM@email.com"
            };
            Employee Employee9 = new Employee()
            {
                fullName = "Tekkai",
                avatar = "./img/employee/employee9.jpg",
                address = "Korea",
                phoneNum = "20200213123",
                email = "tekK@email.com"
            };
            Employee Employee10 = new Employee()
            {
                fullName = "Tulado",
                avatar = "./img/employee/employee10.jpg",
                address = "China",
                phoneNum = "20222130",
                email = "template@email.com"
            };
            _list.Add(Employee1);
            _list.Add(Employee2);
            _list.Add(Employee3);
            _list.Add(Employee4);
            _list.Add(Employee5);
            _list.Add(Employee6);
            _list.Add(Employee7);
            _list.Add(Employee8);
            _list.Add(Employee9);
            _list.Add(Employee10);
            employeeList.ItemsSource = _list;
        }
        private void editEmployee(Employee employee, int index)
        {
            _list[index].fullName = employee.fullName;
            _list[index].address = employee.address;
            _list[index].email = employee.email;
            _list[index].phoneNum = employee.phoneNum;

        }
        private void contextMenu_EditClick(object sender, RoutedEventArgs e)
        {
            if (employeeList.SelectedItem != null)
            {
                var editScreen = new EditEmployee((Employee)employeeList.SelectedItem, employeeList.SelectedIndex);
                editScreen.Handler += editEmployee;

                if (editScreen.ShowDialog() == true)
                {
                    editScreen.Handler -= editEmployee;

                }
            }
        }

        private void contextMenu_DeleteClick(object sender, RoutedEventArgs e)
        {
            if (employeeList.SelectedItem != null)
            {
                var i = employeeList.SelectedIndex;
                _list.RemoveAt(i);
            }
        }
        private void addEmployee(Employee employee)
        {
            _list.Add(employee);

        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var addScreen = new AddEmployee();
            addScreen.Handler += addEmployee;

            if (addScreen.ShowDialog() == true)
            {
                addScreen.Handler -= addEmployee;

            }
        }
    }
}
