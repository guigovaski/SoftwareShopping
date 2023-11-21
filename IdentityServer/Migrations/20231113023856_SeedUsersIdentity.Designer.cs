﻿// <auto-generated />
using System;
using IdentityServer.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IdentityServer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231113023856_SeedUsersIdentity")]
    partial class SeedUsersIdentity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("IdentityServer.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "59b645ad-1955-4e3f-8abe-8e07d0a56639",
                            AccessFailedCount = 2,
                            ConcurrencyStamp = "d9e89e51-e4c5-4634-a5b4-ea8dcf0f0927",
                            Email = "generic@email.com",
                            EmailConfirmed = true,
                            FirstName = "Guilherme",
                            LastName = "Govaski",
                            LockoutEnabled = false,
                            NormalizedUserName = "GUIGOVASKI",
                            PasswordHash = "AQAAAAEAACcQAAAAEIwK2EXpcU7eEjmLy5riJbXvneM1Pe+LQ8h2GNeQQYK+gk8najN8vOhpInN4Ig29TA==",
                            PhoneNumber = "+5541999999999",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ae038048-1af2-4107-822b-7ee87acdc295",
                            TwoFactorEnabled = false,
                            UserName = "guigovaski"
                        },
                        new
                        {
                            Id = "dc47b963-63dc-4fea-8e31-47f005d3c7bf",
                            AccessFailedCount = 2,
                            ConcurrencyStamp = "f29fd714-3446-406e-8333-a20f3a2735ca",
                            Email = "generic2@email.com",
                            EmailConfirmed = true,
                            FirstName = "Stephany",
                            LastName = "Melo",
                            LockoutEnabled = false,
                            NormalizedUserName = "STEMELO",
                            PasswordHash = "AQAAAAEAACcQAAAAEJv+W5Gfj8abdnGVNYK27S+IViNsQZoqi3ynWiIr+GeMy2ceoj4r463M4hBdLy6VvA==",
                            PhoneNumber = "+5541888888888",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "43b05130-2302-4441-ba49-b23d0079c506",
                            TwoFactorEnabled = false,
                            UserName = "stemelo"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "2bc904e0-3e4e-4582-99b1-9a4b6b84c426",
                            ConcurrencyStamp = "22c70d26-e1c3-44b4-a173-11aa9c1657a8",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "1eb0dd9a-adc6-46ff-9ea1-882b46d2ea59",
                            ConcurrencyStamp = "51ec3737-b25a-4ea9-8baa-d225898f81d7",
                            Name = "Common",
                            NormalizedName = "COMMON"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);

                    b.HasData(
                        new
                        {
                            Id = -1,
                            ClaimType = "email",
                            ClaimValue = "generic@email.com",
                            UserId = "59b645ad-1955-4e3f-8abe-8e07d0a56639"
                        },
                        new
                        {
                            Id = -2,
                            ClaimType = "role",
                            ClaimValue = "Admin",
                            UserId = "59b645ad-1955-4e3f-8abe-8e07d0a56639"
                        },
                        new
                        {
                            Id = -3,
                            ClaimType = "name",
                            ClaimValue = "Guilherme Govaski",
                            UserId = "59b645ad-1955-4e3f-8abe-8e07d0a56639"
                        },
                        new
                        {
                            Id = -4,
                            ClaimType = "email",
                            ClaimValue = "generic2@email.com",
                            UserId = "dc47b963-63dc-4fea-8e31-47f005d3c7bf"
                        },
                        new
                        {
                            Id = -5,
                            ClaimType = "role",
                            ClaimValue = "Common",
                            UserId = "dc47b963-63dc-4fea-8e31-47f005d3c7bf"
                        },
                        new
                        {
                            Id = -6,
                            ClaimType = "name",
                            ClaimValue = "Stephany Melo",
                            UserId = "dc47b963-63dc-4fea-8e31-47f005d3c7bf"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "59b645ad-1955-4e3f-8abe-8e07d0a56639",
                            RoleId = "2bc904e0-3e4e-4582-99b1-9a4b6b84c426"
                        },
                        new
                        {
                            UserId = "dc47b963-63dc-4fea-8e31-47f005d3c7bf",
                            RoleId = "1eb0dd9a-adc6-46ff-9ea1-882b46d2ea59"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("IdentityServer.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("IdentityServer.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IdentityServer.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("IdentityServer.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
