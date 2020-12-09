using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mersy.Infraestructure.Migrations
{
    public partial class PaymentPrize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LotteryPayments",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    LotterySaleId = table.Column<long>(nullable: false),
                    PaymentAmount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    CashierDetailId = table.Column<long>(nullable: false),
                    Remarks = table.Column<string>(nullable: true)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LotteryPayments");
        }
    }
}
