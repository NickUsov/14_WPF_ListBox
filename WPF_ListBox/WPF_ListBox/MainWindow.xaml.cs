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

namespace WPF_ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Window1 w2;
        ObservableCollection<Employee> list;
        public MainWindow()
        {
            InitializeComponent();
            list = new ObservableCollection<Employee>();
            listBox.ItemsSource = list;
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            Employee emp = new Employee();
            w2 = new Window1(emp);
            w2.ShowDialog();
            if (w2.DialogResult == true)
            {
                list.Add(emp);

            }

        }

        private void btEdite_Click(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                int i = listBox.SelectedIndex;
                Employee emp = (Employee)listBox.SelectedItem;
                w2 = new Window1(emp);
                w2.ShowDialog();
                if (w2.DialogResult == true)
                {
                    list.RemoveAt(i);
                    list.Insert(i, emp);
                }
            }
        }

        private void btDelete_Click(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                int i = listBox.SelectedIndex;
                list.RemoveAt(i);
            }
        }

    }
}
