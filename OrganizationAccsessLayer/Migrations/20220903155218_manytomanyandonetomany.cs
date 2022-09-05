using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrganizationAccsessLayer.Migrations
{
    public partial class manytomanyandonetomany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubcontractorId",
                table: "Subcontractors");

            migrationBuilder.AddColumn<string>(
                name: "CategoryName",
                table: "Events",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CategoryName1",
                table: "Events",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CityName",
                table: "Events",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CityName1",
                table: "Events",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SubconEvents",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false),
                    SubcontractorMail = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubconEvents", x => new { x.EventId, x.SubcontractorMail });
                    table.ForeignKey(
                        name: "FK_SubconEvents_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubconEvents_Subcontractors_SubcontractorMail",
                        column: x => x.SubcontractorMail,
                        principalTable: "Subcontractors",
                        principalColumn: "SubcontractorMail",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_CategoryName1",
                table: "Events",
                column: "CategoryName1");

            migrationBuilder.CreateIndex(
                name: "IX_Events_CityName1",
                table: "Events",
                column: "CityName1");

            migrationBuilder.CreateIndex(
                name: "IX_SubconEvents_SubcontractorMail",
                table: "SubconEvents",
                column: "SubcontractorMail");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Categorys_CategoryName1",
                table: "Events",
                column: "CategoryName1",
                principalTable: "Categorys",
                principalColumn: "CategoryName");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Citys_CityName1",
                table: "Events",
                column: "CityName1",
                principalTable: "Citys",
                principalColumn: "CityName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Categorys_CategoryName1",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Citys_CityName1",
                table: "Events");

            migrationBuilder.DropTable(
                name: "SubconEvents");

            migrationBuilder.DropIndex(
                name: "IX_Events_CategoryName1",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_CityName1",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "CategoryName",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "CategoryName1",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "CityName",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "CityName1",
                table: "Events");

            migrationBuilder.AddColumn<string>(
                name: "SubcontractorId",
                table: "Subcontractors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
