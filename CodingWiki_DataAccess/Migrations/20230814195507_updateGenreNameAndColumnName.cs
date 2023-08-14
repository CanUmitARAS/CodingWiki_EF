using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWikiDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updateGenreNameAndColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_genres",
                table: "genres");

            migrationBuilder.RenameTable(
                name: "genres",
                newName: "tb_genres");

            migrationBuilder.RenameColumn(
                name: "GenreName",
                table: "tb_genres",
                newName: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_genres",
                table: "tb_genres",
                column: "GenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_genres",
                table: "tb_genres");

            migrationBuilder.RenameTable(
                name: "tb_genres",
                newName: "genres");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "genres",
                newName: "GenreName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_genres",
                table: "genres",
                column: "GenreId");
        }
    }
}
