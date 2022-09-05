using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrganizationAccsessLayer.Migrations
{
    public partial class admindelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Admins_AdminsAdminName",
                table: "Events");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Admins",
                table: "Admins");

            migrationBuilder.RenameTable(
                name: "Admins",
                newName: "Admin");

            migrationBuilder.AlterColumn<string>(
                name: "AdminsAdminName",
                table: "Events",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admin",
                table: "Admin",
                column: "AdminName");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Admin_AdminsAdminName",
                table: "Events",
                column: "AdminsAdminName",
                principalTable: "Admin",
                principalColumn: "AdminName",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Admin_AdminsAdminName",
                table: "Events");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Admin",
                table: "Admin");

            migrationBuilder.RenameTable(
                name: "Admin",
                newName: "Admins");

            migrationBuilder.AlterColumn<string>(
                name: "AdminsAdminName",
                table: "Events",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admins",
                table: "Admins",
                column: "AdminName");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Admins_AdminsAdminName",
                table: "Events",
                column: "AdminsAdminName",
                principalTable: "Admins",
                principalColumn: "AdminName");
        }
    }
}
