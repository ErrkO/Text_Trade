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
    /// Interaction logic for Create_LIsting.xaml
    /// </summary>
    public partial class Create_Listing : Window
    {
        public Create_Listing()
        {
            InitializeComponent();
        }

        private void button_createListing_Click(object sender, RoutedEventArgs e)
        {
            string t = textBox_bookTitle.Text;
            string a = textBox_authors.Text;
            string ed = textBox_edition.Text;
            string i = textBox_isbn.Text;
            Course course = new Course(comboBox_cC.SelectedItem.ToString(), textBox_cL.Text);
            Condition cond = (Condition)comboBox_condition.SelectedValue;
            double p = Convert.ToDouble(textBox_price.Text);
            string des = textBox_description.Text;
            Listing l = new Listing(t, a, ed, i, course, cond, p, des);
        }
    }
}
