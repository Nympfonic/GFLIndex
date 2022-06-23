using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GFLIndexBackend.Migrations
{
    public partial class MoveDollStatsAndTilesModelsToDollModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dolls_DollStats_DollStats",
                table: "Dolls");

            migrationBuilder.DropForeignKey(
                name: "FK_Dolls_DollTiles_DollTiles",
                table: "Dolls");

            migrationBuilder.DropIndex(
                name: "IX_Dolls_DollStats",
                table: "Dolls");

            migrationBuilder.DropIndex(
                name: "IX_Dolls_DollTiles",
                table: "Dolls");

            migrationBuilder.RenameColumn(
                name: "DollTiles",
                table: "Dolls",
                newName: "MoveSpeed");

            migrationBuilder.RenameColumn(
                name: "DollStats",
                table: "Dolls",
                newName: "BaseRationConsumption");

            migrationBuilder.AddColumn<int>(
                name: "DollId",
                table: "DollTiles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DollId",
                table: "DollStats",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Armor",
                table: "Dolls",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ArmorPenetration",
                table: "Dolls",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BaseAccuracy",
                table: "Dolls",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BaseAmmoConsumption",
                table: "Dolls",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BaseDamage",
                table: "Dolls",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BaseEvasion",
                table: "Dolls",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BaseHealth",
                table: "Dolls",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BaseRateOfFire",
                table: "Dolls",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CriticalDamage",
                table: "Dolls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CriticalRate",
                table: "Dolls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TileBaseDescription",
                table: "Dolls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "TileImage",
                table: "Dolls",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DollTiles_DollId",
                table: "DollTiles",
                column: "DollId");

            migrationBuilder.CreateIndex(
                name: "IX_DollStats_DollId",
                table: "DollStats",
                column: "DollId");

            migrationBuilder.AddForeignKey(
                name: "FK_DollStats_Dolls_DollId",
                table: "DollStats",
                column: "DollId",
                principalTable: "Dolls",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DollTiles_Dolls_DollId",
                table: "DollTiles",
                column: "DollId",
                principalTable: "Dolls",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DollStats_Dolls_DollId",
                table: "DollStats");

            migrationBuilder.DropForeignKey(
                name: "FK_DollTiles_Dolls_DollId",
                table: "DollTiles");

            migrationBuilder.DropIndex(
                name: "IX_DollTiles_DollId",
                table: "DollTiles");

            migrationBuilder.DropIndex(
                name: "IX_DollStats_DollId",
                table: "DollStats");

            migrationBuilder.DropColumn(
                name: "DollId",
                table: "DollTiles");

            migrationBuilder.DropColumn(
                name: "DollId",
                table: "DollStats");

            migrationBuilder.DropColumn(
                name: "Armor",
                table: "Dolls");

            migrationBuilder.DropColumn(
                name: "ArmorPenetration",
                table: "Dolls");

            migrationBuilder.DropColumn(
                name: "BaseAccuracy",
                table: "Dolls");

            migrationBuilder.DropColumn(
                name: "BaseAmmoConsumption",
                table: "Dolls");

            migrationBuilder.DropColumn(
                name: "BaseDamage",
                table: "Dolls");

            migrationBuilder.DropColumn(
                name: "BaseEvasion",
                table: "Dolls");

            migrationBuilder.DropColumn(
                name: "BaseHealth",
                table: "Dolls");

            migrationBuilder.DropColumn(
                name: "BaseRateOfFire",
                table: "Dolls");

            migrationBuilder.DropColumn(
                name: "CriticalDamage",
                table: "Dolls");

            migrationBuilder.DropColumn(
                name: "CriticalRate",
                table: "Dolls");

            migrationBuilder.DropColumn(
                name: "TileBaseDescription",
                table: "Dolls");

            migrationBuilder.DropColumn(
                name: "TileImage",
                table: "Dolls");

            migrationBuilder.RenameColumn(
                name: "MoveSpeed",
                table: "Dolls",
                newName: "DollTiles");

            migrationBuilder.RenameColumn(
                name: "BaseRationConsumption",
                table: "Dolls",
                newName: "DollStats");

            migrationBuilder.CreateIndex(
                name: "IX_Dolls_DollStats",
                table: "Dolls",
                column: "DollStats",
                unique: true,
                filter: "[DollStats] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Dolls_DollTiles",
                table: "Dolls",
                column: "DollTiles",
                unique: true,
                filter: "[DollTiles] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Dolls_DollStats_DollStats",
                table: "Dolls",
                column: "DollStats",
                principalTable: "DollStats",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dolls_DollTiles_DollTiles",
                table: "Dolls",
                column: "DollTiles",
                principalTable: "DollTiles",
                principalColumn: "Id");
        }
    }
}
