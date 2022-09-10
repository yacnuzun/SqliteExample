using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class intialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ProductCode = table.Column<string>(type: "TEXT", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "ProductCode", "Quantity" },
                values: new object[] { 1223, "Finish Bulaşık Makinesi Parlatıcı 800 ml", "3007975", 2 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "ProductCode", "Quantity" },
                values: new object[] { 1232, "Fatih 2 pants", "w-l-12532w2i", 12 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "ProductCode", "Quantity" },
                values: new object[] { 1233, "Finish Bulaşık Makinesi Parlatıcı 800 ml", "12321321", 51 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "ProductCode", "Quantity" },
                values: new object[] { 1237, "MAVİ LOGO TİŞÖRT koyu yeşil", "065781-31966", -1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "ProductCode", "Quantity" },
                values: new object[] { 1240, "Finish Classic Jel Bulaşık Makinesi Deterjanı", "11", 47 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
