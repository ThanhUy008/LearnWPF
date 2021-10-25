using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        ObservableCollection<Task> _taskList = new ObservableCollection<Task>();
        public MainWindow()
        {
            InitializeComponent();
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



        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {

            var addScreen = new AddTask();
            addScreen.Handler += addTask;

            if (addScreen.ShowDialog() == true)
            {
                addScreen.Handler -= addTask;
            }
        }
        private void contextMenu_UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            if (taskList.SelectedItem != null)
            {
                var editScreen = new EditTask((Task)taskList.SelectedItem, taskList.SelectedIndex);
                editScreen.Handler += editTask;

                if (editScreen.ShowDialog() == true)
                {
                    editScreen.Handler -= editTask;

                }
            }
        }
        private void contextMenu_DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (taskList.SelectedItem != null)
            {
                var i = taskList.SelectedIndex;

                _taskList.RemoveAt(i);
            }
            //taskList.ItemsSource = null;
            //taskList.ItemsSource = _taskList;
        }
        private void addTask(Task task)
        {
            _taskList.Add(task);
        }
        private void editTask(Task task, int index)
        {
            _taskList[index].STT = task.STT;
            _taskList[index].TaskName = task.TaskName;
        }

    }
}
