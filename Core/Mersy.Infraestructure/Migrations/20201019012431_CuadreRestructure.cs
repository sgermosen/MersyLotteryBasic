using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mersy.Infraestructure.Migrations
{
    public partial class CuadreRestructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Cuadres");

            migrationBuilder.DropColumn(
                name: "IsClosed",
                table: "Cuadres");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalToPaid",
                table: "Cuadres",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SubTotal",
                table: "Cuadres",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Balance",
                table: "Cuadres",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateFrom",
                table: "Cuadres",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTo",
                table: "Cuadres",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "FinalBalance",
                table: "Cuadres",
                type: "decimal(12,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "FinalTotalToPaid",
                table: "Cuadres",
                type: "decimal(12,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "CuadreItems",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    IsClosed = table.Column<bool>(nullable: false),
                    CuadreId = table.Column<long>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Sells = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Commision = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    CommisionSup = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Prizes = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    PrizePaid = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    PaymentReceived = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    EndBalance = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    EndBalanceEf = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    PreviousDeb = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    ReceivedPaid = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    TotalToPaid = table.Column<decimal>(type: "decimal(12,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuadreItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CuadreItems_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CuadreItems_Cuadres_CuadreId",
                        column: x => x.CuadreId,
                        principalTable: "Cuadres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CuadreItems_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CuadreItems_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CuadreItems_CreatedBy",
                table: "CuadreItems",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CuadreItems_CuadreId",
                table: "CuadreItems",
                column: "CuadreId");

            migrationBuilder.CreateIndex(
                name: "IX_CuadreItems_DeletedBy",
                table: "CuadreItems",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CuadreItems_UpdatedBy",
                table: "CuadreItems",
                column: "UpdatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CuadreItems");

            migrationBuilder.DropColumn(
                name: "DateFrom",
                table: "Cuadres");

            migrationBuilder.DropColumn(
                name: "DateTo",
                table: "Cuadres");

            migrationBuilder.DropColumn(
                name: "FinalBalance",
                table: "Cuadres");

            migrationBuilder.DropColumn(
                name: "FinalTotalToPaid",
                table: "Cuadres");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalToPaid",
                table: "Cuadres",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SubTotal",
                table: "Cuadres",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Balance",
                table: "Cuadres",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Cuadres",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsClosed",
                table: "Cuadres",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
