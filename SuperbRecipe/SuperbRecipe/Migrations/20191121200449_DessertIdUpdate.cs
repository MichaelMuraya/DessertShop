using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperbRecipe.Migrations
{
    public partial class DessertIdUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Desserts_DessertId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "PieId",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<int>(
                name: "DessertId",
                table: "OrderDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Desserts_DessertId",
                table: "OrderDetails",
                column: "DessertId",
                principalTable: "Desserts",
                principalColumn: "DessertId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Desserts_DessertId",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<int>(
                name: "DessertId",
                table: "OrderDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "PieId",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Desserts_DessertId",
                table: "OrderDetails",
                column: "DessertId",
                principalTable: "Desserts",
                principalColumn: "DessertId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
