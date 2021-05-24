using Microsoft.EntityFrameworkCore.Migrations;

namespace YT.Trading.Migrations
{
    public partial class Modify_Coin_202105241919 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CoinCode",
                table: "QuetoServer_Coins",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AnchoringCoinCode",
                table: "QuetoServer_Coins",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.CreateIndex(
                name: "IX_QuetoServer_Coins_CoinCode",
                table: "QuetoServer_Coins",
                column: "CoinCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_QuetoServer_Coins_CoinCode",
                table: "QuetoServer_Coins");

            migrationBuilder.AlterColumn<string>(
                name: "CoinCode",
                table: "QuetoServer_Coins",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<decimal>(
                name: "AnchoringCoinCode",
                table: "QuetoServer_Coins",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20);
        }
    }
}
