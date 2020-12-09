using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mersy.Infraestructure.Migrations
{
    public partial class AddingF : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LotteryDayLimits");

            migrationBuilder.DropTable(
                name: "LotteryGlobalLimits");

            migrationBuilder.DropTable(
                name: "LotteryIndividualLimits");

            migrationBuilder.DropTable(
                name: "LotteryNumberLimits");

            migrationBuilder.DropTable(
                name: "LotteryUserLimits");

            migrationBuilder.CreateTable(
                name: "LotteryRestrictions",
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
                    IsParent = table.Column<bool>(nullable: false),
                    IsGlobal = table.Column<bool>(nullable: false),
                    LotteryId = table.Column<long>(nullable: false),
                    LotteryFromId = table.Column<long>(nullable: false),
                    Loto1Global = table.Column<decimal>(nullable: false),
                    Loto2Global = table.Column<decimal>(nullable: false),
                    Loto3Global = table.Column<decimal>(nullable: false),
                    Loto4Global = table.Column<decimal>(nullable: false),
                    Loto5Global = table.Column<decimal>(nullable: false),
                    Loto6Global = table.Column<decimal>(nullable: false),
                    Loto1Individual = table.Column<decimal>(nullable: false),
                    Loto2Individual = table.Column<decimal>(nullable: false),
                    Loto3Individual = table.Column<decimal>(nullable: false),
                    Loto4Individual = table.Column<decimal>(nullable: false),
                    Loto5Individual = table.Column<decimal>(nullable: false),
                    Loto6Individual = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LotteryRestrictions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LotteryRestrictions_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryRestrictions_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryRestrictions_LotteryFroms_LotteryFromId",
                        column: x => x.LotteryFromId,
                        principalTable: "LotteryFroms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryRestrictions_Lotteries_LotteryId",
                        column: x => x.LotteryId,
                        principalTable: "Lotteries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryRestrictions_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LotteryRestrictionByNumbers",
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
                    LotteryRestrictionId = table.Column<long>(nullable: false),
                    Number = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    IsBlocked = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LotteryRestrictionByNumbers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LotteryRestrictionByNumbers_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryRestrictionByNumbers_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryRestrictionByNumbers_LotteryRestrictions_LotteryRestrictionId",
                        column: x => x.LotteryRestrictionId,
                        principalTable: "LotteryRestrictions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryRestrictionByNumbers_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LotteryRestrictionBySellers",
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
                    LotteryRestrictionId = table.Column<long>(nullable: false),
                    RestrictedUserId = table.Column<string>(nullable: true),
                    Loto1 = table.Column<decimal>(nullable: false),
                    Loto2 = table.Column<decimal>(nullable: false),
                    Loto3 = table.Column<decimal>(nullable: false),
                    Loto4 = table.Column<decimal>(nullable: false),
                    Loto5 = table.Column<decimal>(nullable: false),
                    Loto6 = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LotteryRestrictionBySellers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LotteryRestrictionBySellers_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryRestrictionBySellers_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryRestrictionBySellers_LotteryRestrictions_LotteryRestrictionId",
                        column: x => x.LotteryRestrictionId,
                        principalTable: "LotteryRestrictions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryRestrictionBySellers_AspNetUsers_RestrictedUserId",
                        column: x => x.RestrictedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryRestrictionBySellers_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LotteryRestrictionByNumbers_CreatedBy",
                table: "LotteryRestrictionByNumbers",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryRestrictionByNumbers_DeletedBy",
                table: "LotteryRestrictionByNumbers",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryRestrictionByNumbers_LotteryRestrictionId",
                table: "LotteryRestrictionByNumbers",
                column: "LotteryRestrictionId");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryRestrictionByNumbers_UpdatedBy",
                table: "LotteryRestrictionByNumbers",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryRestrictionBySellers_CreatedBy",
                table: "LotteryRestrictionBySellers",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryRestrictionBySellers_DeletedBy",
                table: "LotteryRestrictionBySellers",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryRestrictionBySellers_LotteryRestrictionId",
                table: "LotteryRestrictionBySellers",
                column: "LotteryRestrictionId");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryRestrictionBySellers_RestrictedUserId",
                table: "LotteryRestrictionBySellers",
                column: "RestrictedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryRestrictionBySellers_UpdatedBy",
                table: "LotteryRestrictionBySellers",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryRestrictions_CreatedBy",
                table: "LotteryRestrictions",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryRestrictions_DeletedBy",
                table: "LotteryRestrictions",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryRestrictions_LotteryFromId",
                table: "LotteryRestrictions",
                column: "LotteryFromId");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryRestrictions_LotteryId",
                table: "LotteryRestrictions",
                column: "LotteryId");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryRestrictions_UpdatedBy",
                table: "LotteryRestrictions",
                column: "UpdatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LotteryRestrictionByNumbers");

            migrationBuilder.DropTable(
                name: "LotteryRestrictionBySellers");

            migrationBuilder.DropTable(
                name: "LotteryRestrictions");

            migrationBuilder.CreateTable(
                name: "LotteryDayLimits",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LotteryId = table.Column<long>(type: "bigint", nullable: true),
                    LotteryModeId = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<int>(type: "int", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "LotteryGlobalLimits",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
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
                name: "LotteryIndividualLimits",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "LotteryNumberLimits",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LotteryId = table.Column<long>(type: "bigint", nullable: false),
                    LotteryModeId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                name: "LotteryUserLimits",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LotteryId = table.Column<long>(type: "bigint", nullable: false),
                    LotteryModeId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
    }
}
