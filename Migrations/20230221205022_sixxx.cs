using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace incerc.Migrations
{
    public partial class sixxx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShopID",
                table: "Book",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Shop",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_ShopID",
                table: "Book",
                column: "ShopID");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Shop_ShopID",
                table: "Book",
                column: "ShopID",
                principalTable: "Shop",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Shop_ShopID",
                table: "Book");

            migrationBuilder.DropTable(
                name: "Shop");

            migrationBuilder.DropIndex(
                name: "IX_Book_ShopID",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "ShopID",
                table: "Book");
        }
    }
}
