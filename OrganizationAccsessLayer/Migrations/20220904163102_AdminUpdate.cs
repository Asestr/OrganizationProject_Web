using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrganizationAccsessLayer.Migrations
{
    public partial class AdminUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyEvent_Company_OrganizerName",
                table: "CompanyEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyEvent_Events_EventId",
                table: "CompanyEvent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyEvent",
                table: "CompanyEvent");

            migrationBuilder.RenameTable(
                name: "CompanyEvent",
                newName: "CompanyEvents");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyEvent_OrganizerName",
                table: "CompanyEvents",
                newName: "IX_CompanyEvents_OrganizerName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyEvents",
                table: "CompanyEvents",
                columns: new[] { "EventId", "CompanyName" });

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyEvents_Company_OrganizerName",
                table: "CompanyEvents",
                column: "OrganizerName",
                principalTable: "Company",
                principalColumn: "OrganizerName");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyEvents_Events_EventId",
                table: "CompanyEvents",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyEvents_Company_OrganizerName",
                table: "CompanyEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyEvents_Events_EventId",
                table: "CompanyEvents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyEvents",
                table: "CompanyEvents");

            migrationBuilder.RenameTable(
                name: "CompanyEvents",
                newName: "CompanyEvent");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyEvents_OrganizerName",
                table: "CompanyEvent",
                newName: "IX_CompanyEvent_OrganizerName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyEvent",
                table: "CompanyEvent",
                columns: new[] { "EventId", "CompanyName" });

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyEvent_Company_OrganizerName",
                table: "CompanyEvent",
                column: "OrganizerName",
                principalTable: "Company",
                principalColumn: "OrganizerName");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyEvent_Events_EventId",
                table: "CompanyEvent",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
