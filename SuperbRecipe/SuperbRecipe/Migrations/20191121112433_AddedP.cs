using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperbRecipe.Migrations
{
    public partial class AddedP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "C:\\Users\\35840\\Desktop\\SuperbRecipe\\SuperbRecipe\\SuperbRecipe\\wwwroot\\Delish\\blueberry1.jpg", "C:\\Users\\35840\\Desktop\\SuperbRecipe\\SuperbRecipe\\SuperbRecipe\\wwwroot\\Delish\\blueberry1.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://academyautumn-19.slack.com/files/UMM5996HH/FQVRAARV4/blueberry1.jpg", "https://academyautumn-19.slack.com/files/UMM5996HH/FQVRAARV4/blueberry1.jpg" });
        }
    }
}
