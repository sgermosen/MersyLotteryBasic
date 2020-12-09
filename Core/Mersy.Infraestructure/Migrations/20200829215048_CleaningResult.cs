using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mersy.Infraestructure.Migrations
{
    public partial class CleaningResult : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LotteryResults_LotteryModes_LotteryModeId",
                table: "LotteryResults");

            migrationBuilder.DropIndex(
                name: "IX_LotteryResults_LotteryModeId",
                table: "LotteryResults");

            migrationBuilder.DropColumn(
                name: "EithgthValue",
                table: "LotteryResults");

            migrationBuilder.DropColumn(
                name: "FivethValue",
                table: "LotteryResults");

            migrationBuilder.DropColumn(
                name: "FourthValue",
                table: "LotteryResults");

            migrationBuilder.DropColumn(
                name: "LotteryModeId",
                table: "LotteryResults");

            migrationBuilder.DropColumn(
                name: "SeventhValue",
                table: "LotteryResults");

            migrationBuilder.DropColumn(
                name: "SixthValue",
                table: "LotteryResults");

            migrationBuilder.CreateTable(
                name: "LotteryDayLimits",
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
                    LotteryId = table.Column<long>(nullable: true),
                    LotteryModeId = table.Column<long>(nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Number = table.Column<int>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LotteryDayLimits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LotteryDayLimits_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryDayLimits_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryDayLimits_Lotteries_LotteryId",
                        column: x => x.LotteryId,
                        principalTable: "Lotteries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryDayLimits_LotteryModes_LotteryModeId",
                        column: x => x.LotteryModeId,
                        principalTable: "LotteryModes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryDayLimits_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryDayLimits_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LotteryDayLimits_CreatedBy",
                table: "LotteryDayLimits",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryDayLimits_DeletedBy",
                table: "LotteryDayLimits",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryDayLimits_LotteryId",
                table: "LotteryDayLimits",
                column: "LotteryId");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryDayLimits_LotteryModeId",
                table: "LotteryDayLimits",
                column: "LotteryModeId");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryDayLimits_UpdatedBy",
                table: "LotteryDayLimits",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryDayLimits_UserId",
                table: "LotteryDayLimits",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LotteryDayLimits");

            migrationBuilder.AddColumn<int>(
                name: "EithgthValue",
                table: "LotteryResults",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FivethValue",
                table: "LotteryResults",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FourthValue",
                table: "LotteryResults",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "LotteryModeId",
                table: "LotteryResults",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "SeventhValue",
                table: "LotteryResults",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SixthValue",
                table: "LotteryResults",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_LotteryResults_LotteryModeId",
                table: "LotteryResults",
                column: "LotteryModeId");

            migrationBuilder.AddForeignKey(
                name: "FK_LotteryResults_LotteryModes_LotteryModeId",
                table: "LotteryResults",
                column: "LotteryModeId",
                principalTable: "LotteryModes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
