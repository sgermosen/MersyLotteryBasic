using Microsoft.EntityFrameworkCore.Migrations;

namespace Mersy.Infraestructure.Migrations
{
    public partial class GettingTickets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountTe",
                table: "LotterySales");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalAmount",
                table: "LotterySales",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AddColumn<decimal>(
                name: "Prize",
                table: "LotterySales",
                type: "decimal(12,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "WasPaid",
                table: "LotterySales",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prize",
                table: "LotterySales");

            migrationBuilder.DropColumn(
                name: "WasPaid",
                table: "LotterySales");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalAmount",
                table: "LotterySales",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AddColumn<decimal>(
                name: "AmountTe",
                table: "LotterySales",
                type: "decimal(12,2)",
                nullable: true);
        }
    }
}
