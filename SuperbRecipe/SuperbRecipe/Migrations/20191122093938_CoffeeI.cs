using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperbRecipe.Migrations
{
    public partial class CoffeeI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 6,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { "Might have Soya", 2, "https://upload.wikimedia.org/wikipedia/commons/4/45/A_small_cup_of_coffee.JPG", "https://upload.wikimedia.org/wikipedia/commons/4/45/A_small_cup_of_coffee.JPG", "The best Coffee in this part of the world!!", "Black Coffee", 3.25m, "From the best Hills of Peru!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 9,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { "", 4, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQOfcvrFzYKIG8vjeSMmPPqw3iMSCyAQl9GcrA8DOYS1KvXOV08Uw&s", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQOfcvrFzYKIG8vjeSMmPPqw3iMSCyAQl9GcrA8DOYS1KvXOV08Uw&s", "Get your Vitamins on the go!!", "Smoothies", 10.15m, "Refreshing!!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 6,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { "", 4, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQOfcvrFzYKIG8vjeSMmPPqw3iMSCyAQl9GcrA8DOYS1KvXOV08Uw&s", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQOfcvrFzYKIG8vjeSMmPPqw3iMSCyAQl9GcrA8DOYS1KvXOV08Uw&s", "Get your Vitamins on the go!!", "Smoothies", 10.15m, "Refreshing!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 9,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { "Might have Soya", 2, "https://upload.wikimedia.org/wikipedia/commons/4/45/A_small_cup_of_coffee.JPG", "https://upload.wikimedia.org/wikipedia/commons/4/45/A_small_cup_of_coffee.JPG", "The best Coffee in this part of the world!!", "Black Coffee", 3.25m, "From the best Hills of Peru!!" });
        }
    }
}
