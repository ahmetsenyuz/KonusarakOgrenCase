using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KonusarakOgrenCase.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Header = table.Column<string>(type: "TEXT", nullable: true),
                    Essay = table.Column<string>(type: "TEXT", nullable: true),
                    Title1 = table.Column<string>(type: "TEXT", nullable: true),
                    Option1A = table.Column<string>(type: "TEXT", nullable: true),
                    Option1B = table.Column<string>(type: "TEXT", nullable: true),
                    Option1C = table.Column<string>(type: "TEXT", nullable: true),
                    Option1D = table.Column<string>(type: "TEXT", nullable: true),
                    CorrectAnswer1 = table.Column<string>(type: "TEXT", nullable: true),
                    Title2 = table.Column<string>(type: "TEXT", nullable: true),
                    Option2A = table.Column<string>(type: "TEXT", nullable: true),
                    Option2B = table.Column<string>(type: "TEXT", nullable: true),
                    Option2C = table.Column<string>(type: "TEXT", nullable: true),
                    Option2D = table.Column<string>(type: "TEXT", nullable: true),
                    CorrectAnswer2 = table.Column<string>(type: "TEXT", nullable: true),
                    Title3 = table.Column<string>(type: "TEXT", nullable: true),
                    Option3A = table.Column<string>(type: "TEXT", nullable: true),
                    Option3B = table.Column<string>(type: "TEXT", nullable: true),
                    Option3C = table.Column<string>(type: "TEXT", nullable: true),
                    Option3D = table.Column<string>(type: "TEXT", nullable: true),
                    CorrectAnswer3 = table.Column<string>(type: "TEXT", nullable: true),
                    Title4 = table.Column<string>(type: "TEXT", nullable: true),
                    Option4A = table.Column<string>(type: "TEXT", nullable: true),
                    Option4B = table.Column<string>(type: "TEXT", nullable: true),
                    Option4C = table.Column<string>(type: "TEXT", nullable: true),
                    Option4D = table.Column<string>(type: "TEXT", nullable: true),
                    CorrectAnswer4 = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exams");
        }
    }
}
