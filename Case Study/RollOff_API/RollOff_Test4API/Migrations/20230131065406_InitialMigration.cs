using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RollOff_Test4API.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    GlobalGroupID = table.Column<int>(type: "int", nullable: false),
                    EmployeeNo = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalGrade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JoiningDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProjectCode = table.Column<int>(type: "int", nullable: true),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProjectEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PeopleManager = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Practice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PSPName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewGlobalPractice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficeCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.GlobalGroupID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
