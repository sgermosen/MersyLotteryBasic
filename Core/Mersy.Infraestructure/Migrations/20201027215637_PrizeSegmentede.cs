using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mersy.Infraestructure.Migrations
{
    public partial class PrizeSegmentede : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateFrom",
                table: "PrizePayments");

            migrationBuilder.DropColumn(
                name: "DateFrom",
                table: "DebPayments");

            migrationBuilder.AddColumn<decimal>(
                name: "Prize1",
                table: "LotterySaleItems",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Prize2",
                table: "LotterySaleItems",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Prize3",
                table: "LotterySaleItems",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prize1",
                table: "LotterySaleItems");

            migrationBuilder.DropColumn(
                name: "Prize2",
                table: "LotterySaleItems");

            migrationBuilder.DropColumn(
                name: "Prize3",
                table: "LotterySaleItems");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateFrom",
                table: "PrizePayments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateFrom",
                table: "DebPayments",
                type: "datetime2",
                nullable: true);
        }
    }
}
