using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TemelApi.Migrations
{
    public partial class royal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Beatiful Car", "Car" },
                    { 2, "Perfect Cup", "Cup" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Age", "Description", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, 21, "Hello World", "Royal", "Humbetov" },
                    { 2, 18, "Salamlar", "Xeyal", "Humbetli" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ProductDescription", "ProductName" },
                values: new object[,]
                {
                    { 1, "humbatov", "Test" },
                    { 2, "EOFVJE9IO", "AJHCBSIUDV" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
