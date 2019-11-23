using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperbRecipe.Migrations
{
    public partial class SeasonalP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Desserts",
                columns: new[] { "DessertId", "AllergyInformation", "CategoryId", "DessertofWeek", "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { 11, "Has nuts,milk products and Soy", 3, true, "https://www.bbcgoodfood.com/sites/default/files/recipe-collections/collection-image/2013/05/chicken-kale-mushroom-pot-pie.jpg", "https://www.bbcgoodfood.com/sites/default/files/recipe-collections/collection-image/2013/05/chicken-kale-mushroom-pot-pie.jpg", true, "The Ice-cream of your choice!!", "Caramel Ice-cream mix", "Best served chilled", 9.25m, "The Only handmade Icecream in town!!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 11);
        }
    }
}
