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

namespace Wawa_Touchscreen
{
    /// <summary>
    /// Interaction logic for Sandwiches.xaml
    /// </summary>
    public partial class Sandwiches : Window
    {
        public Sandwiches()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
 
        }

        private void Sourdough_Sandwich_Click(object sender, RoutedEventArgs e)
        {
            Item1.Items.Add("Sourdough Sandwich");
        }

        private void Flatbread_Click(object sender, RoutedEventArgs e)
        {
            Item1.Items.Add("Flatbread");
        }

        private void Roasted_Chicken_Click(object sender, RoutedEventArgs e)
        {
            Item1.Items.Add("Roasted Chicken");
        }

        private void Quesedilla_Click(object sender, RoutedEventArgs e)
        {
            Item1.Items.Add("Quesedilla");
        }

        private void Burrito_Click(object sender, RoutedEventArgs e)
        {
            Item1.Items.Add("Burroto");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Beverages beverages = new Beverages();
            beverages.Show();
            this.Visibility = Visibility.Hidden;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Breakfast bre = new Breakfast();
            bre.Show();
            this.Visibility = Visibility.Hidden;
        }

        private void Hoagies_Click(object sender, RoutedEventArgs e)
        {
            Item1.Items.Add("Hoagies");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           // Item1.Items.Add(Breakfast.passingText);
        }
    }
}
