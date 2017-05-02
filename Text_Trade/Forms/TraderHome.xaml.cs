﻿using System;
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
        public TraderHome(Trader trader = null)
        {
            InitializeComponent();

            if (trader != null)
            {

                userLabel.Content = "Welcome " + trader.FirstName + " " + trader.LastName;

            }

        }

        private void viewListingsButton_Click(object sender, RoutedEventArgs e)
        {
            Marketplace_View frm = new Marketplace_View();
            frm.Show();
            this.Close();
        }

        private void manageListingsButton_Click(object sender, RoutedEventArgs e)
        {
            ManageListings frm = new ManageListings();
            frm.Show();
        }

        private void postListingButton_Click(object sender, RoutedEventArgs e)
        {
            Create_Listing frm = new Create_Listing();
            frm.Show();
        }

        private void watchListButton_Click(object sender, RoutedEventArgs e)
        {
            Watch_List frm = new Watch_List();
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
            frm.Show(); //Hm what if schedule already created
        }
    }
}
