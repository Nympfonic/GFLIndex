using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GFLIndexBackend.Migrations
{
    public partial class UpdatedGFLContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DollStats");

            migrationBuilder.DropTable(
                name: "DollTiles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DollStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DollId = table.Column<int>(type: "int", nullable: true),
                    Armor = table.Column<int>(type: "int", nullable: true),
                    ArmorPenetration = table.Column<int>(type: "int", nullable: true),
                    BaseAccuracy = table.Column<int>(type: "int", nullable: true),
                    BaseAmmoConsumption = table.Column<int>(type: "int", nullable: true),
                    BaseDamage = table.Column<int>(type: "int", nullable: true),
                    BaseEvasion = table.Column<int>(type: "int", nullable: true),
                    BaseHealth = table.Column<int>(type: "int", nullable: true),
                    BaseRateOfFire = table.Column<int>(type: "int", nullable: true),
                    BaseRationConsumption = table.Column<int>(type: "int", nullable: true),
                    CriticalDamage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CriticalRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoveSpeed = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DollStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DollStats_Dolls_DollId",
                        column: x => x.DollId,
                        principalTable: "Dolls",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DollTiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DollId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TileImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DollTiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DollTiles_Dolls_DollId",
                        column: x => x.DollId,
                        principalTable: "Dolls",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DollStats_DollId",
                table: "DollStats",
                column: "DollId");

            migrationBuilder.CreateIndex(
                name: "IX_DollTiles_DollId",
                table: "DollTiles",
                column: "DollId");
        }
    }
}
