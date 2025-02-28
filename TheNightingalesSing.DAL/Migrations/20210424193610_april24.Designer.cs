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
    [Migration("20210424193610_april24")]
    partial class april24
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
                        .HasPrecision(6, 2)
                        .HasColumnType("numeric(6,2)");

                    b.Property<string>("ReDate")
                        .HasColumnType("text");

                    b.Property<short>("Stock")
                        .HasColumnType("smallint");

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
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

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
                            CreateDate = new DateTime(2021, 4, 24, 22, 36, 9, 867, DateTimeKind.Local).AddTicks(7624),
                            Email = "af.yavuz@gg.com",
                            FirstName = "Ahmet Fehmi",
                            IsActive = true,
                            LastName = "Yavuz",
                            PasswordHash = new byte[] { 12, 9, 14, 66, 48, 54, 33, 140, 83, 152, 156, 52, 188, 86, 243, 156, 16, 158, 99, 1, 12, 243, 230, 209, 109, 249, 250, 193, 193, 133, 80, 128, 23, 46, 118, 82, 251, 205, 184, 72, 146, 25, 38, 143, 10, 104, 137, 14, 106, 72, 68, 198, 231, 59, 1, 215, 218, 55, 95, 175, 87, 0, 154, 68 },
                            PasswordSalt = new byte[] { 169, 59, 146, 114, 42, 39, 133, 175, 83, 40, 53, 194, 101, 145, 173, 135, 106, 200, 220, 193, 184, 151, 193, 221, 48, 180, 42, 62, 78, 7, 69, 102, 231, 150, 75, 202, 249, 106, 160, 206, 193, 164, 255, 102, 14, 126, 56, 12, 30, 63, 124, 32, 224, 179, 160, 106, 56, 149, 207, 10, 57, 11, 155, 218, 232, 169, 189, 10, 254, 49, 107, 22, 248, 207, 219, 58, 249, 74, 222, 107, 72, 105, 217, 177, 219, 73, 255, 149, 135, 84, 202, 179, 59, 3, 44, 210, 218, 117, 137, 48, 120, 239, 67, 155, 131, 128, 133, 123, 224, 90, 8, 232, 134, 167, 150, 29, 73, 128, 204, 72, 11, 229, 76, 129, 240, 216, 118, 92 },
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
