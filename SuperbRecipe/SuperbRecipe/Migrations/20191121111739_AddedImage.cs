using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperbRecipe.Migrations
{
    public partial class AddedImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://academyautumn-19.slack.com/files/UMM5996HH/FQVRAARV4/blueberry1.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://www.simplyrecipes.com/wp-content/uploads/2005/07/blueberry-cake-vertical-b-1200-768x1152.jpg");
        }
    }
}
