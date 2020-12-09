using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mersy.Infraestructure.Migrations
{
    public partial class PlayNumbers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountTe",
                table: "LotterySaleItems");

            migrationBuilder.DropColumn(
                name: "EithgthValue",
                table: "LotterySaleItems");

            migrationBuilder.DropColumn(
                name: "FirstValue",
                table: "LotterySaleItems");

            migrationBuilder.DropColumn(
                name: "FivethValue",
                table: "LotterySaleItems");

            migrationBuilder.DropColumn(
                name: "FourthValue",
                table: "LotterySaleItems");

            migrationBuilder.DropColumn(
                name: "SecondValue",
                table: "LotterySaleItems");

            migrationBuilder.DropColumn(
                name: "SeventhValue",
                table: "LotterySaleItems");

            migrationBuilder.DropColumn(
                name: "SixthValue",
                table: "LotterySaleItems");

            migrationBuilder.DropColumn(
                name: "ThirdValue",
                table: "LotterySaleItems");

            migrationBuilder.AlterColumn<decimal>(
                name: "PlayedAmount",
                table: "LotterySaleItems",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.CreateTable(
                name: "LotteryPlayedNumbers",
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
                    LotterySaleItemId = table.Column<long>(nullable: false),
                    PlayedNumber = table.Column<int>(nullable: false)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LotteryPlayedNumbers");

            migrationBuilder.AlterColumn<decimal>(
                name: "PlayedAmount",
                table: "LotterySaleItems",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AddColumn<decimal>(
                name: "AmountTe",
                table: "LotterySaleItems",
                type: "decimal(12,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EithgthValue",
                table: "LotterySaleItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FirstValue",
                table: "LotterySaleItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FivethValue",
                table: "LotterySaleItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FourthValue",
                table: "LotterySaleItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SecondValue",
                table: "LotterySaleItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SeventhValue",
                table: "LotterySaleItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SixthValue",
                table: "LotterySaleItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ThirdValue",
                table: "LotterySaleItems",
                nullable: false,
                defaultValue: 0);
        }
    }
}
