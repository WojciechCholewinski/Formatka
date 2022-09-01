using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for NewOrderPage.xaml
    /// </summary>
    public partial class NewOrderPage : Page
    {
        public NewOrderPage()
        {
            InitializeComponent();
            //Services services = new Services();
            //typeOfInternet.ItemsSource = services.ToString();
            List<TodoItem> items = new List<TodoItem>();
            items.Add(new TodoItem() { Title = "Internet",});
            items.Add(new TodoItem() { Title = "Numer komórkowy", });
            items.Add(new TodoItem() { Title = "Pakiet internet + numer", });

            typeOfInternet.ItemsSource = items;
        }

        //private void Internet_Button_Click(object sender, RoutedEventArgs e)
        //{

        //}
        //private void Mobile_Number_Button_Click(object sender, RoutedEventArgs e)
        //{

        //}

        //private void Package_Button_Click(object sender, RoutedEventArgs e)
        //{

        //}

    }
    public class TodoItem
    {
        public string Title { get; set; }
    }
    
}
