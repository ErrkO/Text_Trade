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
    /// Interaction logic for TraderHome.xaml
    /// </summary>
    public partial class TraderHome : Window
    {

        Trader currtrad;

        public TraderHome(Trader trader = null)
        {
            InitializeComponent();

            if (trader != null)
            {

                userLabel.Content = "Welcome: " + trader.FirstName + " " + trader.LastName;

                currtrad = trader;

            }

        }

        private void viewListingsButton_Click(object sender, RoutedEventArgs e)
        {
            Marketplace_View frm = new Marketplace_View(currtrad);
            frm.Show();
            this.Close();
        }

        private void manageListingsButton_Click(object sender, RoutedEventArgs e)
        {
            ManageListings frm = new ManageListings(currtrad);
            frm.Show();
        }

        private void postListingButton_Click(object sender, RoutedEventArgs e)
        {
            Create_Listing frm = new Create_Listing(currtrad);
            frm.Show();
        }

        private void watchListButton_Click(object sender, RoutedEventArgs e)
        {
            Coming_soon frm = new Coming_soon();
            frm.Show();
        }

        private void logOutButton_Click(object sender, RoutedEventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Close();
        }

        private void manageProfileButton_Click(object sender, RoutedEventArgs e)
        {
            Coming_soon frm = new Coming_soon();
            frm.Show();
        }

        private void manageScheduleButton_Click(object sender, RoutedEventArgs e)
        {
            Manage_Schedule frm = new Manage_Schedule();  
            //if schedule already existed
            // code
            // if not, show blank form
            frm.Show(); 
        }
    }
}
