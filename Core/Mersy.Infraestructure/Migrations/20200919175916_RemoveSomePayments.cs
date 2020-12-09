using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mersy.Infraestructure.Migrations
{
    public partial class RemoveSomePayments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LotteryPayments");

            migrationBuilder.DropColumn(
                name: "CurrentBalanceCh",
                table: "CashierDetails");

            migrationBuilder.DropColumn(
                name: "EndBalanceCheck",
                table: "CashierDetails");

            migrationBuilder.DropColumn(
                name: "EndBalanceCredit",
                table: "CashierDetails");

            migrationBuilder.DropColumn(
                name: "EndBalanceNc",
                table: "CashierDetails");

            migrationBuilder.DropColumn(
                name: "EndBalanceTe",
                table: "CashierDetails");

            migrationBuilder.RenameColumn(
                name: "StartBalance",
                table: "CashierDetails",
                newName: "PrizePaid");

            migrationBuilder.RenameColumn(
                name: "EndBalanceEf",
                table: "CashierDetails",
                newName: "Prize");

            migrationBuilder.RenameColumn(
                name: "EndBalance",
                table: "CashierDetails",
                newName: "PaymentReceived");

            migrationBuilder.RenameColumn(
                name: "CurrentBalanceTe",
                table: "CashierDetails",
                newName: "EndCashierBalanceEf");

            migrationBuilder.RenameColumn(
                name: "CurrentBalanceTc",
                table: "CashierDetails",
                newName: "EndCashierBalance");

            migrationBuilder.RenameColumn(
                name: "CurrentBalanceNc",
                table: "CashierDetails",
                newName: "Commision");

            migrationBuilder.RenameColumn(
                name: "CurrentBalanceEf",
                table: "CashierDetails",
                newName: "BilledBalanceEf");

            migrationBuilder.AddColumn<long>(
                name: "Type",
                table: "Payments",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<long>(
                name: "LotteryFromId",
                table: "Lotteries",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AsignedUserId",
                table: "CashierDetails",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CashierDetails_AsignedUserId",
                table: "CashierDetails",
                column: "AsignedUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CashierDetails_AspNetUsers_AsignedUserId",
                table: "CashierDetails",
                column: "AsignedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CashierDetails_AspNetUsers_AsignedUserId",
                table: "CashierDetails");

            migrationBuilder.DropIndex(
                name: "IX_CashierDetails_AsignedUserId",
                table: "CashierDetails");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "AsignedUserId",
                table: "CashierDetails");

            migrationBuilder.RenameColumn(
                name: "PrizePaid",
                table: "CashierDetails",
                newName: "StartBalance");

            migrationBuilder.RenameColumn(
                name: "Prize",
                table: "CashierDetails",
                newName: "EndBalanceEf");

            migrationBuilder.RenameColumn(
                name: "PaymentReceived",
                table: "CashierDetails",
                newName: "EndBalance");

            migrationBuilder.RenameColumn(
                name: "EndCashierBalanceEf",
                table: "CashierDetails",
                newName: "CurrentBalanceTe");

            migrationBuilder.RenameColumn(
                name: "EndCashierBalance",
                table: "CashierDetails",
                newName: "CurrentBalanceTc");

            migrationBuilder.RenameColumn(
                name: "Commision",
                table: "CashierDetails",
                newName: "CurrentBalanceNc");

            migrationBuilder.RenameColumn(
                name: "BilledBalanceEf",
                table: "CashierDetails",
                newName: "CurrentBalanceEf");

            migrationBuilder.AlterColumn<long>(
                name: "LotteryFromId",
                table: "Lotteries",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<decimal>(
                name: "CurrentBalanceCh",
                table: "CashierDetails",
                type: "decimal(12,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "EndBalanceCheck",
                table: "CashierDetails",
                type: "decimal(12,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "EndBalanceCredit",
                table: "CashierDetails",
                type: "decimal(12,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "EndBalanceNc",
                table: "CashierDetails",
                type: "decimal(12,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "EndBalanceTe",
                table: "CashierDetails",
                type: "decimal(12,2)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LotteryPayments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CashierDetailId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LotterySaleId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentAmount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LotteryPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LotteryPayments_CashierDetails_CashierDetailId",
                        column: x => x.CashierDetailId,
                        principalTable: "CashierDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryPayments_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryPayments_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryPayments_LotterySales_LotterySaleId",
                        column: x => x.LotterySaleId,
                        principalTable: "LotterySales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryPayments_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LotteryPayments_CashierDetailId",
                table: "LotteryPayments",
                column: "CashierDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryPayments_CreatedBy",
                table: "LotteryPayments",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryPayments_DeletedBy",
                table: "LotteryPayments",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryPayments_LotterySaleId",
                table: "LotteryPayments",
                column: "LotterySaleId");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryPayments_UpdatedBy",
                table: "LotteryPayments",
                column: "UpdatedBy");
        }
    }
}
