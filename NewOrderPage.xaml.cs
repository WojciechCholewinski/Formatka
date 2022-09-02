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
            cldSample.SelectedDate = DateTime.Now.AddDays(1);

            //Services services = new Services();
            //typeOfInternet.ItemsSource = services.ToString();

            List<ContractDuration> durationItems = new List<ContractDuration>();
            durationItems.Add(new ContractDuration() { Duration = "24 miesiące", });
            durationItems.Add(new ContractDuration() { Duration = "12 miesięcy", });
            durationItems.Add(new ContractDuration() { Duration = "Czas nieokreślony", });

            contractDuration.ItemsSource = durationItems;


            List<ServiceType> typeOfItems = new List<ServiceType>();
            typeOfItems.Add(new ServiceType() { Type1 = "Internet"});
            typeOfItems.Add(new ServiceType() { Type1 = "Numer komórkowy"});
            typeOfItems.Add(new ServiceType() { Type1 = "Pakiet internet + numer"});

            serviceType.ItemsSource = typeOfItems;

            
            List<ServiceName> nameOfItems = new List<ServiceName>();
            nameOfItems.Add(new ServiceName() { Name = "Plan 40", });
            nameOfItems.Add(new ServiceName() { Name = "Plan 50", });
            nameOfItems.Add(new ServiceName() { Name = "Plan 60", });
            nameOfItems.Add(new ServiceName() { Name = "Plan 80", });
            nameOfItems.Add(new ServiceName() { Name = "Internet domowy", });
            nameOfItems.Add(new ServiceName() { Name = "Internet + TV", });
            nameOfItems.Add(new ServiceName() { Name = "Pakiet Standard", });
            nameOfItems.Add(new ServiceName() { Name = "Pakiet Extra", });
            nameOfItems.Add(new ServiceName() { Name = "Pakiet Premium", });

            serviceName.ItemsSource = nameOfItems;
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
        public string Type1 { get; set; }
    }
    public class ContractDuration
    {
        public string Duration { get; set; }
    }
    public class ServiceName
    {
        public string Name { get; set; }
    }


}
