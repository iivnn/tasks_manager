using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TasksManagerLib;

namespace TasksManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<TasksManagerLib.Task> _tasks = new List<TasksManagerLib.Task>();
        public MainWindow()
        {
            InitializeComponent();
            ApllyControlsRules();



            this.tasksGrid.ItemsSource = _tasks;
            this.tasksGrid.RowDetailsTemplate = this.FindResource("myTaskTemplate") as DataTemplate;

            //this.tasksGrid.LoadingRowDetails += TasksGrid_LoadingRowDetails;
            _tasks.Add(new TasksManagerLib.Task()
            {
                Description = "Teste",
                SubTasks = new List<SubTask>() { new SubTask() { Description = "alo" } }
            });
        }

        //private void TasksGrid_LoadingRowDetails(object? sender, DataGridRowDetailsEventArgs e)
        //{
        //    e.DetailsElement.DataContext = ((TasksManagerLib.Task)(e.Row.Item)).SubTasks;
        //}

        private void ApllyControlsRules()
        {
            this.tasksGrid.RowDetailsVisibilityMode = DataGridRowDetailsVisibilityMode.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("teste");
        }
    }
}
