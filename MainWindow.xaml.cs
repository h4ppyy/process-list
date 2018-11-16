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

using System.Diagnostics;

using System.Collections.Generic;

namespace process
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Process[] processlist = Process.GetProcesses();
            List<TodoItem> items = new List<TodoItem>();

            foreach (Process theprocess in processlist)
            {
                items.Add(new TodoItem() { Title = theprocess.ProcessName, Id = theprocess.Id });
                Console.WriteLine("Process: {0} ID: {1}", theprocess.ProcessName, theprocess.Id);
            }

            ProcessList.ItemsSource = items;
        }

        public class TodoItem
        {
            public string Title { get; set; }
            public int Id { get; set; }
        }

    }
}
