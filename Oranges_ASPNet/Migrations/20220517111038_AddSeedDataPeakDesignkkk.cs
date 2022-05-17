using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oranges_ASPNet.Migrations
{
    public partial class AddSeedDataPeakDesignkkk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Category", "Description", "ImgUrl", "Model", "Price" },
                values: new object[,]
                {
                    { 5, 7, 1, "This sleek and modern messenger bag is perfect for your daily journeys. It features premium craftsmanship, world-class organizational compartments and weatherproof construction that's ready to take on anything.", "https://cdn.shopify.com/s/files/1/0058/6514/4418/products/alpha-hero_1020x1200.jpg?v=1636031359", "Alpha Messenger", 144.95m },
                    { 6, 7, 2, "The Elements Backpack is designed with organization in mind: pockets for laptop and tablet space, deep zips to hide things away - the perfect choice whether you're commuting or just grabbing coffee.", "https://cdn.shopify.com/s/files/1/0058/6514/4418/products/elements-backpack-hero2_1020x1200.jpg?v=1633353165", "Elements Backpack", 229.95m },
                    { 7, 7, 2, "The smaller sibling of our iconic 45L Travel Backpack, the 30L is a rugged, expandable daypack ideal for shorter travel and everyday carry. A big, beautiful rear hatch provides total access for easy packing and unpacking.", "https://cdn.shopify.com/s/files/1/2986/1172/products/1-LIGHTBOX-1024x1024-TRBP-BLACK-02_6db62b4c-ff89-4612-9c69-e033a00897c5_1024x1024.jpg?v=1643233483", "Travel Backpack 30L", 154.95m },
                    { 8, 7, 4, "Make the most of every day with Bravo Sling Max (Pro), a slashproof messenger-style sling bag that you can take anywhere. It comes equipped with an adjustable shoulder strap for maximum comfort/minimal stress and a self-locking magnetic buckle - for extra peace of mind.", "https://cdn.shopify.com/s/files/1/0058/6514/4418/products/BravoMaxPro_0000_HeroDark_1020x1200.jpg?v=1639401857", "Bravo Sling Max (PRO)", 135.95m },
                    { 9, 3, 5, "LEVEL8’s Pro Carry-on with Laptop Pocket is another one of our Red Dot award winning luggage. Finely crafted with aerospace-grade Bayer Makrolon. We’ve designed this luggage to be water-resistant, lightweight, and have a durable hard-shell casing to protect your most expensive items. We’ve combined the sense of confidence, intelligence, and sophistication to complement its excellence in functionality. Enhanced with ultra-quite 360° spinner wheels that can handle the cobblestone streets of Europe and ensure a delightful walk to your airport gate number.", "https://cdn.shopify.com/s/files/1/0029/3404/6831/products/2_1800x1800.jpg?v=1644919395", "Pro Carry-On With Laptop Pocket 20", 209.95m },
                    { 10, 3, 5, "One of our best-selling and Red Dot award winning luggage. LEVEL8 Gibraltar Aluminum luggage is finely crafted with Aerospace-grade aluminum magnesium alloy. We’ve made sure our products are designed to promote the sense of intelligence, confidence, and maturity along with excellence in functionality.", "https://cdn.shopify.com/s/files/1/0029/3404/6831/products/aluminumsilver_fd88d170-88cc-4ba1-a35c-ac8f4a47c47b_1800x1800.jpg?v=1606816036", "Full Aluminium Carry-On 20", 399.95m },
                    { 11, 5, 2, "One of our best-selling and Red Dot award winning luggage. LEVEL8 Gibraltar Aluminum luggage is finely crafted with Aerospace-grade aluminum magnesium alloy. We’ve made sure our products are designed to promote the sense of intelligence, confidence, and maturity along with excellence in functionality.", "https://cdn.shopify.com/s/files/1/0051/0368/1570/products/web_prvke_blue_2000x_e9a3b0dc-f040-47e9-8896-232dd98a50de_2000x.jpg?v=1569290940", "Original Prvke", 194.32m }
                });

            migrationBuilder.InsertData(
                table: "ProductStocks",
                columns: new[] { "Id", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 5, 5, 5 },
                    { 6, 6, 5 },
                    { 7, 7, 5 },
                    { 8, 8, 5 },
                    { 9, 9, 5 },
                    { 10, 10, 5 },
                    { 11, 11, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductStocks",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
