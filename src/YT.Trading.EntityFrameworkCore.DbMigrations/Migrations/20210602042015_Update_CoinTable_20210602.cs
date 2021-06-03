using Microsoft.EntityFrameworkCore.Migrations;

namespace YT.Trading.Migrations
{
    public partial class Update_CoinTable_20210602 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_QuetoServer_Coins_CoinCode",
                table: "QuetoServer_Coins");

            migrationBuilder.CreateIndex(
                name: "IX_QuetoServer_Coins_CoinCode",
                table: "QuetoServer_Coins",
                column: "CoinCode",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_QuetoServer_Coins_CoinCode",
                table: "QuetoServer_Coins");

            migrationBuilder.CreateIndex(
                name: "IX_QuetoServer_Coins_CoinCode",
                table: "QuetoServer_Coins",
                column: "CoinCode");
        }
    }
}
