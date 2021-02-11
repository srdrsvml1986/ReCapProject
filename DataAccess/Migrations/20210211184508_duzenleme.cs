using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class duzenleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "dateTime",
                table: "Rentals",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Colors",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Brands",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Rentals",
                newName: "dateTime");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Colors",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Brands",
                newName: "ID");
        }
    }
}
