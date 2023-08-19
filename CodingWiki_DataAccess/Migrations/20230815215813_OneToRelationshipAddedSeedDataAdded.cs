using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodingWikiDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class OneToRelationshipAddedSeedDataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Publisher_Id",
                table: "books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Book_Id",
                table: "BookDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Publisher_Id", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "Chigago", "Pub 1 Jimmy" },
                    { 2, "New York", "Pub 1 John" },
                    { 3, "Hawaii", "Pub 1 Ben" }
                });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "Publisher_Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "Publisher_Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "BookId",
                keyValue: 3,
                column: "Publisher_Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "BookId",
                keyValue: 4,
                column: "Publisher_Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "BookId",
                keyValue: 5,
                column: "Publisher_Id",
                value: 0);

            migrationBuilder.CreateIndex(
                name: "IX_books_Publisher_Id",
                table: "books",
                column: "Publisher_Id");

            migrationBuilder.CreateIndex(
                name: "IX_BookDetails_Book_Id",
                table: "BookDetails",
                column: "Book_Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BookDetails_books_Book_Id",
                table: "BookDetails",
                column: "Book_Id",
                principalTable: "books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_books_Publishers_Publisher_Id",
                table: "books",
                column: "Publisher_Id",
                principalTable: "Publishers",
                principalColumn: "Publisher_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookDetails_books_Book_Id",
                table: "BookDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_books_Publishers_Publisher_Id",
                table: "books");

            migrationBuilder.DropIndex(
                name: "IX_books_Publisher_Id",
                table: "books");

            migrationBuilder.DropIndex(
                name: "IX_BookDetails_Book_Id",
                table: "BookDetails");

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Publisher_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Publisher_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Publisher_Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Publisher_Id",
                table: "books");

            migrationBuilder.DropColumn(
                name: "Book_Id",
                table: "BookDetails");
        }
    }
}
