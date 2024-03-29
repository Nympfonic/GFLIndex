﻿// <auto-generated />
using System;
using GFLIndexBackend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GFLIndexBackend.Migrations
{
    [DbContext(typeof(GFLContext))]
    [Migration("20220623204707_MoveDollStatsAndTilesModelsToDollModel")]
    partial class MoveDollStatsAndTilesModelsToDollModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GFLIndexBackend.Models.Doll", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Armor")
                        .HasColumnType("int");

                    b.Property<int?>("ArmorPenetration")
                        .HasColumnType("int");

                    b.Property<int?>("BaseAccuracy")
                        .HasColumnType("int");

                    b.Property<int?>("BaseAmmoConsumption")
                        .HasColumnType("int");

                    b.Property<int?>("BaseDamage")
                        .HasColumnType("int");

                    b.Property<int?>("BaseEvasion")
                        .HasColumnType("int");

                    b.Property<int?>("BaseHealth")
                        .HasColumnType("int");

                    b.Property<int?>("BaseRateOfFire")
                        .HasColumnType("int");

                    b.Property<int?>("BaseRationConsumption")
                        .HasColumnType("int");

                    b.Property<string>("CriticalDamage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CriticalRate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DollRarityId")
                        .HasColumnType("int");

                    b.Property<int?>("DollTypeId")
                        .HasColumnType("int");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("MoveSpeed")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TileBaseDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("TileImage")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("DollRarityId");

                    b.HasIndex("DollTypeId");

                    b.ToTable("Dolls");
                });

            modelBuilder.Entity("GFLIndexBackend.Models.DollRarity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Rarity")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DollRarities");
                });

            modelBuilder.Entity("GFLIndexBackend.Models.DollSkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Cooldown")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DollId")
                        .HasColumnType("int");

                    b.Property<int?>("InitialCooldown")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DollId");

                    b.ToTable("DollSkills");
                });

            modelBuilder.Entity("GFLIndexBackend.Models.DollStats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Armor")
                        .HasColumnType("int");

                    b.Property<int?>("ArmorPenetration")
                        .HasColumnType("int");

                    b.Property<int?>("BaseAccuracy")
                        .HasColumnType("int");

                    b.Property<int?>("BaseAmmoConsumption")
                        .HasColumnType("int");

                    b.Property<int?>("BaseDamage")
                        .HasColumnType("int");

                    b.Property<int?>("BaseEvasion")
                        .HasColumnType("int");

                    b.Property<int?>("BaseHealth")
                        .HasColumnType("int");

                    b.Property<int?>("BaseRateOfFire")
                        .HasColumnType("int");

                    b.Property<int?>("BaseRationConsumption")
                        .HasColumnType("int");

                    b.Property<string>("CriticalDamage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CriticalRate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DollId")
                        .HasColumnType("int");

                    b.Property<int?>("MoveSpeed")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DollId");

                    b.ToTable("DollStats");
                });

            modelBuilder.Entity("GFLIndexBackend.Models.DollTiles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DollId")
                        .HasColumnType("int");

                    b.Property<byte[]>("TileImage")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("DollId");

                    b.ToTable("DollTiles");
                });

            modelBuilder.Entity("GFLIndexBackend.Models.DollType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DollTypes");
                });

            modelBuilder.Entity("GFLIndexBackend.Models.Doll", b =>
                {
                    b.HasOne("GFLIndexBackend.Models.DollRarity", "Rarity")
                        .WithMany("Dolls")
                        .HasForeignKey("DollRarityId");

                    b.HasOne("GFLIndexBackend.Models.DollType", "Type")
                        .WithMany("Dolls")
                        .HasForeignKey("DollTypeId");

                    b.Navigation("Rarity");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("GFLIndexBackend.Models.DollSkill", b =>
                {
                    b.HasOne("GFLIndexBackend.Models.Doll", "Doll")
                        .WithMany("Skills")
                        .HasForeignKey("DollId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doll");
                });

            modelBuilder.Entity("GFLIndexBackend.Models.DollStats", b =>
                {
                    b.HasOne("GFLIndexBackend.Models.Doll", "Doll")
                        .WithMany()
                        .HasForeignKey("DollId");

                    b.Navigation("Doll");
                });

            modelBuilder.Entity("GFLIndexBackend.Models.DollTiles", b =>
                {
                    b.HasOne("GFLIndexBackend.Models.Doll", "Doll")
                        .WithMany()
                        .HasForeignKey("DollId");

                    b.Navigation("Doll");
                });

            modelBuilder.Entity("GFLIndexBackend.Models.Doll", b =>
                {
                    b.Navigation("Skills");
                });

            modelBuilder.Entity("GFLIndexBackend.Models.DollRarity", b =>
                {
                    b.Navigation("Dolls");
                });

            modelBuilder.Entity("GFLIndexBackend.Models.DollType", b =>
                {
                    b.Navigation("Dolls");
                });
#pragma warning restore 612, 618
        }
    }
}
