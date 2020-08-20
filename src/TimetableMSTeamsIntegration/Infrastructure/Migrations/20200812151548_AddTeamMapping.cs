using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimetableMSTeamsIntegration.Infrastructure.Migrations
{
    public partial class AddTeamMapping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ContingentUnit",
                table: "TeamCreatedEvents",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Discipline",
                table: "TeamCreatedEvents",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Division",
                table: "TeamCreatedEvents",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "Semester",
                table: "TeamCreatedEvents",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "TeamCreatedEvents",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContingentUnit",
                table: "TeamCreatedEvents");

            migrationBuilder.DropColumn(
                name: "Discipline",
                table: "TeamCreatedEvents");

            migrationBuilder.DropColumn(
                name: "Division",
                table: "TeamCreatedEvents");

            migrationBuilder.DropColumn(
                name: "Semester",
                table: "TeamCreatedEvents");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "TeamCreatedEvents");
        }
    }
}
