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
    /// Interaction logic for Breakfast.xaml
    /// </summary>
    public partial class Breakfast : Window
    {
        public static string passingText;
        public Breakfast()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnOatmeal_Click(object sender, RoutedEventArgs e)
        {
            ltbOrderItems.Items.Add("Oatmeal");
        }

        private void btnBreakfastBurrito_Click(object sender, RoutedEventArgs e)
        {
            ltbOrderItems.Items.Add("Breakfast Burrito");
        }

        private void btnBreakfastBowl_Click(object sender, RoutedEventArgs e)
        {
            ltbOrderItems.Items.Add("Breakfast Bowl");
        }

        private void btnBreakfastWaffleSandwich_Click(object sender, RoutedEventArgs e)
        {
            ltbOrderItems.Items.Add("Breakfast Waffle Sandwich");
        }

        private void btnBreakfastCroissant_Click(object sender, RoutedEventArgs e)
        {
            ltbOrderItems.Items.Add("Breakfast Croissant");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string s1 = ltbOrderItems.SelectedItem.ToString();
            passingText = s1;

            Sandwiches san1 = new Sandwiches();
            san1.Show();
            


            this.Visibility = Visibility.Hidden;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Visibility = Visibility.Hidden;
        }

        private void btnBreakfastBagel_Click(object sender, RoutedEventArgs e)
        {
            ltbOrderItems.Items.Add("Breakfast Bagel");
        }
    }
}
