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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Windows.Markup;

namespace WpfApp2.View
{
    public partial class UserControl1 : UserControl
    {
        private Add addControl;

        public UserControl1()
        {
            InitializeComponent();
            addControl = new Add();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            string menu = menuTxt.Text;

            if (menu == "1")
            {
                
                contentControl.Content = addControl;
                this.Visibility = Visibility.Hidden;
                addControl.Visibility = Visibility.Visible;
            }
            else if (menu == "2")
            {
                // Handle other menu options
            }
            else if (menu == "3")
            {
                // Handle other menu options
            }
            else if (menu == "4")
            {
                // Handle other menu options
            }
            else if (menu == "5")
            {
                Console.WriteLine("GOODBYE!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("GOODBYE!");
                Environment.Exit(0);
            }
        }

        private void menuTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Handle text changed event
        }
    }
}

   