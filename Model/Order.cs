using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formatka.Model
{
    public class Order
    {
        public int Id { get; set; }

        public int? Id_Customer { get; set; }
        //public Customer Customer { get; set; }

        public int? Id_Service { get; set; }
        //public ServiceName ServiceName { get; set; }

        public string Delivery_date { get; set; }
        public string Date_of_order { get; set; }
    }
}
