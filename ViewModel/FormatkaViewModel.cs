using Formatka.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formatka.ViewModel
{
    public class FormatkaViewModel
    {
        
        public ObservableCollection<Customer> Customers { get; set; }
        //public ObservableCollection<Order> Orders { get; set; }
        //public ObservableCollection<Customer> AddCustomers { get; set; }
        private FormatkaRepository FormatkaRepository { get; set; }
        //private OrdersRepository OrdersRepository { get; set; }

        public FormatkaViewModel()
        {
            FormatkaRepository = new FormatkaRepository();
            //OrdersRepository = new OrdersRepository();    // TODO: ta linijka uniemożliwia działanie programu

            Customers = new ObservableCollection<Customer>(FormatkaRepository.formatkaRepository);
            //Orders = new ObservableCollection<Order>(OrdersRepository.ordersRepository);
            //AddCustomers = new ObservableCollection<Customer>(FormatkaRepository.formatkaRepository);
            Customers.CollectionChanged += Customers_CollectionChanged;       // Event Handler for change in collection
            //AddCustomers.CollectionChanged += AddCustomers_CollectionChanged;       // Event Handler for change in collection

        }

        /*
         * Function: Search for the query string in Movies Collection
         * Saves time and resources by searching in Collection in memory
         * rather than in database
         */
        public List<Customer> searchRepo(string searchQuery)
        {
            if (searchQuery == "*" || searchQuery == " ")
                throw new Exception("Warning: Symbols such as '*' or whitespace are not acceptable");

            List<Customer> CustomersList =                // Temporary list for storing results returned from search query
                (from tempCustomer in Customers
                 where tempCustomer.PESEL.Contains(searchQuery)
                 select tempCustomer).ToList();
            return CustomersList;
        }

        /*
         * Function: Add Record to Collection and Database
         */
        public void AddRecordToRepo(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException("Error: The argument is Null");
            Customers.Add(customer);
        }

        private void Customers_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                int newIndex = e.NewStartingIndex;
                FormatkaRepository.addNewRecord(Customers[newIndex]);
            }
            //else if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            //{
            //    List<Customer> tempListOfRemovedItems = e.OldItems.OfType<Movie>().ToList();
            //    FormatkaRepository.DelRecord(tempListOfRemovedItems[0].Id);
            //}
            //else if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Replace)
            //{
            //    List<Customer> tempListOfMovies = e.NewItems.OfType<Movie>().ToList();
            //    FormatkaRepository.UpdateRecord(tempListOfMovies[0]);  //    // As the IDs are unique, only one row will be effected hence first index only
            //}
        }
    }
}
