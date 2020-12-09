using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mersy.Infraestructure.Migrations
{
    public partial class RestrictionsUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LotteryShopLimits");

            migrationBuilder.CreateTable(
                name: "LotteryIndividualLimits",
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
                    LotteryId = table.Column<long>(nullable: false),
                    LotteryModeId = table.Column<long>(nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(12,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LotteryIndividualLimits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LotteryIndividualLimits_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryIndividualLimits_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryIndividualLimits_Lotteries_LotteryId",
                        column: x => x.LotteryId,
                        principalTable: "Lotteries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryIndividualLimits_LotteryModes_LotteryModeId",
                        column: x => x.LotteryModeId,
                        principalTable: "LotteryModes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryIndividualLimits_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LotteryIndividualLimits_CreatedBy",
                table: "LotteryIndividualLimits",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryIndividualLimits_DeletedBy",
                table: "LotteryIndividualLimits",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryIndividualLimits_LotteryId",
                table: "LotteryIndividualLimits",
                column: "LotteryId");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryIndividualLimits_LotteryModeId",
                table: "LotteryIndividualLimits",
                column: "LotteryModeId");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryIndividualLimits_UpdatedBy",
                table: "LotteryIndividualLimits",
                column: "UpdatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LotteryIndividualLimits");

            migrationBuilder.CreateTable(
                name: "LotteryShopLimits",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    LotteryId = table.Column<long>(nullable: false),
                    LotteryModeId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ShopId = table.Column<long>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LotteryShopLimits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LotteryShopLimits_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryShopLimits_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryShopLimits_Lotteries_LotteryId",
                        column: x => x.LotteryId,
                        principalTable: "Lotteries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryShopLimits_LotteryModes_LotteryModeId",
                        column: x => x.LotteryModeId,
                        principalTable: "LotteryModes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryShopLimits_Shops_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryShopLimits_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LotteryShopLimits_CreatedBy",
                table: "LotteryShopLimits",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryShopLimits_DeletedBy",
                table: "LotteryShopLimits",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryShopLimits_LotteryId",
                table: "LotteryShopLimits",
                column: "LotteryId");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryShopLimits_LotteryModeId",
                table: "LotteryShopLimits",
                column: "LotteryModeId");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryShopLimits_ShopId",
                table: "LotteryShopLimits",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryShopLimits_UpdatedBy",
                table: "LotteryShopLimits",
                column: "UpdatedBy");
        }
    }
}
