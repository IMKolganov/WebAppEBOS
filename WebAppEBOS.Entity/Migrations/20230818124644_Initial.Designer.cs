﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppEBOS.Entity;

#nullable disable

namespace WebAppEBOS.Entity.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230818124644_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebAppEBOS.Entity.Entites.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RefAppId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Customers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9475),
                            Name = "John",
                            RefAppId = 1,
                            Status = 1,
                            Updated = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9477)
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9483),
                            Name = "Emily",
                            RefAppId = 1,
                            Status = 1,
                            Updated = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9483)
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9485),
                            Name = "Michael",
                            RefAppId = 1,
                            Status = 1,
                            Updated = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9485)
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9486),
                            Name = "Sophia",
                            RefAppId = 1,
                            Status = 1,
                            Updated = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9486)
                        },
                        new
                        {
                            Id = 5,
                            Created = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9487),
                            Name = "William",
                            RefAppId = 1,
                            Status = 1,
                            Updated = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9487)
                        },
                        new
                        {
                            Id = 7,
                            Created = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9490),
                            Name = "Olivia",
                            RefAppId = 1,
                            Status = 1,
                            Updated = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9490)
                        },
                        new
                        {
                            Id = 8,
                            Created = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9491),
                            Name = "Liam",
                            RefAppId = 1,
                            Status = 1,
                            Updated = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9492)
                        },
                        new
                        {
                            Id = 9,
                            Created = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9493),
                            Name = "Ava",
                            RefAppId = 1,
                            Status = 1,
                            Updated = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9493)
                        },
                        new
                        {
                            Id = 10,
                            Created = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9494),
                            Name = "Noah",
                            RefAppId = 1,
                            Status = 1,
                            Updated = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9494)
                        },
                        new
                        {
                            Id = 11,
                            Created = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9496),
                            Name = "Isabella",
                            RefAppId = 1,
                            Status = 1,
                            Updated = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9496)
                        },
                        new
                        {
                            Id = 12,
                            Created = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9497),
                            Name = "James",
                            RefAppId = 1,
                            Status = 1,
                            Updated = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9497)
                        },
                        new
                        {
                            Id = 13,
                            Created = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9498),
                            Name = "Emma",
                            RefAppId = 1,
                            Status = 1,
                            Updated = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9498)
                        },
                        new
                        {
                            Id = 14,
                            Created = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9499),
                            Name = "Benjamin",
                            RefAppId = 1,
                            Status = 1,
                            Updated = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9499)
                        },
                        new
                        {
                            Id = 15,
                            Created = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9500),
                            Name = "Mia",
                            RefAppId = 1,
                            Status = 1,
                            Updated = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9500)
                        },
                        new
                        {
                            Id = 16,
                            Created = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9501),
                            Name = "Ethan",
                            RefAppId = 1,
                            Status = 1,
                            Updated = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9502)
                        },
                        new
                        {
                            Id = 17,
                            Created = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9503),
                            Name = "Charlotte",
                            RefAppId = 1,
                            Status = 1,
                            Updated = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9503)
                        },
                        new
                        {
                            Id = 18,
                            Created = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9505),
                            Name = "Alexander",
                            RefAppId = 1,
                            Status = 1,
                            Updated = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9505)
                        },
                        new
                        {
                            Id = 19,
                            Created = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9507),
                            Name = "Amelia",
                            RefAppId = 1,
                            Status = 1,
                            Updated = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9507)
                        },
                        new
                        {
                            Id = 20,
                            Created = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9508),
                            Name = "Daniel",
                            RefAppId = 1,
                            Status = 1,
                            Updated = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9508)
                        },
                        new
                        {
                            Id = 21,
                            Created = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9509),
                            Name = "Harper",
                            RefAppId = 1,
                            Status = 1,
                            Updated = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9509)
                        },
                        new
                        {
                            Id = 22,
                            Created = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9510),
                            Name = "Matthew",
                            RefAppId = 1,
                            Status = 1,
                            Updated = new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9511)
                        });
                });

            modelBuilder.Entity("WebAppEBOS.Entity.Entites.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("WebAppEBOS.Entity.Entites.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims", (string)null);
                });

            modelBuilder.Entity("WebAppEBOS.Entity.Entites.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("WebAppEBOS.Entity.Entites.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserClaims", (string)null);
                });

            modelBuilder.Entity("WebAppEBOS.Entity.Entites.UserLogin", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId");

                    b.ToTable("UserLogins", (string)null);
                });

            modelBuilder.Entity("WebAppEBOS.Entity.Entites.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("UserRoles", (string)null);
                });

            modelBuilder.Entity("WebAppEBOS.Entity.Entites.UserToken", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId", "LoginProvider", "Value");

                    b.ToTable("UserTokens", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}