using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oranges_ASPNet.Migrations
{
    public partial class seedadress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "City", "Country", "FirstName", "LastName", "State", "Street", "Zip" },
                values: new object[] { 1, "Hudiksvall", "Sverige", "Admin", "Bagtopia", "Gävleborg", "Storgatan 23", "82430" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "City", "Country", "FirstName", "LastName", "State", "Street", "Zip" },
                values: new object[] { 2, "Hudiksvall", "Sverige", "User", "Bagtopia", "Gävleborg", "User street 23", "82430" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 2);
        }
    }
}
