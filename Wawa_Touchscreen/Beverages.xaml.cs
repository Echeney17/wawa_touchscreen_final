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
    /// Interaction logic for Beverages.xaml
    /// </summary>
    public partial class Beverages : Window
    {
        public Beverages()
        {
            InitializeComponent();
        }

        private void btnFruitSmoothies_Click(object sender, RoutedEventArgs e)
        {
            ltbOrderItems.Items.Add("Fruit Smoothies");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ltbOrderItems.Items.Add("Fruit Smoothies");
        }

        private void btnChaiTeas_Click(object sender, RoutedEventArgs e)
        {
            ltbOrderItems.Items.Add("Chai Teas");
        }

        private void btnLattes_Click(object sender, RoutedEventArgs e)
        {
            ltbOrderItems.Items.Add("Lattes");
        }

        private void btnHotChocolates_Click(object sender, RoutedEventArgs e)
        {
            ltbOrderItems.Items.Add("Hot Chocolates");
        }

        private void btnMacchiatos_Click(object sender, RoutedEventArgs e)
        {
            ltbOrderItems.Items.Add("Macchiatos");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           string s1 = ltbOrderItems.SelectedItems.ToString();
            
           
            passingText = s1;
            Sandwiches san1 = new Sandwiches();
            san1.Show();
            this.Visibility = Visibility.Hidden;
        }

        private void ltbOrderItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnCreamSmoothies_Click(object sender, RoutedEventArgs e)
        {
            ltbOrderItems.Items.Add("Cream Smoothies");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Finished Finished = new Finished();
            Finished.Show();
            this.Visibility = Visibility.Hidden;
        }
    }
}
