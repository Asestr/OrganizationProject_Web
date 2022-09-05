using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrganizationAccsessLayer.Migrations
{
    public partial class EntityMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AdminMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "Categorys",
                columns: table => new
                {
                    CategoryName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorys", x => x.CategoryName);
                });

            migrationBuilder.CreateTable(
                name: "Citys",
                columns: table => new
                {
                    CityName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citys", x => x.CityName);
                });

            migrationBuilder.CreateTable(
                name: "CompanyRegistrations",
                columns: table => new
                {
                    CompanyName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CompanyEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyDomain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyPasswordRepeat = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyRegistrations", x => x.CompanyName);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventRecourseOverTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventExplanation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventQuota = table.Column<int>(type: "int", nullable: false),
                    EventTickedOrNotTicked = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                });

            migrationBuilder.CreateTable(
                name: "Organizers",
                columns: table => new
                {
                    OrganizerMail = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrganizerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizerLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizerPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizerPasswordRepeat = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizers", x => x.OrganizerMail);
                });

            migrationBuilder.CreateTable(
                name: "Subcontractors",
                columns: table => new
                {
                    SubcontractorMail = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubcontractorId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubcontractorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubcontractorLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubcontractorPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubcontractorPasswordRepeat = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subcontractors", x => x.SubcontractorMail);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Categorys");

            migrationBuilder.DropTable(
                name: "Citys");

            migrationBuilder.DropTable(
                name: "CompanyRegistrations");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Organizers");

            migrationBuilder.DropTable(
                name: "Subcontractors");
        }
    }
}
