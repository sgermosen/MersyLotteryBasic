using Microsoft.EntityFrameworkCore.Migrations;

namespace Mersy.Infraestructure.Migrations
{
    public partial class FixOnCashier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CashierDetails_AspNetUsers_AsignedUserId",
                table: "CashierDetails");

            migrationBuilder.DropIndex(
                name: "IX_CashierDetails_AsignedUserId",
                table: "CashierDetails");

            migrationBuilder.DropColumn(
                name: "IsOpened",
                table: "Cashiers");

            migrationBuilder.DropColumn(
                name: "AsignedUserId",
                table: "CashierDetails");

            migrationBuilder.AddColumn<string>(
                name: "AsignedUser2Id",
                table: "Cashiers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AsignedUserId",
                table: "Cashiers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cashiers_AsignedUser2Id",
                table: "Cashiers",
                column: "AsignedUser2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cashiers_AsignedUserId",
                table: "Cashiers",
                column: "AsignedUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cashiers_AspNetUsers_AsignedUser2Id",
                table: "Cashiers",
                column: "AsignedUser2Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cashiers_AspNetUsers_AsignedUserId",
                table: "Cashiers",
                column: "AsignedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cashiers_AspNetUsers_AsignedUser2Id",
                table: "Cashiers");

            migrationBuilder.DropForeignKey(
                name: "FK_Cashiers_AspNetUsers_AsignedUserId",
                table: "Cashiers");

            migrationBuilder.DropIndex(
                name: "IX_Cashiers_AsignedUser2Id",
                table: "Cashiers");

            migrationBuilder.DropIndex(
                name: "IX_Cashiers_AsignedUserId",
                table: "Cashiers");

            migrationBuilder.DropColumn(
                name: "AsignedUser2Id",
                table: "Cashiers");

            migrationBuilder.DropColumn(
                name: "AsignedUserId",
                table: "Cashiers");

            migrationBuilder.AddColumn<bool>(
                name: "IsOpened",
                table: "Cashiers",
                nullable: false,
                defaultValue: false);

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
    }
}
