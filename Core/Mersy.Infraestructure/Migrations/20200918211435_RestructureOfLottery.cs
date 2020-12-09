using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mersy.Infraestructure.Migrations
{
    public partial class RestructureOfLottery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LotteryAvailables");

            migrationBuilder.DropTable(
                name: "LotteryPrizes");

            migrationBuilder.AddColumn<decimal>(
                name: "Loto1First",
                table: "Lotteries",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Loto1Second",
                table: "Lotteries",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Loto1Third",
                table: "Lotteries",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Loto2First",
                table: "Lotteries",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Loto2Second",
                table: "Lotteries",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Loto3First",
                table: "Lotteries",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Loto3Second",
                table: "Lotteries",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Loto4First",
                table: "Lotteries",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Loto1First",
                table: "Lotteries");

            migrationBuilder.DropColumn(
                name: "Loto1Second",
                table: "Lotteries");

            migrationBuilder.DropColumn(
                name: "Loto1Third",
                table: "Lotteries");

            migrationBuilder.DropColumn(
                name: "Loto2First",
                table: "Lotteries");

            migrationBuilder.DropColumn(
                name: "Loto2Second",
                table: "Lotteries");

            migrationBuilder.DropColumn(
                name: "Loto3First",
                table: "Lotteries");

            migrationBuilder.DropColumn(
                name: "Loto3Second",
                table: "Lotteries");

            migrationBuilder.DropColumn(
                name: "Loto4First",
                table: "Lotteries");

            migrationBuilder.CreateTable(
                name: "LotteryAvailables",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LotteryId = table.Column<long>(type: "bigint", nullable: false),
                    LotteryModeId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LotteryAvailables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LotteryAvailables_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryAvailables_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryAvailables_Lotteries_LotteryId",
                        column: x => x.LotteryId,
                        principalTable: "Lotteries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryAvailables_LotteryModes_LotteryModeId",
                        column: x => x.LotteryModeId,
                        principalTable: "LotteryModes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryAvailables_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LotteryPrizes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FirstValue = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    LotteryId = table.Column<long>(type: "bigint", nullable: false),
                    LotteryModeId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondValue = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    ThirdValue = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LotteryPrizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LotteryPrizes_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryPrizes_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryPrizes_Lotteries_LotteryId",
                        column: x => x.LotteryId,
                        principalTable: "Lotteries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryPrizes_LotteryModes_LotteryModeId",
                        column: x => x.LotteryModeId,
                        principalTable: "LotteryModes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryPrizes_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LotteryAvailables_CreatedBy",
                table: "LotteryAvailables",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryAvailables_DeletedBy",
                table: "LotteryAvailables",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryAvailables_LotteryId",
                table: "LotteryAvailables",
                column: "LotteryId");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryAvailables_LotteryModeId",
                table: "LotteryAvailables",
                column: "LotteryModeId");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryAvailables_UpdatedBy",
                table: "LotteryAvailables",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryPrizes_CreatedBy",
                table: "LotteryPrizes",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryPrizes_DeletedBy",
                table: "LotteryPrizes",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryPrizes_LotteryId",
                table: "LotteryPrizes",
                column: "LotteryId");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryPrizes_LotteryModeId",
                table: "LotteryPrizes",
                column: "LotteryModeId");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryPrizes_UpdatedBy",
                table: "LotteryPrizes",
                column: "UpdatedBy");
        }
    }
}
