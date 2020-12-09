using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mersy.Infraestructure.Migrations
{
    public partial class RemovingDetailsNumberse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LotteryPlayedNumbers");

            migrationBuilder.AddColumn<string>(
                name: "Played1",
                table: "LotterySaleItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Played2",
                table: "LotterySaleItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Played3",
                table: "LotterySaleItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PlayedNumbers",
                table: "LotterySaleItems",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Played1",
                table: "LotterySaleItems");

            migrationBuilder.DropColumn(
                name: "Played2",
                table: "LotterySaleItems");

            migrationBuilder.DropColumn(
                name: "Played3",
                table: "LotterySaleItems");

            migrationBuilder.DropColumn(
                name: "PlayedNumbers",
                table: "LotterySaleItems");

            migrationBuilder.CreateTable(
                name: "LotteryPlayedNumbers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LotterySaleItemId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlayedNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LotteryPlayedNumbers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LotteryPlayedNumbers_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryPlayedNumbers_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryPlayedNumbers_LotterySaleItems_LotterySaleItemId",
                        column: x => x.LotterySaleItemId,
                        principalTable: "LotterySaleItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryPlayedNumbers_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LotteryPlayedNumbers_CreatedBy",
                table: "LotteryPlayedNumbers",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryPlayedNumbers_DeletedBy",
                table: "LotteryPlayedNumbers",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryPlayedNumbers_LotterySaleItemId",
                table: "LotteryPlayedNumbers",
                column: "LotterySaleItemId");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryPlayedNumbers_UpdatedBy",
                table: "LotteryPlayedNumbers",
                column: "UpdatedBy");
        }
    }
}
