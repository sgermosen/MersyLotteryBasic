using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mersy.Infraestructure.Migrations
{
    public partial class PrizePaymente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DebPayments",
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
                    Amount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    PreviousDeb = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    DateFrom = table.Column<DateTime>(nullable: true),
                    Date = table.Column<DateTime>(nullable: true),
                    SellerId = table.Column<string>(nullable: true),
                    UseSupervisorAmount = table.Column<bool>(nullable: false),
                    PreviousSupervisorAmount = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DebPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DebPayments_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DebPayments_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DebPayments_AspNetUsers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DebPayments_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PrizePayments",
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
                    Amount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    DateFrom = table.Column<DateTime>(nullable: true),
                    Date = table.Column<DateTime>(nullable: true),
                    SellerId = table.Column<string>(nullable: true),
                    UseSupervisorAmount = table.Column<bool>(nullable: false),
                    PreviousSupervisorAmount = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrizePayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrizePayments_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PrizePayments_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PrizePayments_AspNetUsers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PrizePayments_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DebPayments_CreatedBy",
                table: "DebPayments",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DebPayments_DeletedBy",
                table: "DebPayments",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DebPayments_SellerId",
                table: "DebPayments",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_DebPayments_UpdatedBy",
                table: "DebPayments",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PrizePayments_CreatedBy",
                table: "PrizePayments",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PrizePayments_DeletedBy",
                table: "PrizePayments",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PrizePayments_SellerId",
                table: "PrizePayments",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_PrizePayments_UpdatedBy",
                table: "PrizePayments",
                column: "UpdatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DebPayments");

            migrationBuilder.DropTable(
                name: "PrizePayments");
        }
    }
}
