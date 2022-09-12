using Formatka.Model;
using Formatka.ViewModel;
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
        int a = 0; // number of filled textboxes
        FormatkaViewModel FormatkaVM;
        Frame Frame;
        Color color = (Color)ColorConverter.ConvertFromString("#D4E4FC");
        public NewOrderPage()
        {
            InitializeComponent();


            //Services services = new Services();
            //typeOfInternet.ItemsSource = services.ToString();


        }
        public NewOrderPage(Frame frame1, FormatkaViewModel FormatkaVM)
        {
            InitializeComponent();
            this.Frame = frame1;
            this.FormatkaVM = FormatkaVM;

            //this.Loaded += NewOrderPage_Loaded;
            AddBtn.IsEnabled = false;
            //DelBtn.IsEnabled = false;
            //bool allTBoxNotEmpty = First_Name_TBox.Text != string.Empty && Surname_TBox.Text != string.Empty && PESEL_TBox.Text != string.Empty && Id_card_number_TBox.Text != string.Empty && Mail_TBox.Text != string.Empty && Phone_Number_TBox.Text != string.Empty && Main_Address_TBox.Text != string.Empty && Correspondence_Address_TBox.Text != string.Empty;


            cldSample.SelectedDate = DateTime.Now.AddDays(7);

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
        //private void NewOrderPage_Loaded(object sender, RoutedEventArgs e)
        //{
        //    searchBox.Focusable = true;
        //    Keyboard.Focus(searchBox);
        //}


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

        /*
         * Function: Event Handler for TextBox_GotFocus Event
         */
        private void First_Name_TBox_GotFocus(object sender, RoutedEventArgs e)
        {
            First_Name_TBox.Text = "";
            First_Name_TBox.FontStyle = FontStyles.Normal;
            First_Name_TBox.FontWeight = FontWeights.Normal;
            First_Name_TBox.Foreground = Brushes.Black;
        }

        /*
         * Function: Event Handler for TextBox_GotFocus Event
         */
        private void Surname_TBox_GotFocus(object sender, RoutedEventArgs e)
        {
            Surname_TBox.Text = "";
            Surname_TBox.FontStyle = FontStyles.Normal;
            Surname_TBox.FontWeight = FontWeights.Normal;
            Surname_TBox.Foreground = Brushes.Black;
        }

        /*
        * Function: Event Handler for TextBox_GotFocus Event
        */
        private void PESEL_TBox_GotFocus(object sender, RoutedEventArgs e)
        {
            PESEL_TBox.Text = "";
            PESEL_TBox.FontStyle = FontStyles.Normal;
            PESEL_TBox.FontWeight = FontWeights.Normal;
            PESEL_TBox.Foreground = Brushes.Black;
        }

        /*
        * Function: Event Handler for TextBox_GotFocus Event
        */
        private void Id_card_number_TBox_GotFocus(object sender, RoutedEventArgs e)
        {
            Id_card_number_TBox.Text = "";
            Id_card_number_TBox.FontStyle = FontStyles.Normal;
            Id_card_number_TBox.FontWeight = FontWeights.Normal;
            Id_card_number_TBox.Foreground = Brushes.Black;
        }
        //TODO: ADD: Function: Event Handler for TextBox_GotFocus Event
        private void Mail_TBox_GotFocus(object sender, RoutedEventArgs e)
        {
            Mail_TBox.Text = "";
            Mail_TBox.FontStyle = FontStyles.Normal;
            Mail_TBox.FontWeight = FontWeights.Normal;
            Mail_TBox.Foreground = Brushes.Black;
        }

        private void Phone_Number_TBox_GotFocus(object sender, RoutedEventArgs e)
        {
            Phone_Number_TBox.Text = "";
            Phone_Number_TBox.FontStyle = FontStyles.Normal;
            Phone_Number_TBox.FontWeight = FontWeights.Normal;
            Phone_Number_TBox.Foreground = Brushes.Black;
        }

        private void Main_Address_TBox_GotFocus(object sender, RoutedEventArgs e)
        {
            Main_Address_TBox.Text = "";
            Main_Address_TBox.FontStyle = FontStyles.Normal;
            Main_Address_TBox.FontWeight = FontWeights.Normal;
            Main_Address_TBox.Foreground = Brushes.Black;
        }

        private void Correspondence_Address_TBox_GotFocus(object sender, RoutedEventArgs e)
        {
            Correspondence_Address_TBox.Text = "";
            Correspondence_Address_TBox.FontStyle = FontStyles.Normal;
            Correspondence_Address_TBox.FontWeight = FontWeights.Normal;
            Correspondence_Address_TBox.Foreground = Brushes.Black;
            AllTBoxNotEmpty();
        }



        private void First_Name_TBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (First_Name_TBox.Text == string.Empty)
            {
                First_Name_TBox.BorderBrush = Brushes.Red;
            }
            else
            {
                First_Name_TBox.BorderBrush = new SolidColorBrush(color);
                AllTBoxNotEmpty();
            }
        }

        private void Surname_TBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Surname_TBox.Text == string.Empty)
            {
                Surname_TBox.BorderBrush = Brushes.Red;
            }
            else
            {
                Surname_TBox.BorderBrush = new SolidColorBrush(color);
                AllTBoxNotEmpty();
            }
        }

        private void PESEL_TBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (PESEL_TBox.Text == string.Empty)
            {
                PESEL_TBox.BorderBrush = Brushes.Red;
            }
            else
            {
                PESEL_TBox.BorderBrush = new SolidColorBrush(color);
                AllTBoxNotEmpty();
            }
        }

        private void Id_card_number_TBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Id_card_number_TBox.Text == string.Empty)
            {
                Id_card_number_TBox.BorderBrush = Brushes.Red;
            }
            else
            {
                Id_card_number_TBox.BorderBrush = new SolidColorBrush(color);
                AllTBoxNotEmpty();
            }
        }

        private void Mail_TBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Mail_TBox.Text == string.Empty)
            {
                Mail_TBox.BorderBrush = Brushes.Red;
            }
            else
            {
                Mail_TBox.BorderBrush = new SolidColorBrush(color);
                AllTBoxNotEmpty();
            }
        }

        private void Phone_Number_TBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Phone_Number_TBox.Text == string.Empty)
            {
                Phone_Number_TBox.BorderBrush = Brushes.Red;
            }
            else
            {
                Phone_Number_TBox.BorderBrush = new SolidColorBrush(color);
                AllTBoxNotEmpty();
            }
        }

        private void Main_Address_TBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Main_Address_TBox.Text == string.Empty)
            {
                Main_Address_TBox.BorderBrush = Brushes.Red;
            }
            else
            {
                Main_Address_TBox.BorderBrush = new SolidColorBrush(color);
                AllTBoxNotEmpty();
            }
        }

        private void Correspondence_Address_TBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Correspondence_Address_TBox.Text == string.Empty)
            {
                Correspondence_Address_TBox.BorderBrush = Brushes.Red;
            }
            else
            {
                Correspondence_Address_TBox.BorderBrush = new SolidColorBrush(color);
                AllTBoxNotEmpty();
            }
        }

        private void AllTBoxNotEmpty()
        {
            a++;
            if (a >= 8)
            {
                AddBtn.IsEnabled = true;
            }
        }
                     

    //private void AllBrushesBright()
    //{
    //    Color color = (Color)ColorConverter.ConvertFromString("#D4E4FC");
    //    First_Name_TBox.BorderBrush = new SolidColorBrush(color);
    //    Surname_TBox.BorderBrush = new SolidColorBrush(color);
    //    PESEL_TBox.BorderBrush = new SolidColorBrush(color);
    //    Id_card_number_TBox.BorderBrush = new SolidColorBrush(color);
    //    Mail_TBox.BorderBrush = new SolidColorBrush(color);
    //    Phone_Number_TBox.BorderBrush = new SolidColorBrush(color);
    //    Main_Address_TBox.BorderBrush = new SolidColorBrush(color);
    //    Correspondence_Address_TBox.BorderBrush = new SolidColorBrush(color);
    //}

    private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = new Customer();
            customer.First_Name = First_Name_TBox.Text;
            customer.Surname = Surname_TBox.Text;
            customer.PESEL = PESEL_TBox.Text;
            customer.Id_card_number = Id_card_number_TBox.Text;
            customer.Mail = Mail_TBox.Text;
            customer.Phone_Number = Phone_Number_TBox.Text;
            customer.Main_Address = Main_Address_TBox.Text;
            customer.Correspondence_Address = Correspondence_Address_TBox.Text;

            FormatkaVM.AddRecordToRepo(customer);

            MessageBox.Show("Klienta zapisano", "Udało się", MessageBoxButton.OK, MessageBoxImage.Information);

            First_Name_TBox.Text = string.Empty;
            Surname_TBox.Text = string.Empty;
            PESEL_TBox.Text = string.Empty;
            Id_card_number_TBox.Text = string.Empty;
            Mail_TBox.Text = string.Empty;
            Phone_Number_TBox.Text = string.Empty;
            Main_Address_TBox.Text = string.Empty;
            Correspondence_Address_TBox.Text = string.Empty;
        }
        

        
        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            //Order order = new Order();
            //order.Id_Customer = 

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

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void searchBox_GotFocus(object sender, RoutedEventArgs e)
        {
            searchBox.Text = "";
            searchBox.FontStretch = FontStretches.Normal;
            searchBox.FontStyle = FontStyles.Normal;
            searchBox.Foreground = Brushes.Black;
        }
        private void gridTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // TODO: zmienić EditBtn na button akceptujący wybranego istaniejącego już klienta
            if (gridTable.SelectedCells.Count == 0)
            {
                AddBtn.IsEnabled = false;
                //DelBtn.IsEnabled = false;
                return;
            }
            AddBtn.IsEnabled = true;
            /*DelBtn.IsEnabled = true*/;
        }
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            //TODO: Edytować Search_Click
            if (searchBox.Text == "" || searchBox.Text == "Wpisz PESEL klienta")
            {
                WarningSearchLabel.Visibility = Visibility.Visible;
                return;
            }
            WarningSearchLabel.Visibility = Visibility.Hidden;
            gridTable.DataContext = FormatkaVM.searchRepo(searchBox.Text);
            gridTable.Columns[0].Visibility = Visibility.Hidden;        // Hides the first column i.e. ID
            gridTable.Columns[4].Visibility = Visibility.Hidden;        // Hides the first column i.e. ID
            gridTable.Columns[5].Visibility = Visibility.Hidden;        // Hides the first column i.e. ID
            gridTable.Columns[6].Visibility = Visibility.Hidden;        // Hides the first column i.e. ID
            gridTable.Columns[7].Visibility = Visibility.Hidden;        // Hides the first column i.e. ID
            gridTable.Columns[8].Visibility = Visibility.Hidden;        // Hides the first column i.e. ID
            gridTable.Columns[9].Visibility = Visibility.Hidden;        // Hides the first column i.e. ID

            if (gridTable.SelectedCells.Count == 0)         // Disanle the Edit and Delete Button if no row selected
            {
                AddBtn.IsEnabled = false;
                //DelBtn.IsEnabled = false;
            }
            else
            {
                AddBtn.IsEnabled = true;
                //DelBtn.IsEnabled = true;
            }
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            //TODO: stosować wymiennie
            //Frame.Navigate(new FormatkaHome(Frame, FormatkaVM));
            this.Frame.NavigationService.GoBack();
        }
    }
}
