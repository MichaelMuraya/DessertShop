using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperbRecipe.Migrations
{
    public partial class ChangeInposition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 2,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { "Might have Soya", 2, "https://upload.wikimedia.org/wikipedia/commons/4/45/A_small_cup_of_coffee.JPG", "https://upload.wikimedia.org/wikipedia/commons/4/45/A_small_cup_of_coffee.JPG", "The best Coffee in this part of the world!!", "Black Coffee", 3.25m, "From the best Hills of Peru!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 3,
                columns: new[] { "AllergyInformation", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { "Has nuts and milk products", "https://cdn.pixabay.com/photo/2017/01/11/11/33/cake-1971552_1280.jpg", "https://cdn.pixabay.com/photo/2017/01/11/11/33/cake-1971552_1280.jpg", "The latest Chocolate Cheese cake in our selection!!", "Chocolate Cheese Cake", 10.50m, "New recipe!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 4,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { "Has nuts,milk products and Soy", 6, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRsBEgwob8e4fUE0fWWA8iM_3hpLAtCA--QREP54h5Y62apcmhO&s", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRsBEgwob8e4fUE0fWWA8iM_3hpLAtCA--QREP54h5Y62apcmhO&s", "The Ice-cream of your choice!!", "Chocolate Icecream", "Best served chilled", 7.25m, "The Only handmade Icecream in town!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 5,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { "Has nuts,milk products and Soy", 7, "https://img.buzzfeed.com/video-api-prod/assets/e1388f70d9d34394a0b9cfabe3f1bae7/BFV21242_Ice_Cream_4_Ways_FB_THUMB.jpg", "https://img.buzzfeed.com/video-api-prod/assets/e1388f70d9d34394a0b9cfabe3f1bae7/BFV21242_Ice_Cream_4_Ways_FB_THUMB.jpg", "The Ice-cream of your choice!!", "Ice-cream mix", "Best served chilled", 20.25m, "The Only handmade Icecream in town!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 7,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { "", 4, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQOfcvrFzYKIG8vjeSMmPPqw3iMSCyAQl9GcrA8DOYS1KvXOV08Uw&s", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQOfcvrFzYKIG8vjeSMmPPqw3iMSCyAQl9GcrA8DOYS1KvXOV08Uw&s", "Get your Vitamins on the go!!", "Smoothies", 10.15m, "Refreshing!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 8,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { "", 5, "C:\\Users\\35840\\Desktop\\SuperbRecipe\\SuperbRecipe\\SuperbRecipe\\wwwroot\\Delish\\blueberry1.jpg", "C:\\Users\\35840\\Desktop\\SuperbRecipe\\SuperbRecipe\\SuperbRecipe\\wwwroot\\Delish\\blueberry1.jpg", "The best Cheese Cake in this part of the world!!", "Blueberry Cheese Cake", null, 15.35m, "Tasty as Mummy made it!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 9,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { "", 5, "https://www.handletheheat.com/wp-content/uploads/2019/07/Lemon-Cheesecake-SQUARE.jpg", "https://www.handletheheat.com/wp-content/uploads/2019/07/Lemon-Cheesecake-SQUARE.jpg", "The best Cheese Cake in this part of the world!!", "Lemon Cheese Cake", null, 14.25m, "Tasty as Mummy made it!!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 2,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { "", 5, "https://www.handletheheat.com/wp-content/uploads/2019/07/Lemon-Cheesecake-SQUARE.jpg", "https://www.handletheheat.com/wp-content/uploads/2019/07/Lemon-Cheesecake-SQUARE.jpg", "The best Cheese Cake in this part of the world!!", "Lemon Cheese Cake", 14.25m, "Tasty as Mummy made it!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 3,
                columns: new[] { "AllergyInformation", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { "", "C:\\Users\\35840\\Desktop\\SuperbRecipe\\SuperbRecipe\\SuperbRecipe\\wwwroot\\Delish\\blueberry1.jpg", "C:\\Users\\35840\\Desktop\\SuperbRecipe\\SuperbRecipe\\SuperbRecipe\\wwwroot\\Delish\\blueberry1.jpg", "The best Cheese Cake in this part of the world!!", "Blueberry Cheese Cake", 15.35m, "Tasty as Mummy made it!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 4,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { "", 4, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQOfcvrFzYKIG8vjeSMmPPqw3iMSCyAQl9GcrA8DOYS1KvXOV08Uw&s", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQOfcvrFzYKIG8vjeSMmPPqw3iMSCyAQl9GcrA8DOYS1KvXOV08Uw&s", "Get your Vitamins on the go!!", "Smoothies", null, 10.15m, "Refreshing!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 5,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { "Might have Soya", 2, "https://upload.wikimedia.org/wikipedia/commons/4/45/A_small_cup_of_coffee.JPG", "https://upload.wikimedia.org/wikipedia/commons/4/45/A_small_cup_of_coffee.JPG", "The best Coffee in this part of the world!!", "Black Coffee", null, 3.25m, "From the best Hills of Peru!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 7,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { "Has nuts and milk products", 5, "https://cdn.pixabay.com/photo/2017/01/11/11/33/cake-1971552_1280.jpg", "https://cdn.pixabay.com/photo/2017/01/11/11/33/cake-1971552_1280.jpg", "The latest Chocolate Cheese cake in our selection!!", "Chocolate Cheese Cake", 10.50m, "New recipe!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 8,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { "Has nuts,milk products and Soy", 6, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRsBEgwob8e4fUE0fWWA8iM_3hpLAtCA--QREP54h5Y62apcmhO&s", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRsBEgwob8e4fUE0fWWA8iM_3hpLAtCA--QREP54h5Y62apcmhO&s", "The Ice-cream of your choice!!", "Chocolate Icecream", "Best served chilled", 7.25m, "The Only handmade Icecream in town!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 9,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { "Has nuts,milk products and Soy", 7, "https://img.buzzfeed.com/video-api-prod/assets/e1388f70d9d34394a0b9cfabe3f1bae7/BFV21242_Ice_Cream_4_Ways_FB_THUMB.jpg", "https://img.buzzfeed.com/video-api-prod/assets/e1388f70d9d34394a0b9cfabe3f1bae7/BFV21242_Ice_Cream_4_Ways_FB_THUMB.jpg", "The Ice-cream of your choice!!", "Ice-cream mix", "Best served chilled", 20.25m, "The Only handmade Icecream in town!!" });
        }
    }
}
