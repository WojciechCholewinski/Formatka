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

            List<ContractDuration> durationItems = new List<ContractDuration>()
            {
                new ContractDuration(){ Id=1, Duration = "24 miesiące"},
                new ContractDuration(){ Id=2, Duration = "12 miesięcy"},
                new ContractDuration(){ Id=3, Duration = "Czas nieokreślony"}
            };
            contractDuration.ItemsSource = durationItems;
            contractDuration.DisplayMemberPath = "Duration";
            contractDuration.SelectedValuePath = "Id";


            List<ServiceType> typeOfItems = new List<ServiceType>()
            {
                new ServiceType() { Id=1, Type1 = "Mobilne"},
                new ServiceType() { Id=2, Type1 = "Stacjonarne"},
                new ServiceType() { Id=3, Type1 = "Konwergentne"}
            };

            serviceType.ItemsSource = typeOfItems;
            serviceType.DisplayMemberPath = "Type1";
            serviceType.SelectedValuePath = "Id";




        }
        private void BindNameOfItems(int nameOfItemsId)
        {
            List<ServiceName> nameOfItems = new List<ServiceName>();
            if (nameOfItemsId == 1)
            {
                nameOfItems = new List<ServiceName>()
                {
                new ServiceName() { Id=1, Name = "Plan 40"},
                new ServiceName() { Id=2, Name = "Plan 50"},
                new ServiceName() { Id=3, Name = "Plan 60"},
                new ServiceName() { Id=4, Name = "Plan 80"}
                };
            }
            else if (nameOfItemsId == 2)
            {
                nameOfItems = new List<ServiceName>()
                {
                new ServiceName() { Id=1, Name = "Internet domowy"},
                new ServiceName() { Id=2, Name = "Internet + TV"}
                };
            }
            else if (nameOfItemsId == 3)
            {
                nameOfItems = new List<ServiceName>()
                {
                new ServiceName() { Id = 1, Name = "Pakiet Standard"},
                new ServiceName() { Id = 2, Name = "Pakiet Extra"},
                new ServiceName() { Id = 3, Name = "Pakiet Premium"}
                };
            }
            serviceName.ItemsSource = nameOfItems;
            serviceName.DisplayMemberPath = "Name";
            serviceName.SelectedValuePath = "Id";
        }

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            //TODO: dodać zapisanie zamówienia

            MessageBox.Show("Zamówienie zapisano", "Udało się", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ServiceChanged(object sender, SelectionChangedEventArgs e)
        {
            int TypeId = Convert.ToInt32(serviceType.SelectedValue);
            BindNameOfItems(TypeId);
        }
        private void NameOfServiceChanged(object sender, SelectionChangedEventArgs e)
        {
            //int NameId = Convert.ToInt32(serviceName.SelectedValue);
            //serviceType2.ItemsSource = serviceName.SelectedValuePath;
            //serviceType2.DisplayMemberPath = "Name";
            //serviceType2.SelectedValuePath = "Id";
            serviceType2.Content = serviceName.SelectedValue;
        }
        
        public class ServiceType
        {
            public int Id { get; set; }
            public string Type1 { get; set; }
        }
        public class ContractDuration
        {
            public int Id { get; set; }
            public string Duration { get; set; }
        }
        public class ServiceName
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

      
    }
}
