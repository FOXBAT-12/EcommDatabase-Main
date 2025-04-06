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
        //public DbSet<Cart> CartItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=ECommerce1;Integrated Security=True;TrustServerCertificate=true");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{  

        //}

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        //public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .HasOne(c => c.Category)
                .WithMany()
                .HasForeignKey(sc => sc.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Product>()
                .HasOne(c => c.SubCategory)
                .WithMany()
                .HasForeignKey(sc => sc.SubCategoryId)
                .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Category>()
            //    .HasMany(c => c.Products)
            //    .WithOne(p => p.Category!)
            //    .HasForeignKey(p => p.CategoryId);

            //modelBuilder.Entity<SubCategory>()
            //    .HasMany(sc => sc.Products)
            //    .WithOne(p => p.SubCategory!)
            //    .HasForeignKey(p => p.SubCategoryId);

            // Seed Category
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Luxury" },
                new Category { Id = 2, Name = "Casual" }
            );

            // Seed SubCategory
            modelBuilder.Entity<SubCategory>().HasData(
                new SubCategory { Id = 1, Name = "Analog", CategoryId = 1 },
                new SubCategory { Id = 2, Name = "Digital", CategoryId = 2 }
            );

            // Seed Product
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Omega Seamaster",
                    Description = "Luxury dive watch",
                    Price = 2999.99M,
                    Brand = "Omega",
                    SoldCount = 120,
                    CategoryId = 1,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Name = "Casio G-Shock",
                    Description = "Rugged digital watch",
                    Price = 149.99M,
                    Brand = "Casio",
                    SoldCount = 500,
                    CategoryId = 2,
                    SubCategoryId = 2
                }
                );

        }
    }
}
