using Microsoft.EntityFrameworkCore.Migrations;

namespace website_portofolio.Data.Migrations
{
    public partial class WorkExperience : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WorkExperience",
                table: "CVData");

            migrationBuilder.RenameColumn(
                name: "NameOfTheInstitution",
                table: "Educations",
                newName: "NameOfTheInstitution2");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Educations",
                newName: "NameOfTheInstitution1");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "Educations",
                newName: "Description2");

            migrationBuilder.AddColumn<string>(
                name: "Data1",
                table: "Educations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Data2",
                table: "Educations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description1",
                table: "Educations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WorkExperienceId",
                table: "CVData",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "WorkExperiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfTheCompany1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Period1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameOfTheCompany2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Period2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkExperiences", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CVData_WorkExperienceId",
                table: "CVData",
                column: "WorkExperienceId");

            migrationBuilder.AddForeignKey(
                name: "FK_CVData_WorkExperiences_WorkExperienceId",
                table: "CVData",
                column: "WorkExperienceId",
                principalTable: "WorkExperiences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CVData_WorkExperiences_WorkExperienceId",
                table: "CVData");

            migrationBuilder.DropTable(
                name: "WorkExperiences");

            migrationBuilder.DropIndex(
                name: "IX_CVData_WorkExperienceId",
                table: "CVData");

            migrationBuilder.DropColumn(
                name: "Data1",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "Data2",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "Description1",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "WorkExperienceId",
                table: "CVData");

            migrationBuilder.RenameColumn(
                name: "NameOfTheInstitution2",
                table: "Educations",
                newName: "NameOfTheInstitution");

            migrationBuilder.RenameColumn(
                name: "NameOfTheInstitution1",
                table: "Educations",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Description2",
                table: "Educations",
                newName: "Data");

            migrationBuilder.AddColumn<string>(
                name: "WorkExperience",
                table: "CVData",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
