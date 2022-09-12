using Formatka.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formatka.ViewModel
{
    public class OrdersViewModel
    {
        public ObservableCollection<Order> Orders { get; set; }
        private OrdersRepository OrdersRepository { get; set; }

        public OrdersViewModel()
        {
            OrdersRepository = new OrdersRepository();

            Orders = new ObservableCollection<Order>(OrdersRepository.ordersRepository);

        }

        /*
         * Function: Search for the query string in Movies Collection
         * Saves time and resources by searching in Collection in memory
         * rather than in database
         */
        public List<Order> searchRepo(string searchQuery)
        {
            if (searchQuery == "*" || searchQuery == " ")
                throw new Exception("Warning: Symbols such as '*' or whitespace are not acceptable");

            List<Order> OrdersList =                // Temporary list for storing results returned from search query
                (from tempOrder in Orders
                 where tempOrder.Date_of_order.Contains(searchQuery)        // TOD: zmienić frazę wyszukiwaną
                 select tempOrder).ToList();
            return OrdersList;
        }


        /*
         * Function: Add Record to Collection and Database
         */
        //public void AddRecordToRepo(Customer customer)
        //{
        //    if (customer == null)
        //        throw new ArgumentNullException("Error: The argument is Null");
        //    Customers.Add(customer);
        //}

        //private void Customers_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        //{
        //    if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
        //    {
        //        int newIndex = e.NewStartingIndex;
        //        FormatkaRepository.addNewRecord(Customers[newIndex]);
        //    }
        //    //else if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
        //    //{
        //    //    List<Customer> tempListOfRemovedItems = e.OldItems.OfType<Movie>().ToList();
        //    //    FormatkaRepository.DelRecord(tempListOfRemovedItems[0].Id);
        //    //}
        //    //else if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Replace)
        //    //{
        //    //    List<Customer> tempListOfMovies = e.NewItems.OfType<Movie>().ToList();
        //    //    FormatkaRepository.UpdateRecord(tempListOfMovies[0]);  //    // As the IDs are unique, only one row will be effected hence first index only
        //    //}
    }
}

