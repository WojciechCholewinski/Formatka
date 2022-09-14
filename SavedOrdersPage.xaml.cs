using Formatka.Model;
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
    /// Interaction logic for SavedOrdersPage.xaml
    /// </summary>
    public partial class SavedOrdersPage : Page
    {
        OrdersViewModel OrdersVM;
        Frame Frame;

        //public List<Order> MyOrders { get; set; }

        public SavedOrdersPage()
        {
            InitializeComponent();

            //using (FormatkaContext _context = new FormatkaContext())
            //{
            //    MyOrders = _context.Orders.ToList();
            //}

            //OrdersList.ItemsSource = MyOrders;
        }
        public SavedOrdersPage(Frame frame2, OrdersViewModel OrdersVM)
        {
            InitializeComponent();
            this.Frame = frame2;
            this.OrdersVM = OrdersVM;
        }
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            //stosować wymiennie
            //Frame.Navigate(new FormatkaHome(Frame, FormatkaVM));
            this.Frame.NavigationService.GoBack();
        }
    }
}
