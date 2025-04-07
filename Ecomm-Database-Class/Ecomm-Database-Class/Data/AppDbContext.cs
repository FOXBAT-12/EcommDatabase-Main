using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using Ecomm_Database_Class.Model;

namespace Ecomm_Database_Class.Data           
{
    public class AppDbContext : DbContext
    { 
        public DbSet<Cart> CartItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=ECommerce;Integrated Security=True;TrustServerCertificate=true");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{  

        //}

        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
