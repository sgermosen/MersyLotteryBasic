using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mersy.Infraestructure.Migrations
{
    public partial class Restrictions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LotteryGlobalLimits",
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
                    table.PrimaryKey("PK_LotteryGlobalLimits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LotteryGlobalLimits_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryGlobalLimits_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryGlobalLimits_Lotteries_LotteryId",
                        column: x => x.LotteryId,
                        principalTable: "Lotteries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryGlobalLimits_LotteryModes_LotteryModeId",
                        column: x => x.LotteryModeId,
                        principalTable: "LotteryModes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryGlobalLimits_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LotteryNumberLimits",
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
                    Amount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LotteryNumberLimits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LotteryNumberLimits_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryNumberLimits_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryNumberLimits_Lotteries_LotteryId",
                        column: x => x.LotteryId,
                        principalTable: "Lotteries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryNumberLimits_LotteryModes_LotteryModeId",
                        column: x => x.LotteryModeId,
                        principalTable: "LotteryModes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryNumberLimits_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LotteryShopLimits",
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
                    Amount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    ShopId = table.Column<long>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "LotteryUserLimits",
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
                    Amount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LotteryUserLimits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LotteryUserLimits_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryUserLimits_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryUserLimits_Lotteries_LotteryId",
                        column: x => x.LotteryId,
                        principalTable: "Lotteries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryUserLimits_LotteryModes_LotteryModeId",
                        column: x => x.LotteryModeId,
                        principalTable: "LotteryModes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryUserLimits_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryUserLimits_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LotteryGlobalLimits_CreatedBy",
                table: "LotteryGlobalLimits",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryGlobalLimits_DeletedBy",
                table: "LotteryGlobalLimits",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryGlobalLimits_LotteryId",
                table: "LotteryGlobalLimits",
                column: "LotteryId");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryGlobalLimits_LotteryModeId",
                table: "LotteryGlobalLimits",
                column: "LotteryModeId");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryGlobalLimits_UpdatedBy",
                table: "LotteryGlobalLimits",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryNumberLimits_CreatedBy",
                table: "LotteryNumberLimits",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryNumberLimits_DeletedBy",
                table: "LotteryNumberLimits",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryNumberLimits_LotteryId",
                table: "LotteryNumberLimits",
                column: "LotteryId");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryNumberLimits_LotteryModeId",
                table: "LotteryNumberLimits",
                column: "LotteryModeId");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryNumberLimits_UpdatedBy",
                table: "LotteryNumberLimits",
                column: "UpdatedBy");

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

            migrationBuilder.CreateIndex(
                name: "IX_LotteryUserLimits_CreatedBy",
                table: "LotteryUserLimits",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryUserLimits_DeletedBy",
                table: "LotteryUserLimits",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryUserLimits_LotteryId",
                table: "LotteryUserLimits",
                column: "LotteryId");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryUserLimits_LotteryModeId",
                table: "LotteryUserLimits",
                column: "LotteryModeId");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryUserLimits_UpdatedBy",
                table: "LotteryUserLimits",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryUserLimits_UserId",
                table: "LotteryUserLimits",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LotteryGlobalLimits");

            migrationBuilder.DropTable(
                name: "LotteryNumberLimits");

            migrationBuilder.DropTable(
                name: "LotteryShopLimits");

            migrationBuilder.DropTable(
                name: "LotteryUserLimits");
        }
    }
}
