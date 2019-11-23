using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperbRecipe.Migrations
{
    public partial class IceCreamAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 6, "Ice-Cream", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 7, "Offers", null });

            migrationBuilder.InsertData(
                table: "Desserts",
                columns: new[] { "DessertId", "AllergyInformation", "CategoryId", "DessertofWeek", "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { 7, "Has nuts and milk products", 2, true, "https://cdn.pixabay.com/photo/2017/01/11/11/33/cake-1971552_1280.jpg", "https://cdn.pixabay.com/photo/2017/01/11/11/33/cake-1971552_1280.jpg", true, "The latest Chocolate Cheese cake in our selection!!", "Chocolate Cheese Cake", null, 10.50m, "New recipe!!" });

            migrationBuilder.InsertData(
                table: "Desserts",
                columns: new[] { "DessertId", "AllergyInformation", "CategoryId", "DessertofWeek", "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { 8, "Has nuts,milk products and Soy", 6, true, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRsBEgwob8e4fUE0fWWA8iM_3hpLAtCA--QREP54h5Y62apcmhO&s", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRsBEgwob8e4fUE0fWWA8iM_3hpLAtCA--QREP54h5Y62apcmhO&s", true, "The Ice-cream of your choice!!", "Chocolate Icecream", "Best served chilled", 7.25m, "The Only handmade Icecream in town!!" });

            migrationBuilder.InsertData(
                table: "Desserts",
                columns: new[] { "DessertId", "AllergyInformation", "CategoryId", "DessertofWeek", "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { 9, "Has nuts,milk products and Soy", 7, true, "https://img.buzzfeed.com/video-api-prod/assets/e1388f70d9d34394a0b9cfabe3f1bae7/BFV21242_Ice_Cream_4_Ways_FB_THUMB.jpg", "https://img.buzzfeed.com/video-api-prod/assets/e1388f70d9d34394a0b9cfabe3f1bae7/BFV21242_Ice_Cream_4_Ways_FB_THUMB.jpg", true, "The Ice-cream of your choice!!", "Ice-cream mix", "Best served chilled", 20.25m, "The Only handmade Icecream in town!!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7);
        }
    }
}
