﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebApplication2.Data;

namespace WebApplication2.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("WebApplication2.Models.Moves", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("MovesNum")
                        .HasColumnType("integer");

                    b.Property<Guid>("PlayerId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("PlayerScoreID")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("PlayerScoreID");

                    b.ToTable("Movess");
                });

            modelBuilder.Entity("WebApplication2.Models.Player", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Difficulty")
                        .HasColumnType("text");

                    b.Property<Guid>("MovesId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<Guid>("PlayerScore")
                        .HasColumnType("uuid");

                    b.HasKey("ID");

                    b.ToTable("PlayerList");
                });

            modelBuilder.Entity("WebApplication2.Models.Moves", b =>
                {
                    b.HasOne("WebApplication2.Models.Player", "PlayerScore")
                        .WithMany()
                        .HasForeignKey("PlayerScoreID");
                });
#pragma warning restore 612, 618
        }
    }
}
