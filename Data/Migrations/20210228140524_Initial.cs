using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YemekhaneCoreApi.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Food1 = table.Column<string>(type: "TEXT", nullable: true),
                    Food2 = table.Column<string>(type: "TEXT", nullable: true),
                    Food3 = table.Column<string>(type: "TEXT", nullable: true),
                    Food4 = table.Column<string>(type: "TEXT", nullable: true),
                    Food5 = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodPlans", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodPlans");
        }
    }
}
