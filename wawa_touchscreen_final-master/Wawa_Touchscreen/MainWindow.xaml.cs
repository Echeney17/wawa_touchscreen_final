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

namespace Wawa_Touchscreen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if (Items.Items.Count == 0)
            {
                confirm.Visibility = Visibility.Hidden;
                cancel.Visibility = Visibility.Hidden;
                Items_Label.Visibility = Visibility.Hidden;
                Items.Visibility = Visibility.Hidden;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Sandwiches san1 = new Sandwiches();
            san1.Show();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Beverages beverages = new Beverages();
            beverages.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Breakfast breakfast = new Breakfast();
            breakfast.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Sandwiches san1 = new Sandwiches();
            san1.Show();
        }

        
        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {

        }
        private void confirm_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Total price is $ " + Items.Items.Count + 1 * 2);
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        

        private void Touch_Click(object sender, RoutedEventArgs e)
        {
            Breakfast breakfast = new Breakfast();
            breakfast.Show();
            this.Visibility = Visibility.Hidden;
        }
    }
}
