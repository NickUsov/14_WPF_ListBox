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

namespace WPF_ListBox
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Employee employee;
        public Window1(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            textBox_1.Text = this.employee.Name;
            textBox_2.Text = this.employee.Birth;
            textBox_3.Text = this.employee.Rank;
        }

        private void btOk_Click(object sender, RoutedEventArgs e)
        {
            employee.Name = textBox_1.Text;
            employee.Birth = textBox_2.Text;
            employee.Rank = textBox_3.Text;
            DialogResult = true;
            Close();
        }

        private void btCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
