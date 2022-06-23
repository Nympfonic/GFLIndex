using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GFLIndexBackend.Migrations
{
    public partial class AddedDollTypeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dolls_DollType_DollTypeId",
                table: "Dolls");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DollType",
                table: "DollType");

            migrationBuilder.RenameTable(
                name: "DollType",
                newName: "DollTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DollTypes",
                table: "DollTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dolls_DollTypes_DollTypeId",
                table: "Dolls",
                column: "DollTypeId",
                principalTable: "DollTypes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dolls_DollTypes_DollTypeId",
                table: "Dolls");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DollTypes",
                table: "DollTypes");

            migrationBuilder.RenameTable(
                name: "DollTypes",
                newName: "DollType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DollType",
                table: "DollType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dolls_DollType_DollTypeId",
                table: "Dolls",
                column: "DollTypeId",
                principalTable: "DollType",
                principalColumn: "Id");
        }
    }
}
