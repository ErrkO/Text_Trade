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
    /// Interaction logic for Create_Listing.xaml
    /// </summary>
    public partial class Create_Listing : Window
    {

        Trader currtrad;

        public Create_Listing(Trader trader = null)
        {
            InitializeComponent();
            comboBox_condition.ItemsSource = Enum.GetValues(typeof(Condition)); //Binding Items of combobox with Enum values

            if (trader != null)
            {

                currtrad = trader;

            }

        }

        private void button_createListing_Click(object sender, RoutedEventArgs e)
        {
            string t = textBox_bookTitle.Text;
            string a = textBox_authors.Text;
            string ed = textBox_edition.Text;
            string i = textBox_isbn.Text;
            string last = " ";

            string[] strArray = comboBox_cC.SelectedItem.ToString().Split();    //to get 4 characters course code
            Course course = new Course(strArray[1].Trim(), textBox_cL.Text);    //since ToString() gives a bunch of gibberish
            Condition cond = (Condition)comboBox_condition.SelectedItem;         

            double p = Convert.ToDouble(textBox_price.Text);
            string des = textBox_description.Text;
            Listing l = new Listing(t, a, ed, i, course, cond, p, last,des);
            l.CreateListing(currtrad.Trader_id);

            TraderHome frm = new TraderHome(currtrad);
            frm.Show();
            this.Close();
           
            

        }
    }
}
