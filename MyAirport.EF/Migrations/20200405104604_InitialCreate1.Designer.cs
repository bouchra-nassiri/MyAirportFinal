﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyAirport.EF;

namespace MyAirport.EF.Migrations
{
    [DbContext(typeof(MyAirportContext))]
    [Migration("20200405104604_InitialCreate1")]
    partial class InitialCreate1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MyAirport.EF.Bagage", b =>
                {
                    b.Property<int>("BagageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Classe")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CodeIata")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Destination")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Escale")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool?>("Prioritaire")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Ssur")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Sta")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("VolID")
                        .HasColumnType("int");

                    b.HasKey("BagageID");

                    b.HasIndex("VolID");

                    b.ToTable("Bagages");
                });

            modelBuilder.Entity("MyAirport.EF.Vol", b =>
                {
                    b.Property<int>("VolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cie")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Des")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("Dhc")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Imm")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Jex")
                        .HasColumnType("int");

                    b.Property<string>("Lig")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("Pax")
                        .HasColumnType("int");

                    b.Property<string>("Pkg")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("VolId");

                    b.ToTable("Vols");
                });

            modelBuilder.Entity("MyAirport.EF.Bagage", b =>
                {
                    b.HasOne("MyAirport.EF.Vol", "Vol")
                        .WithMany("Bagages")
                        .HasForeignKey("VolID");
                });
#pragma warning restore 612, 618
        }
    }
}
