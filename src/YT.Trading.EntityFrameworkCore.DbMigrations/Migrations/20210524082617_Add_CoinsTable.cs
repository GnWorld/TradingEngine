using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YT.Trading.Migrations
{
    public partial class Add_CoinsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuetoServer_Coins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    CoinCode = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    CoinRate = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    AnchoringCoinCode = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    DecimalCount = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatorId = table.Column<Guid>(type: "char(36)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "char(36)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "char(36)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuetoServer_Coins", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuetoServer_Coins_CreationTime",
                table: "QuetoServer_Coins",
                column: "CreationTime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuetoServer_Coins");
        }
    }
}
