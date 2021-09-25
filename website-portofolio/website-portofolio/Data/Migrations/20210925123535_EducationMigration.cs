using Microsoft.EntityFrameworkCore.Migrations;

namespace website_portofolio.Data.Migrations
{
    public partial class EducationMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Education",
                table: "CVData");

            migrationBuilder.AddColumn<int>(
                name: "EducationId",
                table: "CVData",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfTheInstitution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CVData_EducationId",
                table: "CVData",
                column: "EducationId");

            migrationBuilder.AddForeignKey(
                name: "FK_CVData_Educations_EducationId",
                table: "CVData",
                column: "EducationId",
                principalTable: "Educations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CVData_Educations_EducationId",
                table: "CVData");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropIndex(
                name: "IX_CVData_EducationId",
                table: "CVData");

            migrationBuilder.DropColumn(
                name: "EducationId",
                table: "CVData");

            migrationBuilder.AddColumn<string>(
                name: "Education",
                table: "CVData",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
