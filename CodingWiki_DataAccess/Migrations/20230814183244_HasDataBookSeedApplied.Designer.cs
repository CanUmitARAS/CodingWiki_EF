﻿// <auto-generated />
using CodingWiki_DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodingWikiDataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230814183244_HasDataBookSeedApplied")]
    partial class HasDataBookSeedApplied
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CodingWiki_Model.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 5)
                        .HasColumnType("decimal(10,5)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.ToTable("books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            ISBN = "123812",
                            Price = 10.9m,
                            Title = "Spider without duty"
                        },
                        new
                        {
                            BookId = 2,
                            ISBN = "12123812",
                            Price = 11.99m,
                            Title = "Fortune Of Time"
                        },
                        new
                        {
                            BookId = 3,
                            ISBN = "77652",
                            Price = 20.99m,
                            Title = "Fake Sunday"
                        },
                        new
                        {
                            BookId = 4,
                            ISBN = "CC12812",
                            Price = 25.99m,
                            Title = "Cookie Jar"
                        },
                        new
                        {
                            BookId = 5,
                            ISBN = "P0392B33",
                            Price = 40.99m,
                            Title = "Cloudy Forest"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
