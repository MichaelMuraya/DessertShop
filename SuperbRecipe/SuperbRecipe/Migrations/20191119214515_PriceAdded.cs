using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperbRecipe.Migrations
{
    public partial class PriceAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 2,
                column: "Price",
                value: 14.25m);

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 3,
                column: "Price",
                value: 15.35m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 2,
                column: "Price",
                value: null);

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 3,
                column: "Price",
                value: null);
        }
    }
}
