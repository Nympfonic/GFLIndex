using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GFLIndexBackend.Migrations
{
    public partial class AddedDollModsModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "BaseRationConsumption",
                table: "Dolls");

            migrationBuilder.DropColumn(
                name: "CriticalDamage",
                table: "Dolls");

            migrationBuilder.DropColumn(
                name: "CriticalRate",
                table: "Dolls");

            migrationBuilder.DropColumn(
                name: "MoveSpeed",
                table: "Dolls");

            migrationBuilder.DropColumn(
                name: "TileBaseDescription",
                table: "Dolls");

            migrationBuilder.DropColumn(
                name: "TileImage",
                table: "Dolls");

            migrationBuilder.AddColumn<int>(
                name: "DollModId",
                table: "DollSkills",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DollMods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    DollRarityId = table.Column<int>(type: "int", nullable: true),
                    DollTypeId = table.Column<int>(type: "int", nullable: true),
                    DollId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DollMods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DollMods_DollRarities_DollRarityId",
                        column: x => x.DollRarityId,
                        principalTable: "DollRarities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DollMods_Dolls_DollId",
                        column: x => x.DollId,
                        principalTable: "Dolls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DollMods_DollTypes_DollTypeId",
                        column: x => x.DollTypeId,
                        principalTable: "DollTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DollStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Health = table.Column<int>(type: "int", nullable: true),
                    AmmoConsumption = table.Column<int>(type: "int", nullable: true),
                    RationConsumption = table.Column<int>(type: "int", nullable: true),
                    Damage = table.Column<int>(type: "int", nullable: true),
                    Evasion = table.Column<int>(type: "int", nullable: true),
                    Accuracy = table.Column<int>(type: "int", nullable: true),
                    RateOfFire = table.Column<int>(type: "int", nullable: true),
                    MoveSpeed = table.Column<int>(type: "int", nullable: true),
                    Armor = table.Column<int>(type: "int", nullable: true),
                    CriticalRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CriticalDamage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArmorPenetration = table.Column<int>(type: "int", nullable: true),
                    DollId = table.Column<int>(type: "int", nullable: false),
                    DollModId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DollStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DollStats_DollMods_DollModId",
                        column: x => x.DollModId,
                        principalTable: "DollMods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DollStats_Dolls_DollId",
                        column: x => x.DollId,
                        principalTable: "Dolls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DollTiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TileImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    DollId = table.Column<int>(type: "int", nullable: false),
                    DollModId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DollTiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DollTiles_DollMods_DollModId",
                        column: x => x.DollModId,
                        principalTable: "DollMods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DollTiles_Dolls_DollId",
                        column: x => x.DollId,
                        principalTable: "Dolls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DollSkills_DollModId",
                table: "DollSkills",
                column: "DollModId");

            migrationBuilder.CreateIndex(
                name: "IX_DollMods_DollId",
                table: "DollMods",
                column: "DollId");

            migrationBuilder.CreateIndex(
                name: "IX_DollMods_DollRarityId",
                table: "DollMods",
                column: "DollRarityId");

            migrationBuilder.CreateIndex(
                name: "IX_DollMods_DollTypeId",
                table: "DollMods",
                column: "DollTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DollStats_DollId",
                table: "DollStats",
                column: "DollId");

            migrationBuilder.CreateIndex(
                name: "IX_DollStats_DollModId",
                table: "DollStats",
                column: "DollModId");

            migrationBuilder.CreateIndex(
                name: "IX_DollTiles_DollId",
                table: "DollTiles",
                column: "DollId");

            migrationBuilder.CreateIndex(
                name: "IX_DollTiles_DollModId",
                table: "DollTiles",
                column: "DollModId");

            migrationBuilder.AddForeignKey(
                name: "FK_DollSkills_DollMods_DollModId",
                table: "DollSkills",
                column: "DollModId",
                principalTable: "DollMods",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DollSkills_DollMods_DollModId",
                table: "DollSkills");

            migrationBuilder.DropTable(
                name: "DollStats");

            migrationBuilder.DropTable(
                name: "DollTiles");

            migrationBuilder.DropTable(
                name: "DollMods");

            migrationBuilder.DropIndex(
                name: "IX_DollSkills_DollModId",
                table: "DollSkills");

            migrationBuilder.DropColumn(
                name: "DollModId",
                table: "DollSkills");

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

            migrationBuilder.AddColumn<int>(
                name: "BaseRationConsumption",
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

            migrationBuilder.AddColumn<int>(
                name: "MoveSpeed",
                table: "Dolls",
                type: "int",
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
        }
    }
}
