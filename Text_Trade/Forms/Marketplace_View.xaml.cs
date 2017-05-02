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
    /// Interaction logic for MarketplaceView1.xaml
    /// </summary>
    public partial class Marketplace_View : Window
    {
        public Marketplace_View()
        {
            InitializeComponent();
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            TraderHome frm = new TraderHome();
            frm.Show();
            this.Close();
        }

        private void logOutButton_Click(object sender, RoutedEventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Close();
        }

        private void Marketplace_View_Load(object sender, RoutedEventArgs e)    //are these parameters necessary?
        {
            Marketplace marketView = new Marketplace();
            //List<Listing> listings = new List<Listing>();

            marketView.SearchAll();

            for( int i = 0; i < marketView.listings.Count; i++)
            {
                resultsListBox.Items.Add(marketView.listings.ElementAt(i));
            }
        }

        private void button_filterResults_Click(object sender, RoutedEventArgs e)
        {
            Coming_soon frm = new Coming_soon();
            frm.Show();
        }

        private void button_search_Click(object sender, RoutedEventArgs e)
        {
            Marketplace mkt = new Marketplace();
            if (radioButton_byTitle.IsChecked == true)
            {
                mkt.SearchByBookTitle(textBox_search.Text);
                //then how to display listings
                //copy Seth's code from Marketplace_View_Load() not sureif works
                /* for (int i = 0; i < mkt.listings.Count; i++)
                 {
                     resultsListBox.Items.Add(mkt.listings.ElementAt(i));
                 }*/
                resultsListBox.ItemsSource = mkt.listings;
            }

            if (radioButton_byAuthor.IsChecked == true)
            {
                mkt.SearchByAuthor(textBox_search.Text);
                //then how to display listings
               /* for (int i = 0; i < mkt.listings.Count; i++)
                {
                    resultsListBox.Items.Add(mkt.listings.ElementAt(i));
                }*/
            }

            if (radioButton_byCourse.IsChecked == true)
            {
                string[] strArray = textBox_search.Text.Split();
                mkt.SearchByCourse(strArray[0].Trim(), strArray[1].Trim());
                //then how to display listings
              /*  for (int i = 0; i < mkt.listings.Count; i++)
                {
                    resultsListBox.Items.Add(mkt.listings.ElementAt(i));
                }*/
            }

            if (radioButton_byISBN.IsChecked == true)
            {
                mkt.SearchByISBN(textBox_search.Text);
                //then how to display listings
               /* for (int i = 0; i < mkt.listings.Count; i++)
                {
                    resultsListBox.Items.Add(mkt.listings.ElementAt(i));
                }*/
            }

            resultsListBox.ItemsSource = mkt.listings;
        }

        private void resultListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Listing li = (Listing)resultsListBox.SelectedItem;
            Listing_View lv = new Listing_View();
            lv.DataContext = li;
            TraderList tl = new TraderList();
            List<Trader> lt = tl.SearchForUser(li.Trader_id);
            lv.textBlock_SellerName.DataContext = lt[0];
            lv.Show();
        }
    }
}
