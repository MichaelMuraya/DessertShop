using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperbRecipe.Migrations
{
    public partial class PictureAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTxiyuVFw8XkdS6iKbDo0W9jiUwKiZ64BNDVlb9sO7pN4b1cPPRBw&s", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTxiyuVFw8XkdS6iKbDo0W9jiUwKiZ64BNDVlb9sO7pN4b1cPPRBw&s" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.handletheheat.com/wp-content/uploads/2019/07/Lemon-Cheesecake-SQUARE.jpg", "https://www.handletheheat.com/wp-content/uploads/2019/07/Lemon-Cheesecake-SQUARE.jpg" });
        }
    }
}
