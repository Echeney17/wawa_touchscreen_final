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

        public Finished()
        {
            InitializeComponent();
        }

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
            double total = 0;

            foreach (var item in finLstBox.Items)
            {
                if (item.ToString() == "Burrito")
                {
                    total = total + 5.99;
                }
                MessageBox.Show(chosenItems.ToString());
            }
        }

        public void CalculateTotal ()
        {
        }

        private void finishCancel_Click(object sender, RoutedEventArgs e)
        {
            string[] clist = finLstBox.Items.OfType<string>().ToArray();
            Beverages beverages = new Beverages();
            beverages.Show();
            beverages.setCList(clist);
            this.Visibility = Visibility.Hidden;
        }
    }
}
