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

namespace WpfPractice
{
    /// <summary>
    /// Interaction logic for TestWindow.xaml
    /// </summary>
    public partial class TestWindow : Window
    {
        public TestWindow()
        {
            InitializeComponent();
        }

        private void MoveBtn_Click(object sender, RoutedEventArgs e)
        {
            int currentColumn = (int)CustomerListGrid.GetValue(Grid.ColumnProperty);
            int newColumn = currentColumn == 0 ? 2 : 0;
            CustomerListGrid.SetValue(Grid.ColumnProperty, newColumn);
            MoveBtn.Content = newColumn == 0 ? "\uE111" : "\uE112";
        }

        private void AddCustomerBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteCustomerBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
