using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodingWikiDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addOneToManyRelationBookPublisher : Migration
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

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Publisher_Id", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "Chigago", "Pub1 Jimmy" },
                    { 2, "New York", "Pub2 John" },
                    { 3, "Hawaii", "Pub3 Ben" }
                });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "Publisher_Id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "Publisher_Id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "BookId",
                keyValue: 3,
                column: "Publisher_Id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "BookId",
                keyValue: 4,
                column: "Publisher_Id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "BookId",
                keyValue: 5,
                column: "Publisher_Id",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_books_Publisher_Id",
                table: "books",
                column: "Publisher_Id");

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
                name: "FK_books_Publishers_Publisher_Id",
                table: "books");

            migrationBuilder.DropIndex(
                name: "IX_books_Publisher_Id",
                table: "books");

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
        }
    }
}
