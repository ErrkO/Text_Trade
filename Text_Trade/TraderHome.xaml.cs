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

        private void viewMarketplaceButtonOnClick(object sender, RoutedEventArgs e)
        {
            MarketplaceView1 frm = new MarketplaceView1();
            frm.Show();
        }
    }
}
