using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrganizationAccsessLayer.Migrations
{
    public partial class CompanyEventOrganEvent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyRegistrations");

            migrationBuilder.DropColumn(
                name: "OrganizerId",
                table: "Organizers");

            migrationBuilder.AddColumn<bool>(
                name: "SubcontractorLoginControl",
                table: "Subcontractors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "OrganizerLoginControl",
                table: "Organizers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CompanyEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyDomain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyPasswordRepeat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyLoginControl = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyName);
                });

            migrationBuilder.CreateTable(
                name: "OrganEvents",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false),
                    OrganizerMail = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganEvents", x => new { x.EventId, x.OrganizerMail });
                    table.ForeignKey(
                        name: "FK_OrganEvents_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrganEvents_Organizers_OrganizerMail",
                        column: x => x.OrganizerMail,
                        principalTable: "Organizers",
                        principalColumn: "OrganizerMail",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyEvent",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrganizerCompanyName = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyEvent", x => new { x.EventId, x.CompanyName });
                    table.ForeignKey(
                        name: "FK_CompanyEvent_Company_OrganizerCompanyName",
                        column: x => x.OrganizerCompanyName,
                        principalTable: "Company",
                        principalColumn: "CompanyName");
                    table.ForeignKey(
                        name: "FK_CompanyEvent_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyEvent_OrganizerCompanyName",
                table: "CompanyEvent",
                column: "OrganizerCompanyName");

            migrationBuilder.CreateIndex(
                name: "IX_OrganEvents_OrganizerMail",
                table: "OrganEvents",
                column: "OrganizerMail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyEvent");

            migrationBuilder.DropTable(
                name: "OrganEvents");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropColumn(
                name: "SubcontractorLoginControl",
                table: "Subcontractors");

            migrationBuilder.DropColumn(
                name: "OrganizerLoginControl",
                table: "Organizers");

            migrationBuilder.AddColumn<string>(
                name: "OrganizerId",
                table: "Organizers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "CompanyRegistrations",
                columns: table => new
                {
                    CompanyName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CompanyDomain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyPasswordRepeat = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyRegistrations", x => x.CompanyName);
                });
        }
    }
}
