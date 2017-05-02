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

        Trader currtrad;
        List<Listing> listings;
        DataBase db;

        public ManageListings(Trader trader = null)
        {

            db = new DataBase();

            List<Listing> templistings = new List<Listing>();

            InitializeComponent();

            Binding title = new Binding();
            Binding author = new Binding();
            Binding edition = new Binding();
            Binding price = new Binding();

            if (trader != null)
            {

                this.currtrad = trader;

                listings = db.SearchForListing("trader_id", Convert.ToString(currtrad.Trader_id));

                ActiveListingsBox.DataContext = listings;

                //ActiveListingsBox.ItemsSource(listings);

                //foreach (Listing listing in listings)
                //{

                //    //ActiveListingsBox.SetBinding(ListBox.ItemsSourceProperty, title);
                //    //ActiveListingsBox.SetBinding(ListBox.ItemsSourceProperty, author);
                //    //ActiveListingsBox.SetBinding(ListBox.ItemsSourceProperty, edition);
                //    //ActiveListingsBox.SetBinding(ListBox.ItemsSourceProperty, price);

                //    ActiveListingsBox.ItemsSource(listings);

                //}

            }

        }

        private void editListingButton_Click(object sender, RoutedEventArgs e)
        {
            Coming_soon frm = new Coming_soon();
            frm.Show();
        }

        private void deleteListingButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.ActiveListingsBox.SelectedIndex != -1)   //meaning there is item selected in listBox
            {
                Trader usr = new Trader();  //how to refer to current Trader?
                Listing li = (Listing)ActiveListingsBox.SelectedItem;
                usr.Sell_List.RemoveFromSellList(li);
                ActiveListingsBox.ItemsSource = usr.Sell_List.sell_list;
            }
        }
    }
}
