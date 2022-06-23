using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GFLIndexBackend.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DollStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaseHealth = table.Column<int>(type: "int", nullable: true),
                    BaseAmmoConsumption = table.Column<int>(type: "int", nullable: true),
                    BaseRationConsumption = table.Column<int>(type: "int", nullable: true),
                    BaseDamage = table.Column<int>(type: "int", nullable: true),
                    BaseEvasion = table.Column<int>(type: "int", nullable: true),
                    BaseAccuracy = table.Column<int>(type: "int", nullable: true),
                    BaseRateOfFire = table.Column<int>(type: "int", nullable: true),
                    MoveSpeed = table.Column<int>(type: "int", nullable: true),
                    Armor = table.Column<int>(type: "int", nullable: true),
                    CriticalRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CriticalDamage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArmorPenetration = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DollStats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DollTiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TileImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DollTiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dolls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    DollStats = table.Column<int>(type: "int", nullable: true),
                    DollTiles = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dolls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dolls_DollStats_DollStats",
                        column: x => x.DollStats,
                        principalTable: "DollStats",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Dolls_DollTiles_DollTiles",
                        column: x => x.DollTiles,
                        principalTable: "DollTiles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DollSkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InitialCooldown = table.Column<int>(type: "int", nullable: true),
                    Cooldown = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DollId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DollSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DollSkills_Dolls_DollId",
                        column: x => x.DollId,
                        principalTable: "Dolls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_DollSkills_DollId",
                table: "DollSkills",
                column: "DollId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DollSkills");

            migrationBuilder.DropTable(
                name: "Dolls");

            migrationBuilder.DropTable(
                name: "DollStats");

            migrationBuilder.DropTable(
                name: "DollTiles");
        }
    }
}
