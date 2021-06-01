using Microsoft.EntityFrameworkCore.Migrations;

namespace YT.Trading.Migrations
{
    public partial class Update_CoinTable20210531 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CoinType",
                table: "QuetoServer_Coins",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDisable",
                table: "QuetoServer_Coins",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoinType",
                table: "QuetoServer_Coins");

            migrationBuilder.DropColumn(
                name: "IsDisable",
                table: "QuetoServer_Coins");
        }
    }
}
