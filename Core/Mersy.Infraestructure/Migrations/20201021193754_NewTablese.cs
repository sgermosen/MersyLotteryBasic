using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mersy.Infraestructure.Migrations
{
    public partial class NewTablese : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_CashierDetails_CashierDetailId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_PaymentTypes_PaymentTypeId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_CashierDetailId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_PaymentTypeId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "AmountCheck",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "AmountNc",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "AmountTc",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "AmountTe",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Bank",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "BuildDate",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "CashierDetailId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "NoCheque",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Owner",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "PaymentTypeId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "WhoPay",
                table: "Payments");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Payments",
                newName: "Amountx");

            migrationBuilder.AddColumn<decimal>(
                name: "ComissionAmount",
                table: "Payments",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SupervisorAmount",
                table: "Payments",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTo",
                table: "Cuadres",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateFrom",
                table: "Cuadres",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<decimal>(
                name: "ComissionAmount",
                table: "CashierDetails",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SupervisorAmount",
                table: "CashierDetails",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ComissionAmount",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "SupervisorAmount",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "ComissionAmount",
                table: "CashierDetails");

            migrationBuilder.DropColumn(
                name: "SupervisorAmount",
                table: "CashierDetails");

            migrationBuilder.RenameColumn(
                name: "Amountx",
                table: "Payments",
                newName: "Amount");

            migrationBuilder.AddColumn<decimal>(
                name: "AmountCheck",
                table: "Payments",
                type: "decimal(12,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AmountNc",
                table: "Payments",
                type: "decimal(12,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AmountTc",
                table: "Payments",
                type: "decimal(12,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AmountTe",
                table: "Payments",
                type: "decimal(12,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bank",
                table: "Payments",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BuildDate",
                table: "Payments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CashierDetailId",
                table: "Payments",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "NoCheque",
                table: "Payments",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Owner",
                table: "Payments",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PaymentTypeId",
                table: "Payments",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "WhoPay",
                table: "Payments",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTo",
                table: "Cuadres",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateFrom",
                table: "Cuadres",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CashierDetailId",
                table: "Payments",
                column: "CashierDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentTypeId",
                table: "Payments",
                column: "PaymentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_CashierDetails_CashierDetailId",
                table: "Payments",
                column: "CashierDetailId",
                principalTable: "CashierDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_PaymentTypes_PaymentTypeId",
                table: "Payments",
                column: "PaymentTypeId",
                principalTable: "PaymentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
