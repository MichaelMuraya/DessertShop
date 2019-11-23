using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperbRecipe.Migrations
{
    public partial class ChangedOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 1,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { "Has nuts,milk products and Soy", 7, "https://img.buzzfeed.com/video-api-prod/assets/e1388f70d9d34394a0b9cfabe3f1bae7/BFV21242_Ice_Cream_4_Ways_FB_THUMB.jpg", "https://img.buzzfeed.com/video-api-prod/assets/e1388f70d9d34394a0b9cfabe3f1bae7/BFV21242_Ice_Cream_4_Ways_FB_THUMB.jpg", "The Ice-cream of your choice!!", "Ice-cream mix", "Best served chilled", 20.25m, "The Only handmade Icecream in town!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 2,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { "Has nuts", 1, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQJcrw2yrDOv-NeBY1LbCJUFCk6mrzAb9YrbKHpJwO_7TPi0D3-7w&s", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQJcrw2yrDOv-NeBY1LbCJUFCk6mrzAb9YrbKHpJwO_7TPi0D3-7w&s", "The latest Apple Pie in our selection!!", "Apple Pie", 10.35m, "New recipe!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 3,
                columns: new[] { "AllergyInformation", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { "", "https://www.handletheheat.com/wp-content/uploads/2019/07/Lemon-Cheesecake-SQUARE.jpg", "https://www.handletheheat.com/wp-content/uploads/2019/07/Lemon-Cheesecake-SQUARE.jpg", "The best Cheese Cake in this part of the world!!", "Lemon Cheese Cake", 14.25m, "Tasty as Mummy made it!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 4,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { "Has nuts", 1, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRmLWlSefb8vZKA0iFQzLXkPCEpg2UL0Lt4JylQBRoUBvsc-d8N&s", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRmLWlSefb8vZKA0iFQzLXkPCEpg2UL0Lt4JylQBRoUBvsc-d8N&s", "The Pies reimd you of Christmas in Lapland!!", "Apple Pie", "Put two spoonfuls of sugar in a a bowl", 12.35m, "The Best Apple Pies in Town!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 5,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { "Has nuts and milk products", 5, "https://cdn.pixabay.com/photo/2017/01/11/11/33/cake-1971552_1280.jpg", "https://cdn.pixabay.com/photo/2017/01/11/11/33/cake-1971552_1280.jpg", "The latest Chocolate Cheese cake in our selection!!", "Chocolate Cheese Cake", null, 10.50m, "New recipe!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 6,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { "", 4, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQOfcvrFzYKIG8vjeSMmPPqw3iMSCyAQl9GcrA8DOYS1KvXOV08Uw&s", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQOfcvrFzYKIG8vjeSMmPPqw3iMSCyAQl9GcrA8DOYS1KvXOV08Uw&s", "Get your Vitamins on the go!!", "Smoothies", 10.15m, "Refreshing!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 7,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { "Has nuts,milk products and Soy", 6, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRsBEgwob8e4fUE0fWWA8iM_3hpLAtCA--QREP54h5Y62apcmhO&s", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRsBEgwob8e4fUE0fWWA8iM_3hpLAtCA--QREP54h5Y62apcmhO&s", "The Ice-cream of your choice!!", "Chocolate Icecream", "Best served chilled", 7.25m, "The Only handmade Icecream in town!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 9,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { "Might have Soya", 2, "https://upload.wikimedia.org/wikipedia/commons/4/45/A_small_cup_of_coffee.JPG", "https://upload.wikimedia.org/wikipedia/commons/4/45/A_small_cup_of_coffee.JPG", "The best Coffee in this part of the world!!", "Black Coffee", 3.25m, "From the best Hills of Peru!!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 1,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { "Has nuts", 1, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRmLWlSefb8vZKA0iFQzLXkPCEpg2UL0Lt4JylQBRoUBvsc-d8N&s", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRmLWlSefb8vZKA0iFQzLXkPCEpg2UL0Lt4JylQBRoUBvsc-d8N&s", "The Pies reimd you of Christmas in Lapland!!", "Apple Pie", "Put two spoonfuls of sugar in a a bowl", 12.35m, "The Best Apple Pies in Town!!" });

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
                keyValue: 6,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { "Has nuts", 1, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQJcrw2yrDOv-NeBY1LbCJUFCk6mrzAb9YrbKHpJwO_7TPi0D3-7w&s", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQJcrw2yrDOv-NeBY1LbCJUFCk6mrzAb9YrbKHpJwO_7TPi0D3-7w&s", "The latest Apple Pie in our selection!!", "Apple Pie", 10.35m, "New recipe!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 7,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { "", 4, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQOfcvrFzYKIG8vjeSMmPPqw3iMSCyAQl9GcrA8DOYS1KvXOV08Uw&s", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQOfcvrFzYKIG8vjeSMmPPqw3iMSCyAQl9GcrA8DOYS1KvXOV08Uw&s", "Get your Vitamins on the go!!", "Smoothies", null, 10.15m, "Refreshing!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 9,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { "", 5, "https://www.handletheheat.com/wp-content/uploads/2019/07/Lemon-Cheesecake-SQUARE.jpg", "https://www.handletheheat.com/wp-content/uploads/2019/07/Lemon-Cheesecake-SQUARE.jpg", "The best Cheese Cake in this part of the world!!", "Lemon Cheese Cake", 14.25m, "Tasty as Mummy made it!!" });
        }
    }
}
