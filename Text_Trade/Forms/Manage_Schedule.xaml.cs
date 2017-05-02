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
    /// Interaction logic for Manage_Schedule.xaml
    /// </summary>
    public partial class Manage_Schedule : Window
    {
        public Manage_Schedule()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_save_Click(object sender, RoutedEventArgs e)    //this iswhen create schedule for first time
        {
            string cCode, cLevel;
            string[] strArray;
            Trader usr = new Trader();  //hmm not sure how to refer the current user

            //Since I'm not sure how to loop through a list of comboboxes so just do it this way
            if (comboBox_CC1.SelectedItem != null)  //if  there is selection
            {
                strArray = comboBox_CC1.SelectedItem.ToString().Split();
                cCode = strArray[1].Trim();
                cLevel = textBox_CL1.Text;
                usr.AddClass(cCode, cLevel);    //add class to user's class schedule
            }

            if (comboBox_CC2.SelectedItem != null)
            {
                strArray = comboBox_CC2.SelectedItem.ToString().Split();
                cCode = strArray[1].Trim();
                cLevel = textBox_CL2.Text;
                usr.AddClass(cCode, cLevel);
            }

            if (comboBox_CC3.SelectedItem != null)
            {
                strArray = comboBox_CC3.SelectedItem.ToString().Split();
                cCode = strArray[1].Trim();
                cLevel = textBox_CL3.Text;
                usr.AddClass(cCode, cLevel);
            }

            if (comboBox_CC4.SelectedItem != null)
            {
                strArray = comboBox_CC4.SelectedItem.ToString().Split();
                cCode = strArray[1].Trim();
                cLevel = textBox_CL4.Text;
                usr.AddClass(cCode, cLevel);
            }

            if (comboBox_CC5.SelectedItem != null)
            {
                strArray = comboBox_CC5.SelectedItem.ToString().Split();
                cCode = strArray[1].Trim();
                cLevel = textBox_CL5.Text;
                usr.AddClass(cCode, cLevel);
            }

            if (comboBox_CC6.SelectedItem != null)
            {
                strArray = comboBox_CC6.SelectedItem.ToString().Split();
                cCode = strArray[1].Trim();
                cLevel = textBox_CL6.Text;
                usr.AddClass(cCode, cLevel);
            }

            if (comboBox_CC7.SelectedItem != null)
            {
                strArray = comboBox_CC7.SelectedItem.ToString().Split();
                cCode = strArray[1].Trim();
                cLevel = textBox_CL7.Text;
                usr.AddClass(cCode, cLevel);
            }

        }
    }
}
