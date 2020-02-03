using Microsoft.EntityFrameworkCore.Migrations;

namespace FreakyFashion.Data.Migrations
{
    public partial class v7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "image",
                value: "https://img01.ztat.net/article/PS/72/2E/01/AQ/11/PS722E01A-Q11@10.jpg?imwidth=300");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "image",
                value: "https://images.hugoboss.com/is/image/boss/hbeu50332479_001_100");
        }
    }
}
