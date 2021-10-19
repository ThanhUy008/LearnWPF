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

namespace Employees.View
{
    /// <summary>
    /// Interaction logic for EditEmployee.xaml
    /// </summary>
    public partial class EditEmployee : Window
    {
        public delegate void UpdateEmployeeListClick(Employee employee, int index);
        public event UpdateEmployeeListClick Handler;
        public Employee employeeHolder;
        public int index;
        public EditEmployee(Employee tempEmployee,int selected)
        {
            employeeHolder = (Employee)tempEmployee.Clone();
            index = selected;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = employeeHolder;
        }

        private void editPhone_Click(object sender, RoutedEventArgs e)
        {
            employeeHolder.fullName = tb_fullName.Text;
            employeeHolder.address = tb_address.Text;
            employeeHolder.email = tb_address.Text;
            employeeHolder.phoneNum = tb_phoneNum.Text;


            if (Handler != null)
            {
                Handler(employeeHolder, index);
                DialogResult = true;
            }
        }
    }
}
