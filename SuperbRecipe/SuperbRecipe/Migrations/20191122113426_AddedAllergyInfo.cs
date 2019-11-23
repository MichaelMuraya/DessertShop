using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperbRecipe.Migrations
{
    public partial class AddedAllergyInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SendOrderDetails_SendOrder_SendOrderId",
                table: "SendOrderDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SendOrder",
                table: "SendOrder");

            migrationBuilder.RenameTable(
                name: "SendOrder",
                newName: "SendOrders");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SendOrders",
                table: "SendOrders",
                column: "SendOrderId");

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 3,
                column: "AllergyInformation",
                value: "Has Wheat and milk products");

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 5,
                column: "AllergyInformation",
                value: "Has berries and milk products");

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 11,
                column: "AllergyInformation",
                value: "Has nuts and milk products");

            migrationBuilder.AddForeignKey(
                name: "FK_SendOrderDetails_SendOrders_SendOrderId",
                table: "SendOrderDetails",
                column: "SendOrderId",
                principalTable: "SendOrders",
                principalColumn: "SendOrderId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SendOrderDetails_SendOrders_SendOrderId",
                table: "SendOrderDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SendOrders",
                table: "SendOrders");

            migrationBuilder.RenameTable(
                name: "SendOrders",
                newName: "SendOrder");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SendOrder",
                table: "SendOrder",
                column: "SendOrderId");

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 3,
                column: "AllergyInformation",
                value: "");

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 5,
                column: "AllergyInformation",
                value: "");

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "DessertId",
                keyValue: 11,
                column: "AllergyInformation",
                value: "");

            migrationBuilder.AddForeignKey(
                name: "FK_SendOrderDetails_SendOrder_SendOrderId",
                table: "SendOrderDetails",
                column: "SendOrderId",
                principalTable: "SendOrder",
                principalColumn: "SendOrderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
