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

namespace Formatka
{
    /// <summary>
    /// Interaction logic for FormatkaHome.xaml
    /// </summary>
    public partial class FormatkaHome : Page
    {
        public FormatkaHome()
        {
            InitializeComponent();
        }
        private void Add_New_Button_Click(object sender, RoutedEventArgs e)
        {
            // Open new form to create new Order
            NewOrderPage newOrderPage = new NewOrderPage();
            this.NavigationService.Navigate(newOrderPage);
        }
        private void Open_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Closed_Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Wallet_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
