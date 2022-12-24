using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace TaskManagerHW
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<ProcessObject> processes = new List<ProcessObject>();
        public MainWindow()
        {
            InitializeComponent();



            var allProcesses = Process.GetProcesses().ToList();
            foreach (var process in allProcesses)
            {
                processes.Add(new ProcessObject(process));
            };
            nameDataG.ItemsSource = processes;

        }

        private void nameDataG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var process = nameDataG.SelectedItem as ProcessObject;
            txtb.Text = process.ProcessName;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = txtb.Text;
            var newProcess = Process.Start(name);
            processes.Add(new ProcessObject(newProcess));
        }

        private void End_Click(object sender, RoutedEventArgs e)
        {
            var process = nameDataG.SelectedItem as ProcessObject;
            foreach (var p in processes)
            {
                if (p.ProcessName == process.ProcessName)
                {
                    p.Proccess.Kill();
                    processes.Remove(p);
                }
                else
                {
                    MessageBox.Show("Process not found");
                }
            }

        }
    }
}
