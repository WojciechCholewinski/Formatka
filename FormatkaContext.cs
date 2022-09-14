using Formatka.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formatka
{
    public class FormatkaContext : DbContext
    {
        public FormatkaContext()
        {

        }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-QVUP24A;Initial Catalog=Formatka;Integrated Security=True");
            }
        }
    }
}
