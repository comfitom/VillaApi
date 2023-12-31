﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Villas_VillaApi.Data;

#nullable disable

namespace Villas_VillaApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230928130405_DisableNUll")]
    partial class DisableNUll
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Villas_VillaApi.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Amenity")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Details")
                        .HasColumnType("longtext");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("double");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 9, 28, 14, 4, 4, 320, DateTimeKind.Local).AddTicks(1786),
                            Details = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...",
                            ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Funsplash.com%2Fs%2Fphotos%2Fvilla&psig=AOvVaw0pByoKewJvb4TImGr28PGO&ust=1694522629380000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCIDm_uvKooEDFQAAAAAdAAAAABAE",
                            Name = "Royal Villa",
                            Occupancy = 2,
                            Rate = 700.0,
                            Sqft = 600,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 9, 28, 14, 4, 4, 320, DateTimeKind.Local).AddTicks(1814),
                            Details = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...",
                            ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.istockphoto.com%2Fphotos%2Fvilla&psig=AOvVaw0pByoKewJvb4TImGr28PGO&ust=1694522629380000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCIDm_uvKooEDFQAAAAAdAAAAABAI",
                            Name = "Royal Pool Villa",
                            Occupancy = 2,
                            Rate = 790.0,
                            Sqft = 650,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 9, 28, 14, 4, 4, 320, DateTimeKind.Local).AddTicks(1819),
                            Details = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...",
                            ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fstock.adobe.com%2Fsearch%3Fk%3Dvilla&psig=AOvVaw0pByoKewJvb4TImGr28PGO&ust=1694522629380000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCIDm_uvKooEDFQAAAAAdAAAAABAQ",
                            Name = "Premium Villa",
                            Occupancy = 3,
                            Rate = 1000.0,
                            Sqft = 750,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 9, 28, 14, 4, 4, 320, DateTimeKind.Local).AddTicks(1824),
                            Details = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...",
                            ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.shutterstock.com%2Fsearch%2Fvilla&psig=AOvVaw0pByoKewJvb4TImGr28PGO&ust=1694522629380000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCIDm_uvKooEDFQAAAAAdAAAAABAY",
                            Name = "Premium Pool Villa",
                            Occupancy = 3,
                            Rate = 1500.0,
                            Sqft = 1050,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 9, 28, 14, 4, 4, 320, DateTimeKind.Local).AddTicks(1827),
                            Details = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...",
                            ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Funsplash.com%2Fs%2Fphotos%2Fvilla&psig=AOvVaw0pByoKewJvb4TImGr28PGO&ust=1694522629380000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCIDm_uvKooEDFQAAAAAdAAAAABAg",
                            Name = "Diamond Villa",
                            Occupancy = 4,
                            Rate = 2000.0,
                            Sqft = 1550,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Villas_VillaApi.Models.VillaNumber", b =>
                {
                    b.Property<int>("VillaNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("SpecialDetails")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("VillaId")
                        .HasColumnType("int");

                    b.HasKey("VillaNo");

                    b.HasIndex("VillaId");

                    b.ToTable("villaNumbers");
                });

            modelBuilder.Entity("Villas_VillaApi.Models.VillaNumber", b =>
                {
                    b.HasOne("Villas_VillaApi.Models.Villa", "Villa")
                        .WithMany()
                        .HasForeignKey("VillaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Villa");
                });
#pragma warning restore 612, 618
        }
    }
}
