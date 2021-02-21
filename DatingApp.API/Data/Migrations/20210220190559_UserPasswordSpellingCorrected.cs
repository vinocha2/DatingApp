using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp.API.Data.Migrations
{
    public partial class UserPasswordSpellingCorrected : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PasswrdHash",
                table: "Users",
                newName: "PasswordHash");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "Users",
                newName: "PasswrdHash");
        }
    }
}
