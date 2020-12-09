using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mersy.Infraestructure.Migrations
{
    public partial class AddingFather : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lotteries_AspNetUsers_CreatedBy",
                table: "Lotteries");

            migrationBuilder.DropForeignKey(
                name: "FK_Lotteries_AspNetUsers_DeletedBy",
                table: "Lotteries");

            migrationBuilder.DropForeignKey(
                name: "FK_Lotteries_LotteryFrom_LotteryFromId",
                table: "Lotteries");

            migrationBuilder.DropForeignKey(
                name: "FK_Lotteries_AspNetUsers_UpdatedBy",
                table: "Lotteries");

            migrationBuilder.DropIndex(
                name: "IX_Lotteries_CreatedBy",
                table: "Lotteries");

            migrationBuilder.DropIndex(
                name: "IX_Lotteries_DeletedBy",
                table: "Lotteries");

            migrationBuilder.DropIndex(
                name: "IX_Lotteries_UpdatedBy",
                table: "Lotteries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LotteryFrom",
                table: "LotteryFrom");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Lotteries");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Lotteries");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Lotteries");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Lotteries");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Lotteries");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Lotteries");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Lotteries");

            migrationBuilder.RenameTable(
                name: "LotteryFrom",
                newName: "LotteryFroms");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LotteryFroms",
                table: "LotteryFroms",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lotteries_LotteryFroms_LotteryFromId",
                table: "Lotteries",
                column: "LotteryFromId",
                principalTable: "LotteryFroms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lotteries_LotteryFroms_LotteryFromId",
                table: "Lotteries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LotteryFroms",
                table: "LotteryFroms");

            migrationBuilder.RenameTable(
                name: "LotteryFroms",
                newName: "LotteryFrom");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Lotteries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Lotteries",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Lotteries",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Lotteries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Lotteries",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Lotteries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Lotteries",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_LotteryFrom",
                table: "LotteryFrom",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Lotteries_CreatedBy",
                table: "Lotteries",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Lotteries_DeletedBy",
                table: "Lotteries",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Lotteries_UpdatedBy",
                table: "Lotteries",
                column: "UpdatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Lotteries_AspNetUsers_CreatedBy",
                table: "Lotteries",
                column: "CreatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lotteries_AspNetUsers_DeletedBy",
                table: "Lotteries",
                column: "DeletedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lotteries_LotteryFrom_LotteryFromId",
                table: "Lotteries",
                column: "LotteryFromId",
                principalTable: "LotteryFrom",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lotteries_AspNetUsers_UpdatedBy",
                table: "Lotteries",
                column: "UpdatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
