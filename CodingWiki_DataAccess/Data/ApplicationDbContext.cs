using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingWiki_Model.Models;

namespace CodingWiki_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> books { get; set; }

        public DbSet<Category> genres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=CodingWiki;TrustServerCertificate=True;Trusted_Connection=True;");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(u => u.Price).HasPrecision(10, 5);

            modelBuilder.Entity<Book>().HasData(

                new Book { BookId = 1, Title = "Spider without duty", ISBN = "123812", Price = 10.9m },
                 new Book { BookId = 2, Title = "Fortune Of Time", ISBN = "12123812", Price = 11.99m }
                
                );

            var bookList = new Book[]
            {
                new Book { BookId = 3, Title = "Fake Sunday", ISBN="77652", Price=20.99m},
                new Book { BookId = 4, Title ="Cookie Jar", ISBN="CC12812", Price= 25.99m},
                new Book { BookId = 5, Title = "Cloudy Forest", ISBN = "P0392B33", Price= 40.99m}
            };

            modelBuilder.Entity<Book>().HasData(bookList);
             

        }
    }
}
