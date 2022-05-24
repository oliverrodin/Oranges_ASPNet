using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oranges_ASPNet.Migrations
{
    public partial class updateOrderDetailsId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.AddColumn<int>(
                name: "OrderDetailsId",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                column: "OrderDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Id",
                table: "OrderDetails",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_Id",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "OrderDetailsId",
                table: "OrderDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                column: "Id");
        }
    }
}
