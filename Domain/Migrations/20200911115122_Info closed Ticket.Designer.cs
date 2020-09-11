﻿// <auto-generated />
using System;
using Domain.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Domain.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200911115122_Info closed Ticket")]
    partial class InfoclosedTicket
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Domain.Entity.Access.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("SSN")
                        .HasColumnType("int");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "99dcd362-d19d-41a5-80ca-0da7543952d2",
                            Email = "admin@admin.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "admin@admin.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEIX5Bqruv5yrMfgaeU2q5K1laJr9XUb2FAOtQ5EjzMbDxt6HAIKmu7/yeYhY/b78JA==",
                            PhoneNumberConfirmed = false,
                            SSN = 0,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "49b36b02-bbd6-489a-858b-f660c456db33",
                            Email = "employee@employee.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "employee@employee.com",
                            PasswordHash = "AQAAAAEAACcQAAAAELnpUeWXPS98EUdNY4NdTnze78IrtQzan8S8D22IU12rDg+7fMX9xI3qPQM5F+6//Q==",
                            PhoneNumberConfirmed = false,
                            SSN = 0,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "EMPLOYEE"
                        },
                        new
                        {
                            Id = 3,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "eed67a5a-2d23-4450-9723-581937573f07",
                            Email = "visitor@visitor.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "visitor@visitor.com",
                            PasswordHash = "AQAAAAEAACcQAAAAELhlXRIuNaJ1BPCKBkyEUeQFtZYRtCGCpNnTixtTdrDSFF/wTZeB36f7tr/FYDwggA==",
                            PhoneNumberConfirmed = false,
                            SSN = 0,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "VISITOR"
                        });
                });

            modelBuilder.Entity("Core.Domain.Entity.Access.AppUserEmployee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BranchDepartementId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int");

                    b.Property<int?>("UpdatedById")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BranchDepartementId");

                    b.HasIndex("CreatedById");

                    b.HasIndex("UpdatedById");

                    b.HasIndex("UserId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BranchDepartementId = 1,
                            CreatedAt = new DateTime(2020, 9, 11, 13, 51, 20, 992, DateTimeKind.Local).AddTicks(7915),
                            UserId = 2
                        });
                });

            modelBuilder.Entity("Core.Domain.Entity.Configuration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("EndReservationTime")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("StartReservationTime")
                        .HasColumnType("time");

                    b.Property<int?>("UpdatedById")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("UpdatedById");

                    b.ToTable("Configurations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2020, 9, 11, 13, 51, 20, 993, DateTimeKind.Local).AddTicks(2249),
                            EndReservationTime = new TimeSpan(0, 18, 30, 0, 0),
                            StartReservationTime = new TimeSpan(0, 7, 30, 0, 0)
                        });
                });

            modelBuilder.Entity("Core.Domain.Entity.LocationEntites.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressAR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressEN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int");

                    b.Property<string>("NameAR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UpdatedById")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("UpdatedById");

                    b.ToTable("Branches");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressAR = "القاهرة",
                            AddressEN = "Cairo",
                            CreatedAt = new DateTime(2020, 9, 11, 13, 51, 20, 990, DateTimeKind.Local).AddTicks(1604),
                            NameAR = "القاهرة",
                            NameEN = "Cairo",
                            Phone = "010"
                        },
                        new
                        {
                            Id = 2,
                            AddressAR = "الاسكندرية",
                            AddressEN = "Alexandria",
                            CreatedAt = new DateTime(2020, 9, 11, 13, 51, 20, 992, DateTimeKind.Local).AddTicks(1116),
                            NameAR = "الاسكندرية",
                            NameEN = "Alexandria",
                            Phone = "011"
                        });
                });

            modelBuilder.Entity("Core.Domain.Entity.LocationEntites.BranchDepartement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int");

                    b.Property<int>("DepartementId")
                        .HasColumnType("int");

                    b.Property<int?>("UpdatedById")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("CreatedById");

                    b.HasIndex("DepartementId");

                    b.HasIndex("UpdatedById");

                    b.ToTable("BranchDepartement");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BranchId = 1,
                            CreatedAt = new DateTime(2020, 9, 11, 13, 51, 20, 992, DateTimeKind.Local).AddTicks(5361),
                            DepartementId = 1
                        },
                        new
                        {
                            Id = 2,
                            BranchId = 1,
                            CreatedAt = new DateTime(2020, 9, 11, 13, 51, 20, 992, DateTimeKind.Local).AddTicks(6793),
                            DepartementId = 2
                        },
                        new
                        {
                            Id = 3,
                            BranchId = 1,
                            CreatedAt = new DateTime(2020, 9, 11, 13, 51, 20, 992, DateTimeKind.Local).AddTicks(6821),
                            DepartementId = 3
                        },
                        new
                        {
                            Id = 4,
                            BranchId = 2,
                            CreatedAt = new DateTime(2020, 9, 11, 13, 51, 20, 992, DateTimeKind.Local).AddTicks(6824),
                            DepartementId = 2
                        },
                        new
                        {
                            Id = 5,
                            BranchId = 2,
                            CreatedAt = new DateTime(2020, 9, 11, 13, 51, 20, 992, DateTimeKind.Local).AddTicks(6826),
                            DepartementId = 3
                        });
                });

            modelBuilder.Entity("Core.Domain.Entity.LocationEntites.Departement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int");

                    b.Property<string>("NameAR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UpdatedById")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("UpdatedById");

                    b.ToTable("Departements");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2020, 9, 11, 13, 51, 20, 992, DateTimeKind.Local).AddTicks(2618),
                            NameAR = "نظم المعلومات",
                            NameEN = "IT"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2020, 9, 11, 13, 51, 20, 992, DateTimeKind.Local).AddTicks(3836),
                            NameAR = "الدعم الفني",
                            NameEN = "Customer Service"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2020, 9, 11, 13, 51, 20, 992, DateTimeKind.Local).AddTicks(3867),
                            NameAR = "الشكاوي",
                            NameEN = "Complains"
                        });
                });

            modelBuilder.Entity("Core.Domain.Entity.TicketEntites.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BranchDepartementId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<int>("TicketNumber")
                        .HasColumnType("int");

                    b.Property<int?>("UpdatedById")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BranchDepartementId");

                    b.HasIndex("CreatedById");

                    b.HasIndex("StatusId");

                    b.HasIndex("UpdatedById");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Core.Domain.Entity.TicketEntites.TicketClosed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int");

                    b.Property<string>("Information")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TicketId")
                        .HasColumnType("int");

                    b.Property<int?>("UpdatedById")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("TicketId");

                    b.HasIndex("UpdatedById");

                    b.ToTable("TicketClosed");
                });

            modelBuilder.Entity("Core.Domain.Entity.TicketEntites.TicketStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int");

                    b.Property<string>("NameAR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UpdatedById")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("UpdatedById");

                    b.ToTable("TicketStatus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2020, 9, 11, 13, 51, 20, 993, DateTimeKind.Local).AddTicks(50),
                            NameAR = "انتظار",
                            NameEN = "Waiting"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2020, 9, 11, 13, 51, 20, 993, DateTimeKind.Local).AddTicks(1263),
                            NameAR = "تخدم",
                            NameEN = "Serving"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2020, 9, 11, 13, 51, 20, 993, DateTimeKind.Local).AddTicks(1293),
                            NameAR = "مغلقة",
                            NameEN = "Closed"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "91797b6f-90e1-458e-8088-fffc90c7c2b3",
                            Name = "ADMIN",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "273f6666-17db-4d66-9035-e633a13e1e06",
                            Name = "EMPLOYEE",
                            NormalizedName = "EMPLOYEE"
                        },
                        new
                        {
                            Id = 3,
                            ConcurrencyStamp = "7bdef33b-ef04-4d05-8199-10a6d3b541c9",
                            Name = "VISITOR",
                            NormalizedName = "VISITOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 2
                        },
                        new
                        {
                            UserId = 3,
                            RoleId = 3
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Core.Domain.Entity.Access.AppUserEmployee", b =>
                {
                    b.HasOne("Core.Domain.Entity.LocationEntites.BranchDepartement", "BranchDepartement")
                        .WithMany()
                        .HasForeignKey("BranchDepartementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Domain.Entity.Access.AppUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("Core.Domain.Entity.Access.AppUser", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedById");

                    b.HasOne("Core.Domain.Entity.Access.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Domain.Entity.Configuration", b =>
                {
                    b.HasOne("Core.Domain.Entity.Access.AppUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("Core.Domain.Entity.Access.AppUser", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedById");
                });

            modelBuilder.Entity("Core.Domain.Entity.LocationEntites.Branch", b =>
                {
                    b.HasOne("Core.Domain.Entity.Access.AppUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("Core.Domain.Entity.Access.AppUser", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedById");
                });

            modelBuilder.Entity("Core.Domain.Entity.LocationEntites.BranchDepartement", b =>
                {
                    b.HasOne("Core.Domain.Entity.LocationEntites.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Domain.Entity.Access.AppUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("Core.Domain.Entity.LocationEntites.Departement", "Departement")
                        .WithMany()
                        .HasForeignKey("DepartementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Domain.Entity.Access.AppUser", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedById");
                });

            modelBuilder.Entity("Core.Domain.Entity.LocationEntites.Departement", b =>
                {
                    b.HasOne("Core.Domain.Entity.Access.AppUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("Core.Domain.Entity.Access.AppUser", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedById");
                });

            modelBuilder.Entity("Core.Domain.Entity.TicketEntites.Ticket", b =>
                {
                    b.HasOne("Core.Domain.Entity.LocationEntites.BranchDepartement", "BranchDepartement")
                        .WithMany()
                        .HasForeignKey("BranchDepartementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Domain.Entity.Access.AppUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("Core.Domain.Entity.TicketEntites.TicketStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Domain.Entity.Access.AppUser", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedById");
                });

            modelBuilder.Entity("Core.Domain.Entity.TicketEntites.TicketClosed", b =>
                {
                    b.HasOne("Core.Domain.Entity.Access.AppUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("Core.Domain.Entity.TicketEntites.Ticket", "Ticket")
                        .WithMany()
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Domain.Entity.Access.AppUser", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedById");
                });

            modelBuilder.Entity("Core.Domain.Entity.TicketEntites.TicketStatus", b =>
                {
                    b.HasOne("Core.Domain.Entity.Access.AppUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("Core.Domain.Entity.Access.AppUser", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedById");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Core.Domain.Entity.Access.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Core.Domain.Entity.Access.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Domain.Entity.Access.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Core.Domain.Entity.Access.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
