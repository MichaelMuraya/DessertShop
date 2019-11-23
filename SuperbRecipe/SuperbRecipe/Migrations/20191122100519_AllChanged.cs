using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperbRecipe.Migrations
{
    public partial class AllChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "AllergyInformation", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { "", "https://sugargeekshow.com/wp-content/uploads/2019/05/lemon-blueberry-cake-featured.jpg", "https://sugargeekshow.com/wp-content/uploads/2019/05/lemon-blueberry-cake-featured.jpg", "The best Cheese Cake in this part of the world!!", "Blueberry Cheese Cake", 15.35m, "Tasty as Mummy made it!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 6,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { "Has nuts,milk products and Soy", 3, "https://www.tasteofhome.com/wp-content/uploads/2018/01/Easy-Fresh-Strawberry-Pie_EXPS_TMBBP19_34179_B06_20_3b.jpg", "https://www.tasteofhome.com/wp-content/uploads/2018/01/Easy-Fresh-Strawberry-Pie_EXPS_TMBBP19_34179_B06_20_3b.jpg", "THe strawberries make it all worth it!!", "Strawberry Pie", "Best served warm with milk", 7.25m, "Freshly picked Strawberries!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 7,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { "Has nuts", 1, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRmLWlSefb8vZKA0iFQzLXkPCEpg2UL0Lt4JylQBRoUBvsc-d8N&s", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRmLWlSefb8vZKA0iFQzLXkPCEpg2UL0Lt4JylQBRoUBvsc-d8N&s", "The Pies reimd you of Christmas in Lapland!!", "Apple Pie", "Put two spoonfuls of sugar in a a bowl", 12.35m, "The Best Apple Pies in Town!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 8,
                columns: new[] { "AllergyInformation", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { "Has nuts and milk products", "https://cdn.pixabay.com/photo/2017/01/11/11/33/cake-1971552_1280.jpg", "https://cdn.pixabay.com/photo/2017/01/11/11/33/cake-1971552_1280.jpg", "The latest Chocolate Cheese cake in our selection!!", "Chocolate Cheese Cake", 10.50m, "New recipe!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 9,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { "Has nuts,milk products and Soy", 3, "https://www.bbcgoodfood.com/sites/default/files/recipe-collections/collection-image/2013/05/chicken-kale-mushroom-pot-pie.jpg", "https://www.bbcgoodfood.com/sites/default/files/recipe-collections/collection-image/2013/05/chicken-kale-mushroom-pot-pie.jpg", "The Ice-cream of your choice!!", "Spinach-mushroom pie", "Best served warm", 11.25m, "The Only handmade Icecream in town!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 10,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { "Might have Soya", 2, "https://upload.wikimedia.org/wikipedia/commons/4/45/A_small_cup_of_coffee.JPG", "https://upload.wikimedia.org/wikipedia/commons/4/45/A_small_cup_of_coffee.JPG", "The best Coffee in this part of the world!!", "Black Coffee", null, 3.25m, "From the best Hills of Peru!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 11,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { "", 4, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQOfcvrFzYKIG8vjeSMmPPqw3iMSCyAQl9GcrA8DOYS1KvXOV08Uw&s", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQOfcvrFzYKIG8vjeSMmPPqw3iMSCyAQl9GcrA8DOYS1KvXOV08Uw&s", "Get your Vitamins on the go!!", "Smoothies", null, 10.15m, "Refreshing!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 12,
                columns: new[] { "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { 6, "https://www.loveandoliveoil.com/wp-content/uploads/2016/09/caramel-cookie-ice-creamH2-1200x550.jpg", "https://www.loveandoliveoil.com/wp-content/uploads/2016/09/caramel-cookie-ice-creamH2-1200x550.jpg", "The Ice-cream of your choice!!", "Caramel Ice-cream mix", "Best served chilled", 9.25m, "The Only handmade Icecream in town!!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "AllergyInformation", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { "Has nuts and milk products", "https://cdn.pixabay.com/photo/2017/01/11/11/33/cake-1971552_1280.jpg", "https://cdn.pixabay.com/photo/2017/01/11/11/33/cake-1971552_1280.jpg", "The latest Chocolate Cheese cake in our selection!!", "Chocolate Cheese Cake", 10.50m, "New recipe!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 6,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { "Might have Soya", 2, "https://upload.wikimedia.org/wikipedia/commons/4/45/A_small_cup_of_coffee.JPG", "https://upload.wikimedia.org/wikipedia/commons/4/45/A_small_cup_of_coffee.JPG", "The best Coffee in this part of the world!!", "Black Coffee", null, 3.25m, "From the best Hills of Peru!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 7,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { "Has nuts,milk products and Soy", 6, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRsBEgwob8e4fUE0fWWA8iM_3hpLAtCA--QREP54h5Y62apcmhO&s", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRsBEgwob8e4fUE0fWWA8iM_3hpLAtCA--QREP54h5Y62apcmhO&s", "The Ice-cream of your choice!!", "Chocolate Icecream", "Best served chilled", 7.25m, "The Only handmade Icecream in town!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 8,
                columns: new[] { "AllergyInformation", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { "", "https://sugargeekshow.com/wp-content/uploads/2019/05/lemon-blueberry-cake-featured.jpg", "https://sugargeekshow.com/wp-content/uploads/2019/05/lemon-blueberry-cake-featured.jpg", "The best Cheese Cake in this part of the world!!", "Blueberry Cheese Cake", 15.35m, "Tasty as Mummy made it!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 9,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { "", 4, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQOfcvrFzYKIG8vjeSMmPPqw3iMSCyAQl9GcrA8DOYS1KvXOV08Uw&s", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQOfcvrFzYKIG8vjeSMmPPqw3iMSCyAQl9GcrA8DOYS1KvXOV08Uw&s", "Get your Vitamins on the go!!", "Smoothies", null, 10.15m, "Refreshing!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 10,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { "Has nuts,milk products and Soy", 6, "https://www.loveandoliveoil.com/wp-content/uploads/2016/09/caramel-cookie-ice-creamH2-1200x550.jpg", "https://www.loveandoliveoil.com/wp-content/uploads/2016/09/caramel-cookie-ice-creamH2-1200x550.jpg", "The Ice-cream of your choice!!", "Caramel Ice-cream mix", "Best served chilled", 9.25m, "The Only handmade Icecream in town!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 11,
                columns: new[] { "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { "Has nuts,milk products and Soy", 3, "https://www.bbcgoodfood.com/sites/default/files/recipe-collections/collection-image/2013/05/chicken-kale-mushroom-pot-pie.jpg", "https://www.bbcgoodfood.com/sites/default/files/recipe-collections/collection-image/2013/05/chicken-kale-mushroom-pot-pie.jpg", "The Ice-cream of your choice!!", "Spinach-mushroom pie", "Best served warm", 11.25m, "The Only handmade Icecream in town!!" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 12,
                columns: new[] { "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { 3, "https://www.tasteofhome.com/wp-content/uploads/2018/01/Easy-Fresh-Strawberry-Pie_EXPS_TMBBP19_34179_B06_20_3b.jpg", "https://www.tasteofhome.com/wp-content/uploads/2018/01/Easy-Fresh-Strawberry-Pie_EXPS_TMBBP19_34179_B06_20_3b.jpg", "THe strawberries make it all worth it!!", "Strawberry Pie", "Best served warm with milk", 7.25m, "Freshly picked Strawberries!!" });
        }
    }
}
