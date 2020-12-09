using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mersy.Infraestructure.Migrations
{
    public partial class RemovingToShare : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Shops_ShopId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_LotterySales_CashierDetails_CashierDetailId",
                table: "LotterySales");

            migrationBuilder.DropTable(
                name: "CashierDetails");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "CuadreItems");

            migrationBuilder.DropTable(
                name: "CurrencyRates");

            migrationBuilder.DropTable(
                name: "DebPayments");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "LotteryRestrictionByNumbers");

            migrationBuilder.DropTable(
                name: "LotteryRestrictionBySellers");

            migrationBuilder.DropTable(
                name: "MaritalSituations");

            migrationBuilder.DropTable(
                name: "Ocupations");

            migrationBuilder.DropTable(
                name: "Religions");

            migrationBuilder.DropTable(
                name: "SchoolLevels");

            migrationBuilder.DropTable(
                name: "Cashiers");

            migrationBuilder.DropTable(
                name: "Cuadres");

            migrationBuilder.DropTable(
                name: "LotteryRestrictions");

            migrationBuilder.DropTable(
                name: "Shops");

            migrationBuilder.DropIndex(
                name: "IX_LotterySales_CashierDetailId",
                table: "LotterySales");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ShopId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CashierDetailId",
                table: "LotterySales");

            migrationBuilder.DropColumn(
                name: "ShopId",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CashierDetailId",
                table: "LotterySales",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ShopId",
                table: "AspNetUsers",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Denomym = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cuadres",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AsignedUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Balance = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Commision = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    CommisionSup = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DateFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EndBalance = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    EndBalanceEf = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    FinalBalance = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    FinalTotalToPaid = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Mf1 = table.Column<int>(type: "int", nullable: true),
                    Mf10 = table.Column<int>(type: "int", nullable: true),
                    Mf100 = table.Column<int>(type: "int", nullable: true),
                    Mf1000 = table.Column<int>(type: "int", nullable: true),
                    Mf20 = table.Column<int>(type: "int", nullable: true),
                    Mf200 = table.Column<int>(type: "int", nullable: true),
                    Mf2000 = table.Column<int>(type: "int", nullable: true),
                    Mf25 = table.Column<int>(type: "int", nullable: true),
                    Mf5 = table.Column<int>(type: "int", nullable: true),
                    Mf50 = table.Column<int>(type: "int", nullable: true),
                    Mf500 = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentReceived = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    PreviousDeb = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    PrizePaid = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Prizes = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    ReceivedPaid = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Sells = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    TotalToPaid = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "CurrencyRates",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrencyId = table.Column<long>(type: "bigint", nullable: false),
                    DolarEquivalent = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencyRates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurrencyRates_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DebPayments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreviousDeb = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    PreviousSupervisorAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SellerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UseSupervisorAmount = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DebPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DebPayments_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DebPayments_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DebPayments_AspNetUsers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DebPayments_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LotteryRestrictions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsGlobal = table.Column<bool>(type: "bit", nullable: false),
                    IsParent = table.Column<bool>(type: "bit", nullable: false),
                    Loto1Global = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Loto1Individual = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Loto2Global = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Loto2Individual = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Loto3Global = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Loto3Individual = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Loto4Global = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Loto4Individual = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Loto5Global = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Loto5Individual = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Loto6Global = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Loto6Individual = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LotteryFromId = table.Column<long>(type: "bigint", nullable: false),
                    LotteryId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                name: "MaritalSituations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaritalSituations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ocupations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocupations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Religions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Religions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SchoolLevels",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CurrencyId = table.Column<long>(type: "bigint", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Footer1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Footer2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Footer3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsIndependent = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NcfEnds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrefixExp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrefixFact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrefixFinalFact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrefixNcf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrefixOrder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeqFact = table.Column<int>(type: "int", nullable: true),
                    SeqNcf = table.Column<int>(type: "int", nullable: true),
                    ShowSellerOnTicket = table.Column<bool>(type: "bit", nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    WebAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shops_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Shops_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Shops_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Shops_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CuadreItems",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Commision = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    CommisionSup = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CuadreId = table.Column<long>(type: "bigint", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EndBalance = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    EndBalanceEf = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    IsClosed = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentReceived = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    PreviousDeb = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    PrizePaid = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Prizes = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Sells = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuadreItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CuadreItems_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CuadreItems_Cuadres_CuadreId",
                        column: x => x.CuadreId,
                        principalTable: "Cuadres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CuadreItems_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CuadreItems_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LotteryRestrictionByNumbers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false),
                    LotteryRestrictionId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Loto1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Loto2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Loto3 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Loto4 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Loto5 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Loto6 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LotteryRestrictionId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RestrictedUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "Cashiers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    App = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AsignedUser2Id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AsignedUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MacAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShopId = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cashiers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cashiers_AspNetUsers_AsignedUser2Id",
                        column: x => x.AsignedUser2Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cashiers_AspNetUsers_AsignedUserId",
                        column: x => x.AsignedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cashiers_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cashiers_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cashiers_Shops_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cashiers_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CashierDetails",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AsignedUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BilledBalance = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    BilledBalanceEf = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    CashierId = table.Column<long>(type: "bigint", nullable: false),
                    ComissionAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Commision = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CurrentBalance = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EndCashierBalance = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    EndCashierBalanceEf = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    EndingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsOpened = table.Column<bool>(type: "bit", nullable: false),
                    Mf1 = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    Mf10 = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    Mf100 = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    Mf1000 = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    Mf20 = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    Mf200 = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    Mf2000 = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    Mf25 = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    Mf5 = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    Mf50 = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    Mf500 = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentReceived = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Prize = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    PrizePaid = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    StartingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SupervisorAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashierDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CashierDetails_AspNetUsers_AsignedUserId",
                        column: x => x.AsignedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CashierDetails_Cashiers_CashierId",
                        column: x => x.CashierId,
                        principalTable: "Cashiers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CashierDetails_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CashierDetails_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CashierDetails_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LotterySales_CashierDetailId",
                table: "LotterySales",
                column: "CashierDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ShopId",
                table: "AspNetUsers",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_CashierDetails_AsignedUserId",
                table: "CashierDetails",
                column: "AsignedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CashierDetails_CashierId",
                table: "CashierDetails",
                column: "CashierId");

            migrationBuilder.CreateIndex(
                name: "IX_CashierDetails_CreatedBy",
                table: "CashierDetails",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CashierDetails_DeletedBy",
                table: "CashierDetails",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CashierDetails_UpdatedBy",
                table: "CashierDetails",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Cashiers_AsignedUser2Id",
                table: "Cashiers",
                column: "AsignedUser2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cashiers_AsignedUserId",
                table: "Cashiers",
                column: "AsignedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Cashiers_CreatedBy",
                table: "Cashiers",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Cashiers_DeletedBy",
                table: "Cashiers",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Cashiers_ShopId",
                table: "Cashiers",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_Cashiers_UpdatedBy",
                table: "Cashiers",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CuadreItems_CreatedBy",
                table: "CuadreItems",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CuadreItems_CuadreId",
                table: "CuadreItems",
                column: "CuadreId");

            migrationBuilder.CreateIndex(
                name: "IX_CuadreItems_DeletedBy",
                table: "CuadreItems",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CuadreItems_UpdatedBy",
                table: "CuadreItems",
                column: "UpdatedBy");

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

            migrationBuilder.CreateIndex(
                name: "IX_CurrencyRates_CurrencyId",
                table: "CurrencyRates",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_DebPayments_CreatedBy",
                table: "DebPayments",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DebPayments_DeletedBy",
                table: "DebPayments",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DebPayments_SellerId",
                table: "DebPayments",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_DebPayments_UpdatedBy",
                table: "DebPayments",
                column: "UpdatedBy");

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

            migrationBuilder.CreateIndex(
                name: "IX_Shops_CreatedBy",
                table: "Shops",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Shops_CurrencyId",
                table: "Shops",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Shops_DeletedBy",
                table: "Shops",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Shops_UpdatedBy",
                table: "Shops",
                column: "UpdatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Shops_ShopId",
                table: "AspNetUsers",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LotterySales_CashierDetails_CashierDetailId",
                table: "LotterySales",
                column: "CashierDetailId",
                principalTable: "CashierDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
