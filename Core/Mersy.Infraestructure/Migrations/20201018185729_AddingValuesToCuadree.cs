using Microsoft.EntityFrameworkCore.Migrations;

namespace Mersy.Infraestructure.Migrations
{
    public partial class AddingValuesToCuadree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Balance",
                table: "Cuadres",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PreviousDeb",
                table: "Cuadres",
                type: "decimal(12,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ReceivedPaid",
                table: "Cuadres",
                type: "decimal(12,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SubTotal",
                table: "Cuadres",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalToPaid",
                table: "Cuadres",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Cuadres");

            migrationBuilder.DropColumn(
                name: "PreviousDeb",
                table: "Cuadres");

            migrationBuilder.DropColumn(
                name: "ReceivedPaid",
                table: "Cuadres");

            migrationBuilder.DropColumn(
                name: "SubTotal",
                table: "Cuadres");

            migrationBuilder.DropColumn(
                name: "TotalToPaid",
                table: "Cuadres");
        }
    }
}
