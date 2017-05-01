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
    /// Interaction logic for View_UserList.xaml
    /// </summary>
    public partial class View_UserList : Window
    {
        public View_UserList()
        {
            InitializeComponent();
        }

        private void viewButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void View_UserList_Loaded(object sender, RoutedEventArgs e)
        {
            List<Trader> userList = new List<Trader>();
            TraderList dblist = new TraderList();
            userList = dblist.SearchForUser(0);

            listBox_reportList.ItemsSource = userList;
        }
    }
}
