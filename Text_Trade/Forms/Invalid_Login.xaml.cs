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

namespace Text_Trade.Forms
{
    /// <summary>
    /// Interaction logic for Invalid_Login.xaml
    /// </summary>
    public partial class Invalid_Login : Window
    {
        public Invalid_Login()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
