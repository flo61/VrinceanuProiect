using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace incerc.Migrations
{
    public partial class patruss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GenreID",
                table: "Book",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_GenreID",
                table: "Book",
                column: "GenreID");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Genre_GenreID",
                table: "Book",
                column: "GenreID",
                principalTable: "Genre",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Genre_GenreID",
                table: "Book");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropIndex(
                name: "IX_Book_GenreID",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "GenreID",
                table: "Book");
        }
    }
}
