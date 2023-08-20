﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodingWikiDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DropBookAuthorManual : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                 name: "AuthorBook");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "AuthorBook",
               columns: table => new
               {
                   AuthorsAuthor_Id = table.Column<int>(type: "int", nullable: false),
                   BooksBookId = table.Column<int>(type: "int", nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_AuthorBook", x => new { x.AuthorsAuthor_Id, x.BooksBookId });
                   table.ForeignKey(
                       name: "FK_AuthorBook_Authors_AuthorsAuthor_Id",
                       column: x => x.AuthorsAuthor_Id,
                       principalTable: "Authors",
                       principalColumn: "Author_Id",
                       onDelete: ReferentialAction.Cascade);
                   table.ForeignKey(
                       name: "FK_AuthorBook_Books_BooksBookId",
                       column: x => x.BooksBookId,
                       principalTable: "Books",
                       principalColumn: "BookId",
                       onDelete: ReferentialAction.Cascade);
               });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBook_BooksBookId",
                table: "AuthorBook",
                column: "BooksBookId");

        }
    }
}
