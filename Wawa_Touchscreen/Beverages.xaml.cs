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
        string[] chosenItems;
        double total;

        public Beverages()
        {
            InitializeComponent();
        }

        public void setTotal(double inTotal)
        {
            total = inTotal;
            MessageBox.Show(total.ToString());
        }

        public void setCList(string[] inChosenItems)
        {
            chosenItems = inChosenItems;
            foreach (var item in chosenItems)
            {
                ltbOrderItems.Items.Add(item);
            }
        }

        private void btnFruitSmoothies_Click(object sender, RoutedEventArgs e)
        {
            ltbOrderItems.Items.Add("Fruit Smoothies");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ltbOrderItems.Items.Add("Fruit Smoothies ... $3.50");
            total = total + 3.50;
        }

        private void btnChaiTeas_Click(object sender, RoutedEventArgs e)
        {
            ltbOrderItems.Items.Add("Chai Teas ... $3.25");
            total = total + 3.25;
        }

        private void btnLattes_Click(object sender, RoutedEventArgs e)
        {
            ltbOrderItems.Items.Add("Lattes ... $3.99");
            total = total + 3.99;
        }

        private void btnHotChocolates_Click(object sender, RoutedEventArgs e)
        {
            ltbOrderItems.Items.Add("Hot Chocolates ... $1.99");
            total = total + 1.99;
        }

        private void btnMacchiatos_Click(object sender, RoutedEventArgs e)
        {
            ltbOrderItems.Items.Add("Macchiatos ... $2.99");
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

        private void ltbOrderItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnCreamSmoothies_Click(object sender, RoutedEventArgs e)
        {
            ltbOrderItems.Items.Add("Cream Smoothies ... $2.50");
            total = total + 2.50;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(total.ToString());
            string[] clist = ltbOrderItems.Items.OfType<string>().ToArray();
            Finished Finished = new Finished();
            Finished.Show();
            Finished.setCList(clist);
            Finished.setTotal(total);
            this.Visibility = Visibility.Hidden;
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            ltbOrderItems.Items.Remove(ltbOrderItems.SelectedItem);
        }
    }
}
