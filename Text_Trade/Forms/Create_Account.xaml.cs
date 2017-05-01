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
    /// Interaction logic for Create_Account.xaml
    /// </summary>
    public partial class Create_Account : Window
    {
        public Create_Account()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Close();
        }

        private void createAccountButton_Click(object sender, RoutedEventArgs e)
        {
            TraderList dblist = new TraderList();
            List<Trader> traderList = dblist.SearchForUser(0);
            Trader newTrader = new Trader(usernameBox.Text, passwordBox.Text, firstNameBox.Text, lastNameBox.Text, emailBox.Text, traderList.Count-1);
            dblist.Add(newTrader);
        }

        
    }
}
