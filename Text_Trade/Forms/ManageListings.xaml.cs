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
using Text_Trade.Forms;

namespace Text_Trade
{
    /// <summary>
    /// Interaction logic for ManageListings.xaml
    /// </summary>
    public partial class ManageListings : Window
    {
        public ManageListings()
        {
            InitializeComponent();

        }

        private void editListingButton_Click(object sender, RoutedEventArgs e)
        {
            Coming_soon frm = new Coming_soon();
            frm.Show();
        }

        private void deleteListingButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.listBox.SelectedIndex != -1)   //meaning there is item selected in listBox
            {
                Trader usr = new Trader();  //how to refer to current Trader?
                Listing li = (Listing)listBox.SelectedItem;
                usr.Sell_List.RemoveFromSellList(li);
                listBox.ItemsSource = usr.Sell_List.sell_list;
            }
        }
    }
}
