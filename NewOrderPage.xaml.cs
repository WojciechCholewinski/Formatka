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

            List<ContractDuration> durationItems = new List<ContractDuration>();
            durationItems.Add(new ContractDuration() { Duration = "24 miesiące", });
            durationItems.Add(new ContractDuration() { Duration = "12 miesięcy", });
            durationItems.Add(new ContractDuration() { Duration = "Czas nieokreślony", });

            contractDuration.ItemsSource = durationItems;


            List<ServiceType> typeOfItems = new List<ServiceType>();
            typeOfItems.Add(new ServiceType() { Type = "Internet",});
            typeOfItems.Add(new ServiceType() { Type = "Numer komórkowy", });
            typeOfItems.Add(new ServiceType() { Type = "Pakiet internet + numer", });

            serviceType.ItemsSource = typeOfItems;
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
    public class ServiceType
    {
        public string Type { get; set; }
    }
    public class ContractDuration
    {
        public string Duration { get; set; }
    }

    
}
