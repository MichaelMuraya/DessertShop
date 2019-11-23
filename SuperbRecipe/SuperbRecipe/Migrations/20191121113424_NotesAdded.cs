using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperbRecipe.Migrations
{
    public partial class NotesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 1,
                column: "Notes",
                value: "Put two spoonfuls of sugar in a a bowl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 1,
                column: "Notes",
                value: null);
        }
    }
}
