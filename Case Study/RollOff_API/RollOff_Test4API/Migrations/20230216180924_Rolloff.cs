using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RollOff_Test4API.Migrations
{
    public partial class Rolloff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormTables",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GlobalGroupID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalGrade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimarySkill = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectCode = table.Column<double>(type: "float", nullable: true),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Practice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RollOffEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReasonForRollOff = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThisReleaseNeedsBackfillIsBackfilled = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PerformanceIssue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resigned = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnderProbation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LongLeave = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TechnicalSkills = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Communication = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleCompetencies = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelevantExperienceYears = table.Column<double>(type: "float", nullable: true),
                    EmployeeNumber = table.Column<double>(type: "float", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormTables", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_FormTables_Employees_GlobalGroupID",
                        column: x => x.GlobalGroupID,
                        principalTable: "Employees",
                        principalColumn: "GlobalGroupID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FormTables_GlobalGroupID",
                table: "FormTables",
                column: "GlobalGroupID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormTables");
        }
    }
}
