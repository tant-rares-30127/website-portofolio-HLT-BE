using Microsoft.EntityFrameworkCore.Migrations;

namespace website_portofolio.Data.Migrations
{
    public partial class LanguagesMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Languages",
                table: "CVData");

            migrationBuilder.AddColumn<int>(
                name: "LanguagesId",
                table: "CVData",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageName1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Understanding1 = table.Column<int>(type: "int", nullable: false),
                    Speaking1 = table.Column<int>(type: "int", nullable: false),
                    Writing1 = table.Column<int>(type: "int", nullable: false),
                    LanguageName2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Understanding2 = table.Column<int>(type: "int", nullable: false),
                    Speaking2 = table.Column<int>(type: "int", nullable: false),
                    Writing2 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CVData_LanguagesId",
                table: "CVData",
                column: "LanguagesId");

            migrationBuilder.AddForeignKey(
                name: "FK_CVData_Languages_LanguagesId",
                table: "CVData",
                column: "LanguagesId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CVData_Languages_LanguagesId",
                table: "CVData");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropIndex(
                name: "IX_CVData_LanguagesId",
                table: "CVData");

            migrationBuilder.DropColumn(
                name: "LanguagesId",
                table: "CVData");

            migrationBuilder.AddColumn<string>(
                name: "Languages",
                table: "CVData",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
