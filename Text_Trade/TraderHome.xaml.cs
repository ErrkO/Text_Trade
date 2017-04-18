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
    /// Interaction logic for TraderHome.xaml
    /// </summary>
    public partial class TraderHome : Window
    {
        public TraderHome()
        {
            InitializeComponent();
        }

        private void viewListingsButton_Click(object sender, RoutedEventArgs e)
        {
            Marketplace_View frm = new Marketplace_View();
            frm.Show();
        }

        private void manageListingsButton_Click(object sender, RoutedEventArgs e)
        {
            ManageListings frm = new ManageListings();
            frm.Show();
        }
    }
}
