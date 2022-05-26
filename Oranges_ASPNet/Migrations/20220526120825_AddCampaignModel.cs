using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oranges_ASPNet.Migrations
{
    public partial class AddCampaignModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCampaign_ProductCampaignId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCampaign",
                table: "ProductCampaign");

            migrationBuilder.RenameTable(
                name: "ProductCampaign",
                newName: "Campaigns");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Campaigns",
                table: "Campaigns",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Campaigns_ProductCampaignId",
                table: "Products",
                column: "ProductCampaignId",
                principalTable: "Campaigns",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Campaigns_ProductCampaignId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Campaigns",
                table: "Campaigns");

            migrationBuilder.RenameTable(
                name: "Campaigns",
                newName: "ProductCampaign");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCampaign",
                table: "ProductCampaign",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCampaign_ProductCampaignId",
                table: "Products",
                column: "ProductCampaignId",
                principalTable: "ProductCampaign",
                principalColumn: "Id");
        }
    }
}
