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
    /// Interaction logic for Finished.xaml
    /// </summary>
    public partial class Finished : Window
    {
        string[] chosenItems;
        double total;

        public Finished()
        {
            InitializeComponent();
        }

        public void setTotal(double inTotal) {  total = inTotal; }

        public void setCList(string[] inChosenItems)
        {
            chosenItems = inChosenItems;
            foreach (var item in chosenItems)
            {
                finLstBox.Items.Add(item);
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
    
        }


        private void finishCancel_Click(object sender, RoutedEventArgs e)
        {
            string[] clist = finLstBox.Items.OfType<string>().ToArray();
            Beverages beverages = new Beverages();
            beverages.Show();
            beverages.setCList(clist);
            beverages.setTotal(total);
            this.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            finConfirmation.Content = "Thank You For Ordering!";
            lblColdBeverages_Copy.Content = "Your order number is 001";
            totalIs.Content = "Your total is:";
            totalnumber.Content = "$" + total.ToString();
        }
    }
}
