using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formatka.Model
{
    public class Customer
    {
        public int Id { get; set; }

        public string First_Name { get; set; }

        public string Surname { get; set; }

        public string PESEL { get; set; }

        public string Id_card_number { get; set; }

        public string Mail { get; set; }

        public string Phone_Number { get; set; }

        public string Main_Address { get; set; }

        public string Correspondence_Address { get; set; }

        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();

    }
}
