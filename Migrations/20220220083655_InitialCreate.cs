using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthRazor.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Health",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DiseaseName = table.Column<string>(type: "TEXT", nullable: true),
                    Cause = table.Column<string>(type: "TEXT", nullable: true),
                    Year = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Precaution = table.Column<string>(type: "TEXT", nullable: true),
                    HealthIndex = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Health", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Health");
        }
    }
}
