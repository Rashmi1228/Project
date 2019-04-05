using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    symbol = table.Column<string>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    type = table.Column<string>(nullable: true),
                    website = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.symbol);
                });

            migrationBuilder.CreateTable(
                name: "Financials",
                columns: table => new
                {
                    cashFlow = table.Column<decimal>(nullable: false),
                    symbol = table.Column<string>(nullable: true),
                    grossProfit = table.Column<decimal>(nullable: false),
                    totalRevenue = table.Column<decimal>(nullable: false),
                    netIncome = table.Column<decimal>(nullable: false),
                    totalDebt = table.Column<decimal>(nullable: false),
                    totalAssets = table.Column<decimal>(nullable: false),
                    totalLiabilities = table.Column<decimal>(nullable: false),
                    currentAssets = table.Column<decimal>(nullable: false),
                    currentCash = table.Column<decimal>(nullable: false),
                    currentDebt = table.Column<decimal>(nullable: false),
                    totalCash = table.Column<decimal>(nullable: false),
                    costOfRevenue = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Financials", x => x.cashFlow);
                });

            migrationBuilder.CreateTable(
                name: "KeyStats",
                columns: table => new
                {
                    symbol = table.Column<string>(nullable: false),
                    NamedividendRate = table.Column<decimal>(nullable: false),
                    revenue = table.Column<decimal>(nullable: false),
                    grossProfit = table.Column<decimal>(nullable: false),
                    cash = table.Column<decimal>(nullable: false),
                    debt = table.Column<decimal>(nullable: false),
                    revenuePerShare = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyStats", x => x.symbol);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    UserID = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.UserID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Financials");

            migrationBuilder.DropTable(
                name: "KeyStats");

            migrationBuilder.DropTable(
                name: "Login");
        }
    }
}
