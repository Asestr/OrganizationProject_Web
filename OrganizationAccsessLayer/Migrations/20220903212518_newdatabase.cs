
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrganizationAccsessLayer.Migrations
{
    public partial class newdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyEvent_Company_OrganizerCompanyName",
                table: "CompanyEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Categorys_CategoryName1",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Citys_CityName1",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "AdminMail",
                table: "Admins");

            migrationBuilder.RenameColumn(
                name: "CityName1",
                table: "Events",
                newName: "CitysCityName");

            migrationBuilder.RenameColumn(
                name: "CategoryName1",
                table: "Events",
                newName: "CategorysCategoryName");

            migrationBuilder.RenameIndex(
                name: "IX_Events_CityName1",
                table: "Events",
                newName: "IX_Events_CitysCityName");

            migrationBuilder.RenameIndex(
                name: "IX_Events_CategoryName1",
                table: "Events",
                newName: "IX_Events_CategorysCategoryName");

            migrationBuilder.RenameColumn(
                name: "OrganizerCompanyName",
                table: "CompanyEvent",
                newName: "OrganizerName");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyEvent_OrganizerCompanyName",
                table: "CompanyEvent",
                newName: "IX_CompanyEvent_OrganizerName");

            migrationBuilder.RenameColumn(
                name: "CompanyPasswordRepeat",
                table: "Company",
                newName: "OrganizerPasswordRepeat");

            migrationBuilder.RenameColumn(
                name: "CompanyPassword",
                table: "Company",
                newName: "OrganizerPassword");

            migrationBuilder.RenameColumn(
                name: "CompanyLoginControl",
                table: "Company",
                newName: "OrganizerLoginControl");

            migrationBuilder.RenameColumn(
                name: "CompanyEmail",
                table: "Company",
                newName: "OrganizerMail");

            migrationBuilder.RenameColumn(
                name: "CompanyDomain",
                table: "Company",
                newName: "OrganizerLastName");

            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "Company",
                newName: "OrganizerName");

            migrationBuilder.RenameColumn(
                name: "AdminId",
                table: "Admins",
                newName: "AdminName");

            migrationBuilder.AddColumn<string>(
                name: "Admin",
                table: "Events",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AdminsAdminName",
                table: "Events",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Events_AdminsAdminName",
                table: "Events",
                column: "AdminsAdminName");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyEvent_Company_OrganizerName",
                table: "CompanyEvent",
                column: "OrganizerName",
                principalTable: "Company",
                principalColumn: "OrganizerName");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Admins_AdminsAdminName",
                table: "Events",
                column: "AdminsAdminName",
                principalTable: "Admins",
                principalColumn: "AdminName");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Categorys_CategorysCategoryName",
                table: "Events",
                column: "CategorysCategoryName",
                principalTable: "Categorys",
                principalColumn: "CategoryName");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Citys_CitysCityName",
                table: "Events",
                column: "CitysCityName",
                principalTable: "Citys",
                principalColumn: "CityName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyEvent_Company_OrganizerName",
                table: "CompanyEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Admins_AdminsAdminName",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Categorys_CategorysCategoryName",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Citys_CitysCityName",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_AdminsAdminName",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Admin",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "AdminsAdminName",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "CitysCityName",
                table: "Events",
                newName: "CityName1");

            migrationBuilder.RenameColumn(
                name: "CategorysCategoryName",
                table: "Events",
                newName: "CategoryName1");

            migrationBuilder.RenameIndex(
                name: "IX_Events_CitysCityName",
                table: "Events",
                newName: "IX_Events_CityName1");

            migrationBuilder.RenameIndex(
                name: "IX_Events_CategorysCategoryName",
                table: "Events",
                newName: "IX_Events_CategoryName1");

            migrationBuilder.RenameColumn(
                name: "OrganizerName",
                table: "CompanyEvent",
                newName: "OrganizerCompanyName");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyEvent_OrganizerName",
                table: "CompanyEvent",
                newName: "IX_CompanyEvent_OrganizerCompanyName");

            migrationBuilder.RenameColumn(
                name: "OrganizerPasswordRepeat",
                table: "Company",
                newName: "CompanyPasswordRepeat");

            migrationBuilder.RenameColumn(
                name: "OrganizerPassword",
                table: "Company",
                newName: "CompanyPassword");

            migrationBuilder.RenameColumn(
                name: "OrganizerMail",
                table: "Company",
                newName: "CompanyEmail");

            migrationBuilder.RenameColumn(
                name: "OrganizerLoginControl",
                table: "Company",
                newName: "CompanyLoginControl");

            migrationBuilder.RenameColumn(
                name: "OrganizerLastName",
                table: "Company",
                newName: "CompanyDomain");

            migrationBuilder.RenameColumn(
                name: "OrganizerName",
                table: "Company",
                newName: "CompanyName");

            migrationBuilder.RenameColumn(
                name: "AdminName",
                table: "Admins",
                newName: "AdminId");

            migrationBuilder.AddColumn<string>(
                name: "AdminMail",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyEvent_Company_OrganizerCompanyName",
                table: "CompanyEvent",
                column: "OrganizerCompanyName",
                principalTable: "Company",
                principalColumn: "CompanyName");

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
    }
}
