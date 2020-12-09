using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mersy.Infraestructure.Migrations
{
    public partial class CreatingCuadree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Cuadres",
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
                    Sells = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Commision = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    CommisionSup = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Prizes = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    PrizePaid = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    PaymentReceived = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    EndBalance = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    EndBalanceEf = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Mf1 = table.Column<int>(nullable: true),
                    Mf5 = table.Column<int>(nullable: true),
                    Mf10 = table.Column<int>(nullable: true),
                    Mf20 = table.Column<int>(nullable: true),
                    Mf25 = table.Column<int>(nullable: true),
                    Mf50 = table.Column<int>(nullable: true),
                    Mf100 = table.Column<int>(nullable: true),
                    Mf200 = table.Column<int>(nullable: true),
                    Mf500 = table.Column<int>(nullable: true),
                    Mf1000 = table.Column<int>(nullable: true),
                    Mf2000 = table.Column<int>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    IsClosed = table.Column<bool>(nullable: false),
                    AsignedUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuadres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cuadres_AspNetUsers_AsignedUserId",
                        column: x => x.AsignedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cuadres_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cuadres_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cuadres_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cuadres_AsignedUserId",
                table: "Cuadres",
                column: "AsignedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Cuadres_CreatedBy",
                table: "Cuadres",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Cuadres_DeletedBy",
                table: "Cuadres",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Cuadres_UpdatedBy",
                table: "Cuadres",
                column: "UpdatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cuadres");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256);
        }
    }
}
