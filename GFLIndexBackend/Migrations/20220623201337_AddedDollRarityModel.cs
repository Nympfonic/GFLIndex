using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GFLIndexBackend.Migrations
{
    public partial class AddedDollRarityModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dolls_DollRarity_DollRarityId",
                table: "Dolls");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DollRarity",
                table: "DollRarity");

            migrationBuilder.RenameTable(
                name: "DollRarity",
                newName: "DollRarities");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DollRarities",
                table: "DollRarities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dolls_DollRarities_DollRarityId",
                table: "Dolls",
                column: "DollRarityId",
                principalTable: "DollRarities",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dolls_DollRarities_DollRarityId",
                table: "Dolls");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DollRarities",
                table: "DollRarities");

            migrationBuilder.RenameTable(
                name: "DollRarities",
                newName: "DollRarity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DollRarity",
                table: "DollRarity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dolls_DollRarity_DollRarityId",
                table: "Dolls",
                column: "DollRarityId",
                principalTable: "DollRarity",
                principalColumn: "Id");
        }
    }
}
