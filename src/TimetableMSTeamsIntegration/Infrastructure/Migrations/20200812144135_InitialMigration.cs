using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimetableMSTeamsIntegration.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MeetingCanceledEvents",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    TeamId = table.Column<Guid>(nullable: false),
                    MeetingId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingCanceledEvents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeetingCreatedEvents",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    TeamId = table.Column<Guid>(nullable: false),
                    StartsAt = table.Column<DateTime>(nullable: false),
                    EndsAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingCreatedEvents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeetingShiftedEvents",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    MeetingId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingShiftedEvents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemberAddedEvents",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    TeamId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberAddedEvents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemberRemovedEvents",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    TeamId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberRemovedEvents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamClosedEvents",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    TeamId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamClosedEvents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamCreatedEvents",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamCreatedEvents", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeetingCanceledEvents");

            migrationBuilder.DropTable(
                name: "MeetingCreatedEvents");

            migrationBuilder.DropTable(
                name: "MeetingShiftedEvents");

            migrationBuilder.DropTable(
                name: "MemberAddedEvents");

            migrationBuilder.DropTable(
                name: "MemberRemovedEvents");

            migrationBuilder.DropTable(
                name: "TeamClosedEvents");

            migrationBuilder.DropTable(
                name: "TeamCreatedEvents");
        }
    }
}
