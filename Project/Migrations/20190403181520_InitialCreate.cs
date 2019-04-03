using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "C1",
                columns: table => new
                {
                    Symbol = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Date = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_C1", x => x.Symbol);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "C1");
        }
    }
}
