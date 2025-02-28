﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TheNightingalesSing.DAL.Concrete;

namespace TheNightingalesSing.DAL.Migrations
{
    [DbContext(typeof(TheNightingalesSingDbContext))]
    [Migration("20201202092257_second")]
    partial class second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TheNightingalesSing.Model.Entities.Album", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityAlwaysColumn();

                    b.Property<string>("ArtUrl")
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<int>("ArtistID")
                        .HasColumnType("integer");

                    b.Property<bool>("Continued")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Discount")
                        .HasColumnType("boolean");

                    b.Property<int>("GenreID")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<decimal>("Price")
                        .HasPrecision(3, 2)
                        .HasColumnType("numeric(3,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("ID");

                    b.HasIndex("ArtistID");

                    b.HasIndex("GenreID");

                    b.ToTable("Album");
                });

            modelBuilder.Entity("TheNightingalesSing.Model.Entities.Artist", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityAlwaysColumn();

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.HasKey("ID");

                    b.ToTable("Artist");
                });

            modelBuilder.Entity("TheNightingalesSing.Model.Entities.Genre", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityAlwaysColumn();

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("ID");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("TheNightingalesSing.Model.Entities.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityAlwaysColumn();

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ShipAddress")
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("TheNightingalesSing.Model.Entities.OrderDetail", b =>
                {
                    b.Property<int>("AlbumID")
                        .HasColumnType("integer");

                    b.Property<int>("OrderID")
                        .HasColumnType("integer");

                    b.Property<double>("Discount")
                        .HasColumnType("double precision");

                    b.Property<decimal>("Price")
                        .HasPrecision(5, 2)
                        .HasColumnType("numeric(5,2)");

                    b.Property<short>("Quantity")
                        .HasColumnType("smallint");

                    b.HasKey("AlbumID", "OrderID");

                    b.HasIndex("OrderID");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("TheNightingalesSing.Model.Entities.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityAlwaysColumn();

                    b.Property<Guid>("ActivationCode")
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("bytea");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)");

                    b.HasKey("ID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ActivationCode = new Guid("00000000-0000-0000-0000-000000000000"),
                            Address = "Rize",
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateDate = new DateTime(2020, 12, 2, 12, 22, 57, 202, DateTimeKind.Local).AddTicks(8681),
                            Email = "af.yavuz@gg.com",
                            FirstName = "Ahmet Fehmi",
                            IsActive = true,
                            LastName = "Yavuz",
                            PasswordHash = new byte[] { 38, 66, 67, 202, 120, 148, 47, 12, 15, 28, 18, 235, 224, 32, 138, 133, 138, 217, 27, 41, 145, 8, 108, 149, 2, 147, 130, 183, 218, 155, 55, 59, 124, 229, 61, 158, 240, 40, 76, 87, 84, 83, 189, 213, 176, 56, 29, 84, 24, 179, 73, 72, 246, 107, 143, 9, 117, 191, 56, 169, 96, 230, 227, 46 },
                            PasswordSalt = new byte[] { 94, 236, 27, 239, 91, 65, 31, 213, 219, 110, 132, 54, 168, 155, 58, 184, 247, 225, 176, 23, 39, 130, 31, 216, 219, 129, 40, 173, 231, 185, 189, 229, 40, 117, 202, 85, 103, 205, 12, 123, 168, 106, 248, 184, 88, 2, 62, 237, 180, 186, 83, 212, 204, 90, 223, 121, 47, 136, 107, 243, 159, 143, 140, 204, 198, 144, 131, 61, 99, 65, 164, 17, 32, 144, 115, 234, 130, 7, 25, 18, 85, 44, 24, 251, 13, 211, 33, 90, 59, 125, 236, 162, 45, 18, 72, 38, 127, 151, 230, 29, 100, 36, 82, 210, 147, 26, 229, 193, 0, 178, 26, 3, 172, 2, 142, 225, 175, 94, 217, 105, 64, 251, 233, 176, 63, 99, 209, 129 },
                            Role = 2,
                            UserName = "Admin"
                        });
                });

            modelBuilder.Entity("TheNightingalesSing.Model.Entities.Album", b =>
                {
                    b.HasOne("TheNightingalesSing.Model.Entities.Artist", "Artist")
                        .WithMany("Album")
                        .HasForeignKey("ArtistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TheNightingalesSing.Model.Entities.Genre", "Genre")
                        .WithMany("Album")
                        .HasForeignKey("GenreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("TheNightingalesSing.Model.Entities.Order", b =>
                {
                    b.HasOne("TheNightingalesSing.Model.Entities.User", "User")
                        .WithMany("Order")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TheNightingalesSing.Model.Entities.OrderDetail", b =>
                {
                    b.HasOne("TheNightingalesSing.Model.Entities.Album", "Album")
                        .WithMany("OrderDetail")
                        .HasForeignKey("AlbumID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TheNightingalesSing.Model.Entities.Order", "Order")
                        .WithMany("OrderDetail")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("TheNightingalesSing.Model.Entities.Album", b =>
                {
                    b.Navigation("OrderDetail");
                });

            modelBuilder.Entity("TheNightingalesSing.Model.Entities.Artist", b =>
                {
                    b.Navigation("Album");
                });

            modelBuilder.Entity("TheNightingalesSing.Model.Entities.Genre", b =>
                {
                    b.Navigation("Album");
                });

            modelBuilder.Entity("TheNightingalesSing.Model.Entities.Order", b =>
                {
                    b.Navigation("OrderDetail");
                });

            modelBuilder.Entity("TheNightingalesSing.Model.Entities.User", b =>
                {
                    b.Navigation("Order");
                });
#pragma warning restore 612, 618
        }
    }
}
