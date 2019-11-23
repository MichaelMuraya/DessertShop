﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperbRecipe.Migrations
{
    public partial class ApplePie2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

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
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "Desserts",
                columns: new[] { "DessertId", "AllergyInformation", "CategoryId", "DessertofWeek", "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { 6, "Has nuts", 1, true, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQJcrw2yrDOv-NeBY1LbCJUFCk6mrzAb9YrbKHpJwO_7TPi0D3-7w&s", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQJcrw2yrDOv-NeBY1LbCJUFCk6mrzAb9YrbKHpJwO_7TPi0D3-7w&s", true, "The latest Apple Pie in our selection!!", "Apple Pie", null, 10.35m, "New recipe!!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 6);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 2, "Cheese cakes", null },
                    { 3, "Seasonal pies", null },
                    { 4, "Smoothies", null },
                    { 5, "Coffee", null }
                });

            migrationBuilder.InsertData(
                table: "Desserts",
                columns: new[] { "DessertId", "AllergyInformation", "CategoryId", "DessertofWeek", "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { 1, "", 1, true, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTxiyuVFw8XkdS6iKbDo0W9jiUwKiZ64BNDVlb9sO7pN4b1cPPRBw&s", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTxiyuVFw8XkdS6iKbDo0W9jiUwKiZ64BNDVlb9sO7pN4b1cPPRBw&s", true, "The best Apple pie in town reminds you of Christmas in Lapland!!", "Apple Pie", null, 12.35m, "Awesome pies!!" });

            migrationBuilder.InsertData(
                table: "Desserts",
                columns: new[] { "DessertId", "AllergyInformation", "CategoryId", "DessertofWeek", "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 2, "", 2, true, "https://www.handletheheat.com/wp-content/uploads/2019/07/Lemon-Cheesecake-SQUARE.jpg", "https://www.handletheheat.com/wp-content/uploads/2019/07/Lemon-Cheesecake-SQUARE.jpg", true, "The best Cheese Cake in this part of the world!!", "Lemon Cheese Cake", null, 14.25m, "Tasty as Mummy made it!!" },
                    { 5, "Might have Soya", 2, true, "https://upload.wikimedia.org/wikipedia/commons/4/45/A_small_cup_of_coffee.JPG", "https://upload.wikimedia.org/wikipedia/commons/4/45/A_small_cup_of_coffee.JPG", true, "The best Coffee in this part of the world!!", "Black Coffee", null, 3.25m, "From the best Hills of Peru!!" },
                    { 3, "", 3, true, "https://www.simplyrecipes.com/wp-content/uploads/2005/07/blueberry-cake-vertical-b-1200-768x1152.jpg", "https://www.simplyrecipes.com/wp-content/uploads/2005/07/blueberry-cake-vertical-b-1200-768x1152.jpg", true, "The best Cheese Cake in this part of the world!!", "Blueberry Cheese Cake", null, 15.35m, "Tasty as Mummy made it!!" },
                    { 4, "", 4, true, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQOfcvrFzYKIG8vjeSMmPPqw3iMSCyAQl9GcrA8DOYS1KvXOV08Uw&s", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQOfcvrFzYKIG8vjeSMmPPqw3iMSCyAQl9GcrA8DOYS1KvXOV08Uw&s", true, "Get your Vitamins on the go!!", "Smoothies", null, 10.15m, "Refreshing!!" }
                });
        }
    }
}
