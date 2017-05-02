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

namespace Text_Trade
{
    /// <summary>
    /// Interaction logic for Moderator_Home.xaml
    /// </summary>
    public partial class Moderator_Home : Window
    {
        public Moderator_Home(Moderator currentUser = null)
        {
            InitializeComponent();

            if(currentUser != null)
            {
                userLabel.Content = "Welcome: " + currentUser.FirstName + " " + currentUser.LastName;
            }
        }

        private void viewUserListButton_Click(object sender, RoutedEventArgs e)
        {
            View_UserList frm = new View_UserList();
            frm.Show();
        }

        private void viewUserReportsButton_Click(object sender, RoutedEventArgs e)
        {
            View_Reports_Users frm = new View_Reports_Users();
            frm.Show();
        }

        private void searchMarketplaceButton_Click(object sender, RoutedEventArgs e)
        {
            Marketplace_View frm = new Marketplace_View();
            frm.Show();
        }

        private void viewListingReportsButton_Click(object sender, RoutedEventArgs e)
        {
            View_Reports_Listings frm = new View_Reports_Listings();
            frm.Show();
        }

        private void viewBanListButton_Click(object sender, RoutedEventArgs e)
        {
            View_BanList frm = new View_BanList();
            frm.Show();
        }

        private void viewSystemStatsButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void logOutButton_Click(object sender, RoutedEventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Close();
        }
    }
}
