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
    /// Interaction logic for Listing_View.xaml
    /// </summary>
    public partial class Listing_View : Window
    {
        public Listing_View()
        {
            InitializeComponent();
        }

        private void button_ContactSeller_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_ViewProfile_Click(object sender, RoutedEventArgs e)
        {
            //need to differentiate Mod and Trader view also..
            //For now implement the Trader view
            Trader_Profile_View_Trader frm = new Trader_Profile_View_Trader();
            TraderList tl = new TraderList();
            List<Trader> lt = tl.SearchForUser(textBlock_SellerName.Text);
            frm.DataContext = lt[0];
            frm.Show();
        }

        private void button_AddWatchList_Click(object sender, RoutedEventArgs e)
        {
            Coming_soon frm = new Coming_soon();
            frm.Show();
        }
    }
}
