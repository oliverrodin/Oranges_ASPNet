using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oranges_ASPNet.Migrations
{
    public partial class AddSeedDataPeakDesign : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Category", "Description", "ImgUrl", "Model", "Price" },
                values: new object[] { 2, 1, 1, "The all-new Everyday Messenger is the latest rev of our original award-winning everyday and photo carry workhorse—the bag that we designed with renowned photographer Trey Ratcliff and honed with the feedback of thousands of customers.", "https://cdn.shopify.com/s/files/1/2986/1172/products/black-EDMbl01_1024x1024.jpg?v=1574661040", "Everyday Messenger", 229.95m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Category", "Description", "ImgUrl", "Model", "Price" },
                values: new object[] { 3, 1, 3, "The 65L Duffel is a monster gear-hauler, ruggedly dependable for airline check-in and road trips. Both bags feature removable padded top handles, a removable padded shoulder strap, 2 internal mesh pockets, and 4 external side pockets for added organization.", "https://cdn.shopify.com/s/files/1/2986/1172/products/1-PDP-Lightbox-Duffel65-BLACK-01-edit_1024x1024.jpg?v=1644352278", "Travel Duffel", 169.95m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Category", "Description", "ImgUrl", "Model", "Price" },
                values: new object[] { 4, 1, 2, "The smaller sibling of our iconic 45L Travel Backpack, the 30L is a rugged, expandable daypack ideal for shorter travel and everyday carry. A big, beautiful rear hatch provides total access for easy packing and unpacking.", "https://cdn.shopify.com/s/files/1/2986/1172/products/1-LIGHTBOX-1024x1024-TRBP-BLACK-02_6db62b4c-ff89-4612-9c69-e033a00897c5_1024x1024.jpg?v=1643233483", "Travel Backpack 30L", 229.95m });

            migrationBuilder.InsertData(
                table: "ProductStocks",
                columns: new[] { "Id", "ProductId", "Quantity" },
                values: new object[] { 2, 2, 5 });

            migrationBuilder.InsertData(
                table: "ProductStocks",
                columns: new[] { "Id", "ProductId", "Quantity" },
                values: new object[] { 3, 3, 5 });

            migrationBuilder.InsertData(
                table: "ProductStocks",
                columns: new[] { "Id", "ProductId", "Quantity" },
                values: new object[] { 4, 4, 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
