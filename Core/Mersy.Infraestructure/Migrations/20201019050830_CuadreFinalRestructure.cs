using Microsoft.EntityFrameworkCore.Migrations;

namespace Mersy.Infraestructure.Migrations
{
    public partial class CuadreFinalRestructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Balance",
                table: "CuadreItems");

            migrationBuilder.DropColumn(
                name: "ReceivedPaid",
                table: "CuadreItems");

            migrationBuilder.DropColumn(
                name: "SubTotal",
                table: "CuadreItems");

            migrationBuilder.DropColumn(
                name: "TotalToPaid",
                table: "CuadreItems");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Balance",
                table: "CuadreItems",
                type: "decimal(12,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ReceivedPaid",
                table: "CuadreItems",
                type: "decimal(12,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SubTotal",
                table: "CuadreItems",
                type: "decimal(12,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalToPaid",
                table: "CuadreItems",
                type: "decimal(12,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
