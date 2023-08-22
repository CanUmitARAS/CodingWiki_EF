﻿// See https://aka.ms/new-console-template for more information
using CodingWiki_DataAccess.Data;
using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;
using static System.Reflection.Metadata.BlobBuilder;

Console.WriteLine("Hello, World!");

//using(ApplicationDbContext context = new())
//{
//    context.Database.EnsureCreated();
//    if (context.Database.GetPendingMigrations().Count() > 0) 
//    {
//        context.Database.Migrate(); 
//    }
//}
//AddBook();
//GetAllBooks();
GetBook();

void GetBook()
{
    
    try
    {
        using var context = new ApplicationDbContext();
        var selectedBooks = context.Books.Where(u => u.ISBN.Contains("12"));
        //Console.WriteLine(selectedBooks.Title + " - " + selectedBooks.ISBN);
        foreach (var book in selectedBooks)
        {
            Console.WriteLine(book.Title + " - " + book.ISBN);
        }
    }
    catch (Exception e)
    {
        throw;
    }



    //try
    //{
    //    using var context = new ApplicationDbContext();
    //    var book = context.Books.Where(u => u.Publisher_Id == 3);
    //    Console.WriteLine(book.Title + " - " + book.ISBN);
    //    foreach (var book in books)
    //    {
    //        Console.WriteLine(book.Title + " - " + book.ISBN);
    //    }
    //}
    //catch (Exception e)
    //{

    //}
}

void GetAllBooks()
{
    using var context = new ApplicationDbContext();
    var books = context.Books.ToList();

}


void AddBook()
{
    Book book = new() { Title = "New EF Core Book", ISBN = "1231231212", Price = 10.93m, Publisher_Id = 1 };
    using var context = new ApplicationDbContext();
    var books = context.Books.Add(book);
    context.SaveChanges();
}