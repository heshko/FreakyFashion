using Microsoft.EntityFrameworkCore.Migrations;

namespace FreakyFashion.Data.Migrations
{
    public partial class v : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<float>(nullable: false),
                    image = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "Type", "image" },
                values: new object[,]
                {
                    { 1, "Best Byxor", "HYBRID PANT", 200f, "trouser", "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" },
                    { 18, "Best Blus", "TAMAYO DRESS", 200f, "dress", "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" },
                    { 17, "Best Blus", "TAMAYO DRESS", 200f, "dress", "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" },
                    { 16, "Best Blus", "Blus", 200f, "shirts", "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" },
                    { 15, "Best Blus", "Blus", 200f, "shirts", "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" },
                    { 14, "Best Blus", "Blus", 200f, "shirts", "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" },
                    { 13, "Best Blus", "Blus", 200f, "shirts", "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" },
                    { 12, "Best Blus", "Blus", 200f, "shirts", "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" },
                    { 11, "Best Blus", "Blus", 200f, "shirts", "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" },
                    { 10, "Best Blus", "Blus", 200f, "shirts", "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" },
                    { 9, "Best Blus", "Blus", 200f, "shirts", "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" },
                    { 8, "Best Byxor", "HYBRID PANT", 200f, "trouser", "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" },
                    { 7, "Best Byxor", "HYBRID PANT", 200f, "trouser", "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" },
                    { 6, "Best Byxor", "HYBRID PANT", 200f, "trouser", "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" },
                    { 5, "Best Byxor", "HYBRID PANT", 200f, "trouser", "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" },
                    { 4, "Best Byxor", "HYBRID PANT", 200f, "trouser", "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" },
                    { 3, "Best Byxor", "HYBRID PANT", 200f, "trouser", "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" },
                    { 2, "Best Byxor", "HYBRID PANT", 200f, "trouser", "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" },
                    { 19, "Best Blus", "TAMAYO DRESS", 200f, "dress", "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" },
                    { 20, "Best Blus", "TAMAYO DRESS", 200f, "dress", "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
