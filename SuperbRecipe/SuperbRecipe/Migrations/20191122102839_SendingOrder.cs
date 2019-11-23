using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperbRecipe.Migrations
{
    public partial class SendingOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SendOrder",
                columns: table => new
                {
                    SendOrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantName = table.Column<string>(maxLength: 50, nullable: false),
                    SendersName = table.Column<string>(maxLength: 50, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    Country = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 25, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Url = table.Column<string>(nullable: true),
                    OrderPlaced = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SendOrder", x => x.SendOrderId);
                });

            migrationBuilder.CreateTable(
                name: "SendOrderDetails",
                columns: table => new
                {
                    SendOrderDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SendOrderId = table.Column<int>(nullable: false),
                    DessertId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SendOrderDetails", x => x.SendOrderDetailId);
                    table.ForeignKey(
                        name: "FK_SendOrderDetails_Desserts_DessertId",
                        column: x => x.DessertId,
                        principalTable: "Desserts",
                        principalColumn: "DessertId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SendOrderDetails_SendOrder_SendOrderId",
                        column: x => x.SendOrderId,
                        principalTable: "SendOrder",
                        principalColumn: "SendOrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SendOrderDetails_DessertId",
                table: "SendOrderDetails",
                column: "DessertId");

            migrationBuilder.CreateIndex(
                name: "IX_SendOrderDetails_SendOrderId",
                table: "SendOrderDetails",
                column: "SendOrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SendOrderDetails");

            migrationBuilder.DropTable(
                name: "SendOrder");
        }
    }
}
