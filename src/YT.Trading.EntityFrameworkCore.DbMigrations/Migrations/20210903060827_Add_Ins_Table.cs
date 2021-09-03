using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YT.Trading.Migrations
{
    public partial class Add_Ins_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuoteServer_Instrument",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Sort = table.Column<long>(type: "bigint", nullable: false),
                    Desc = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    IsShow = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    EnableQuote = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Code = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    AssetName = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Long = table.Column<long>(type: "bigint", nullable: false),
                    Short = table.Column<long>(type: "bigint", nullable: false),
                    Convertor = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    MinLot = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    MinChange = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Eta = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Psi = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Path = table.Column<string>(type: "varchar(20)", nullable: false),
                    Ask = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Bid = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    FixedSpread = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    PercentageSpread = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    ExtBiz = table.Column<long>(type: "bigint", nullable: false),
                    ExtBizCode = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    InternalInstruments = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    FlushCurType = table.Column<int>(type: "int", nullable: false),
                    MarginCalc = table.Column<int>(type: "int", nullable: false),
                    MarginRateInit = table.Column<float>(type: "float", nullable: false),
                    MarginRateMntn = table.Column<float>(type: "float", nullable: false),
                    MarginMode = table.Column<int>(type: "int", nullable: false),
                    DecimalCount = table.Column<long>(type: "bigint", nullable: false),
                    Formatter = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TradeMode = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_QuoteServer_Instrument", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuoteServer_Instrument_CreationTime",
                table: "QuoteServer_Instrument",
                column: "CreationTime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuoteServer_Instrument");
        }
    }
}
