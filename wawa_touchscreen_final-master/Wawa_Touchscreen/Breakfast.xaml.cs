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
        string[] chosenItems;
        double total;

        public void setTotal(double inTotal) {  total = inTotal; }

        public void setCList(string[] inChosenItems)
        {
            chosenItems = inChosenItems;
            foreach (var item in chosenItems)
            {
                ltbOrderItems.Items.Add(item);
            }
        }
        public Breakfast()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnOatmeal_Click(object sender, RoutedEventArgs e)
        {
            ltbOrderItems.Items.Add("Oatmeal ... $1.99");
            total = total + 1.99;
        }

        private void btnBreakfastBurrito_Click(object sender, RoutedEventArgs e)
        {
            ltbOrderItems.Items.Add("Breakfast Burrito ... $2.99");
            total = total + 2.99;
        }

        private void btnBreakfastBowl_Click(object sender, RoutedEventArgs e)
        {
            ltbOrderItems.Items.Add("Breakfast Bowl ... $3.99");
            total = total + 3.99;
        }

        private void btnBreakfastWaffleSandwich_Click(object sender, RoutedEventArgs e)
        {
            ltbOrderItems.Items.Add("Breakfast Waffle Sandwich ... $3.75");
            total = total + 3.75;
        }

        private void btnBreakfastCroissant_Click(object sender, RoutedEventArgs e)
        {
            ltbOrderItems.Items.Add("Breakfast Croissant ... $2.99");
            total = total + 2.99;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string[] clist = ltbOrderItems.Items.OfType<string>().ToArray();       
            Sandwiches san1 = new Sandwiches();
            san1.Show();
            san1.setCList(clist);
            san1.setTotal(total);
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
            ltbOrderItems.Items.Add("Breakfast Bagel ... $2.25");
            total = total + 2.25;
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in ltbOrderItems.SelectedItems)
            {

                String removeItem = item.ToString();

                if (removeItem == "Oatmeal ... $1.99")
                {
                    total = total - 1.99;
                }
                if (removeItem == "Breakfast Burrito ... $2.99")
                {
                    total = total - 2.99;
                }
                if (removeItem == "Breakfast Bowl ... $3.99")
                {
                    total = total - 3.99;
                }
                if (removeItem == "Breakfast Waffle Sandwich ... $4.99")
                {
                    total = total - 4.99;
                }
                if (removeItem == "Breakfast Croissant ... $2.99")
                {
                    total = total - 2.99;
                }
                if (removeItem == "Breakfast Bagel ... $2.25")
                {
                    total = total - 2.25;
                }

            }

            ltbOrderItems.Items.Remove(ltbOrderItems.SelectedItem);
        }
    }
}
    
