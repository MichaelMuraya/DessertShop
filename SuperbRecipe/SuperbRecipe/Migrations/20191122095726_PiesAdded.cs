using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperbRecipe.Migrations
{
    public partial class PiesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 11,
                columns: new[] { "Name", "Notes", "Price" },
                values: new object[] { "Spinach-mushroom pie", "Best served warm", 11.25m });

            migrationBuilder.InsertData(
                table: "Desserts",
                columns: new[] { "DessertId", "AllergyInformation", "CategoryId", "DessertofWeek", "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { 12, "Has nuts,milk products and Soy", 3, true, "https://www.tasteofhome.com/wp-content/uploads/2018/01/Easy-Fresh-Strawberry-Pie_EXPS_TMBBP19_34179_B06_20_3b.jpg", "https://www.tasteofhome.com/wp-content/uploads/2018/01/Easy-Fresh-Strawberry-Pie_EXPS_TMBBP19_34179_B06_20_3b.jpg", true, "THe strawberries make it all worth it!!", "Strawberry Pie", "Best served warm with milk", 7.25m, "Freshly picked Strawberries!!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 11,
                columns: new[] { "Name", "Notes", "Price" },
                values: new object[] { "Caramel Ice-cream mix", "Best served chilled", 9.25m });
        }
    }
}
