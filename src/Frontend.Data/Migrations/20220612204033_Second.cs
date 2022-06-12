using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Frontend.Data.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Title" },
                values: new object[] { 1, "Статья первая" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Title" },
                values: new object[] { 2, "Статья вторая" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
