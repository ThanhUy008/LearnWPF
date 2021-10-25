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

namespace TODO
{
    /// <summary>
    /// Interaction logic for EditTask.xaml
    /// </summary>
    public partial class EditTask : Window
    {
        public delegate void DelegateUpdateTask (Task task, int index);
        public event DelegateUpdateTask Handler;
        public Task taskHolder;
        public int index;
        public EditTask(Task temp, int _index)
        {
            InitializeComponent();
            taskHolder = (Task)temp.Clone();
            index = _index;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                taskHolder.STT = Int32.Parse(tb_order.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            taskHolder.TaskName = tb_name.Text;
            


            if (Handler != null)
            {
                Handler(taskHolder, index);
                DialogResult = true;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = taskHolder;
        }
    }
}
