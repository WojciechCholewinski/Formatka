using Formatka.ViewModel;
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
        private Frame Frame;
        FormatkaViewModel FormatkaVM;
        OrdersViewModel OrdersVM;
        public FormatkaHome()
        {
            InitializeComponent();
        }
        public FormatkaHome(Frame frame1, FormatkaViewModel formatkaVM)
        {
            InitializeComponent();
            this.Frame = frame1;
            this.FormatkaVM = formatkaVM;
        }
        private void Add_New_Button_Click(object sender, RoutedEventArgs e)
        {
            // Open new form to create new Order
            //NewOrderPage newOrderPage = new NewOrderPage();
            //this.NavigationService.Navigate(newOrderPage);
            this.Frame.Navigate(new NewOrderPage(this.Frame, this.FormatkaVM));
        }
        private void Open_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(new SavedOrdersPage(this.Frame, this.OrdersVM));
        }

        private void Closed_Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Wallet_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        //private void Button_GotMouseCapture(object sender, MouseEventArgs e)
        //{
        //    Button tb = e.Source as Button;
        //    tb.Background = Brushes.Red;
        //}
        //private void OnGotFocusHandler(object sender, RoutedEventArgs e)
        //{
        //    Button tb = e.Source as Button;
        //    tb.Background = Brushes.Red;
        //}
        //// Raised when Button losses focus.
        //// Changes the color of the Button back to white.
        //private void OnLostFocusHandler(object sender, RoutedEventArgs e)
        //{
        //    Button tb = e.Source as Button;
        //    tb.Background = Brushes.White;
        //}
    }
}
