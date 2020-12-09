using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mersy.Infraestructure.Migrations
{
    public partial class FromLotteryToRestrictions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "LotteryFromId",
                table: "Lotteries",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LotteryFrom",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LotteryFrom", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lotteries_LotteryFromId",
                table: "Lotteries",
                column: "LotteryFromId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lotteries_LotteryFrom_LotteryFromId",
                table: "Lotteries",
                column: "LotteryFromId",
                principalTable: "LotteryFrom",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lotteries_LotteryFrom_LotteryFromId",
                table: "Lotteries");

            migrationBuilder.DropTable(
                name: "LotteryFrom");

            migrationBuilder.DropIndex(
                name: "IX_Lotteries_LotteryFromId",
                table: "Lotteries");

            migrationBuilder.DropColumn(
                name: "LotteryFromId",
                table: "Lotteries");
        }
    }
}
