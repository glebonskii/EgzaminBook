using EgzaminBook.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminBook.Data
{
    public class AppContext: DbContext
    {
        
        public AppContext():base("DefaultConnection")
        {
            Database.SetInitializer(new SeedDataBase());
        }       
        public DbSet<Book> books { get; set; }
        public DbSet<Genre> genres { get; set; }
        public DbSet<RegisterClient> registerClients { get; set; }
        public DbSet<NameProdaction> nameProdactions { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Discount> discounts { get; set; }
        public DbSet<Reservation> reservations { get; set; }
        public DbSet<Authors> authors { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Sale> sales { get; set; }
    }
}