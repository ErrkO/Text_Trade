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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, RoutedEventArgs e)
        {
            Create_Account frm = new Create_Account();
            frm.Show();
            this.Close();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            Trader login = new Trader(usernameTextBox.Text, passwordTextBox.Text);
            login.UserName = usernameTextBox.Text;
            login.Password = passwordTextBox.Text;
            TraderList userlist = new TraderList();
            userlist.CreateList();     

          //  userlist.SearchForUser(); //To be continued when SearchForUser() is implemented
        }
    }
}
