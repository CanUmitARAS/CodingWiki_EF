using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingWiki_Model.Models;
using CodingWiki_DataAccess.FluentConfig;

namespace CodingWiki_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> books { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Author> Authors { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }

        

        //rename to fluent_bookDetails
        public DbSet<Fluent_BookDetail> BookDetail_Fluent { get; set; }
        public DbSet<Fluent_Book> Fluent_Books { get; set; }

        public DbSet<Fluent_Author> Fluent_Authors { get; set; }

        public DbSet<Fluent_Publisher> Fluent_Publishers { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=CodingWiki;TrustServerCertificate=True;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(u => u.Price).HasPrecision(10, 5);
            modelBuilder.Entity<BookAuthorMap>().HasKey(u => new { u.Author_Id, u.Book_Id });


            modelBuilder.ApplyConfiguration(new FluentBookConfig());
            modelBuilder.ApplyConfiguration(new FluentAuthorConfig());
            modelBuilder.ApplyConfiguration(new FluentBookDetailConfig());
            modelBuilder.ApplyConfiguration(new FluentPublisherConfig());                
                   
           

            modelBuilder.Entity<Fluent_BookAuthorMap>().HasKey(u => new { u.Author_Id, u.Book_Id });
            modelBuilder.Entity<Fluent_BookAuthorMap>().HasOne(u => u.Book).WithMany(u => u.BookAuthorMap).HasForeignKey(u => u.Book_Id);
            modelBuilder.Entity<Fluent_BookAuthorMap>().HasOne(u => u.Author).WithMany(u => u.BookAuthorMap).HasForeignKey(u => u.Author_Id);

            modelBuilder.Entity<Book>().HasData(


                 new Book { BookId = 1, Title = "Spider without duty", ISBN = "123812", Price = 10.9m, Publisher_Id = 1 },
                 new Book { BookId = 2, Title = "Fortune Of Time", ISBN = "12123812", Price = 11.99m, Publisher_Id = 2 }


                );



            var bookList = new Book[]
            {
                new Book { BookId = 3, Title = "Fake Sunday", ISBN="77652", Price=20.99m, Publisher_Id =3},
                new Book { BookId = 4, Title ="Cookie Jar", ISBN="CC12812", Price= 25.99m, Publisher_Id =1},
                new Book { BookId = 5, Title = "Cloudy Forest", ISBN = "P0392B33", Price= 40.99m, Publisher_Id = 2}
            };

            modelBuilder.Entity<Book>().HasData(bookList);


            modelBuilder.Entity<Publisher>().HasData
              (
                 new Publisher { Publisher_Id = 1, Name = "Pub1 Jimmy", Location = "Chigago" },
                 new Publisher { Publisher_Id = 2, Name = "Pub2 John", Location = "New York" },
                 new Publisher { Publisher_Id = 3, Name = "Pub3 Ben", Location = "Hawaii" }
              );




        }
    }
}
