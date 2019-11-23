using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperbRecipe.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Fruit pies", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Cheese cakes", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Seasonal pies", null });

            migrationBuilder.InsertData(
                table: "Desserts",
                columns: new[] { "DessertId", "AllergyInformation", "CategoryId", "DessertofWeek", "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { 1, "", 1, true, "https://www.handletheheat.com/wp-content/uploads/2019/07/Lemon-Cheesecake-SQUARE.jpg", "https://www.handletheheat.com/wp-content/uploads/2019/07/Lemon-Cheesecake-SQUARE.jpg", true, "The best Apple pie in town reminds you of Christmas in Lapland!!", "Apple Pie", 12.35m, "Awesome pies!!" });

            migrationBuilder.InsertData(
                table: "Desserts",
                columns: new[] { "DessertId", "AllergyInformation", "CategoryId", "DessertofWeek", "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { 2, "", 1, true, "https://www.handletheheat.com/wp-content/uploads/2019/07/Lemon-Cheesecake-SQUARE.jpg", "https://www.handletheheat.com/wp-content/uploads/2019/07/Lemon-Cheesecake-SQUARE.jpg", true, "The best Cheese Cake in this part of the world!!", "Lemon Cheese Cake", null, "Tasty as Mummy made it!!" });

            migrationBuilder.InsertData(
                table: "Desserts",
                columns: new[] { "DessertId", "AllergyInformation", "CategoryId", "DessertofWeek", "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { 3, "", 1, true, "https://www.simplyrecipes.com/wp-content/uploads/2005/07/blueberry-cake-vertical-b-1200-768x1152.jpg", "https://www.simplyrecipes.com/wp-content/uploads/2005/07/blueberry-cake-vertical-b-1200-768x1152.jpg", true, "The best Cheese Cake in this part of the world!!", "Blueberry Cheese Cake", null, "Tasty as Mummy made it!!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);
        }
    }
}
