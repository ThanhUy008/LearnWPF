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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TODO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Task> _taskList = new List<Task>();
        public delegate void TaskEdit(Task task);
        public event TaskEdit taskEdited;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void contextMenu_UpdateBtn_Click(object sender, RoutedEventArgs e)
        {

        }
        
        
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Task task1 = new Task()
            {
                STT = 1,
                TaskName = "Cut the grass"
            };
            Task task2 = new Task()
            {
                STT = 2,
                TaskName = "Pick some milk"
            };
            Task task3 = new Task()
            {
                STT = 3,
                TaskName = "Buy some eggs"
            };
            _taskList.Add(task1);
            _taskList.Add(task2);
            _taskList.Add(task3);
            taskList.ItemsSource = _taskList;
        }
    }
}
