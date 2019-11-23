using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperbRecipe.Migrations
{
    public partial class Icr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 8,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://sugargeekshow.com/wp-content/uploads/2019/05/lemon-blueberry-cake-featured.jpg", "https://sugargeekshow.com/wp-content/uploads/2019/05/lemon-blueberry-cake-featured.jpg" });

            migrationBuilder.InsertData(
                table: "Desserts",
                columns: new[] { "DessertId", "AllergyInformation", "CategoryId", "DessertofWeek", "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { 10, "Has nuts,milk products and Soy", 6, true, "https://www.loveandoliveoil.com/wp-content/uploads/2016/09/caramel-cookie-ice-creamH2-1200x550.jpg", "https://www.loveandoliveoil.com/wp-content/uploads/2016/09/caramel-cookie-ice-creamH2-1200x550.jpg", true, "The Ice-cream of your choice!!", "Caramel Ice-cream mix", "Best served chilled", 9.25m, "The Only handmade Icecream in town!!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 8,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "C:\\Users\\35840\\Desktop\\SuperbRecipe\\SuperbRecipe\\SuperbRecipe\\wwwroot\\Delish\\blueberry1.jpg", "C:\\Users\\35840\\Desktop\\SuperbRecipe\\SuperbRecipe\\SuperbRecipe\\wwwroot\\Delish\\blueberry1.jpg" });
        }
    }
}
