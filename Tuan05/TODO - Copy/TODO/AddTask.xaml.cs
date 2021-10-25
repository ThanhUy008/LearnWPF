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
    /// Interaction logic for AddTask.xaml
    /// </summary>
    public partial class AddTask : Window
    {
        public delegate void DelegateAddTask(Task task);
        public event DelegateAddTask Handler;
        public AddTask()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tb_name.Text != "" && tb_order.Text != "")
            {
                try
                {
                    Task temp = new Task()
                    {
                        STT = Int32.Parse(tb_order.Text),
                        TaskName = tb_name.Text
                    };

                    if (Handler != null)
                    {
                        Handler(temp);
                        DialogResult = true;
                    }
                }
                
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
           
        }
    }
}
