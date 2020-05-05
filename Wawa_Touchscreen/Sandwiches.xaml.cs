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
        string[] chosenItems;

        public Sandwiches()
        {
            InitializeComponent();
        }

        public void setCList(string[] inChosenItems)
        { 
            chosenItems = inChosenItems;
            foreach (var item in chosenItems)
            {
                Item1.Items.Add(item);
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
 
        }

        private void Sourdough_Sandwich_Click(object sender, RoutedEventArgs e)
        {
            Item1.Items.Add("Sourdough Sandwich ... $5.99");
        }

        private void Flatbread_Click(object sender, RoutedEventArgs e)
        {
            Item1.Items.Add("Flatbread ... $4.99");
        }

        private void Roasted_Chicken_Click(object sender, RoutedEventArgs e)
        {
            Item1.Items.Add("Roasted Chicken ... $3.50");
        }

        private void Quesedilla_Click(object sender, RoutedEventArgs e)
        {
            Item1.Items.Add("Quesedilla ... $5.99");
        }

        private void Burrito_Click(object sender, RoutedEventArgs e)
        {
            Item1.Items.Add("Burrito ... $4.75");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string[] clist = Item1.Items.OfType<string>().ToArray();
            Beverages beverages = new Beverages();
            beverages.Show();
            beverages.setCList(clist);
            this.Visibility = Visibility.Hidden;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string[] clist = Item1.Items.OfType<string>().ToArray();
            Breakfast bre = new Breakfast();
            bre.Show();
            bre.setCList(clist);
            this.Visibility = Visibility.Hidden;
        }

        private void Hoagies_Click(object sender, RoutedEventArgs e)
        {
            Item1.Items.Add("Hoagies ... $4.99");
        }
    }
}
