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
    [Migration("20201001185444_update timespan branch")]
    partial class updatetimespanbranch
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

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

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
                            ConcurrencyStamp = "ab728b2f-7aea-4ae9-bd50-e44892f886dc",
                            Email = "admin@admin.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "admin@admin.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEDVkvOpC2I5sfQgK1ZEdS+nssMlyYg11ZVABTdmp6PqtH9P07XAXAavLnk0umTY03g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ee3f2864-adba-4de8-b4f2-1a079833940f",
                            Email = "employee@employee.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "employee@employee.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEM/U/VMWcOjz1G5LaHRNMjKaWjMt3tD5aQ1BzkbT+5zlm3Xo5guV5QabQ6bNujG20w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "EMPLOYEE"
                        },
                        new
                        {
                            Id = 3,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cb883cc3-bcb3-4fd6-98ba-a4c0fda28186",
                            Email = "visitor@visitor.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "visitor@visitor.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEN/+UCIZBuKXN+rIlEhlfwqCTxGIa5yMTAcECKTrR3YIp16OEi3rkgRPaiLYn1r+Tg==",
                            PhoneNumberConfirmed = false,
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
                            CreatedAt = new DateTime(2020, 10, 1, 20, 54, 42, 690, DateTimeKind.Local).AddTicks(4736),
                            UserId = 2
                        });
                });

            modelBuilder.Entity("Core.Domain.Entity.BranchConfiguration", b =>
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

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.Property<int?>("UpdatedById")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("CreatedById");

                    b.HasIndex("UpdatedById");

                    b.ToTable("BranchConfigurations");
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
                            CreatedAt = new DateTime(2020, 10, 1, 20, 54, 42, 691, DateTimeKind.Local).AddTicks(120),
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
                            CreatedAt = new DateTime(2020, 10, 1, 20, 54, 42, 687, DateTimeKind.Local).AddTicks(5522),
                            NameAR = "القاهرة",
                            NameEN = "Cairo",
                            Phone = "010"
                        },
                        new
                        {
                            Id = 2,
                            AddressAR = "الاسكندرية",
                            AddressEN = "Alexandria",
                            CreatedAt = new DateTime(2020, 10, 1, 20, 54, 42, 689, DateTimeKind.Local).AddTicks(7080),
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
                            CreatedAt = new DateTime(2020, 10, 1, 20, 54, 42, 690, DateTimeKind.Local).AddTicks(1944),
                            DepartementId = 1
                        },
                        new
                        {
                            Id = 2,
                            BranchId = 1,
                            CreatedAt = new DateTime(2020, 10, 1, 20, 54, 42, 690, DateTimeKind.Local).AddTicks(3333),
                            DepartementId = 2
                        },
                        new
                        {
                            Id = 3,
                            BranchId = 1,
                            CreatedAt = new DateTime(2020, 10, 1, 20, 54, 42, 690, DateTimeKind.Local).AddTicks(3370),
                            DepartementId = 3
                        },
                        new
                        {
                            Id = 4,
                            BranchId = 2,
                            CreatedAt = new DateTime(2020, 10, 1, 20, 54, 42, 690, DateTimeKind.Local).AddTicks(3374),
                            DepartementId = 2
                        },
                        new
                        {
                            Id = 5,
                            BranchId = 2,
                            CreatedAt = new DateTime(2020, 10, 1, 20, 54, 42, 690, DateTimeKind.Local).AddTicks(3377),
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
                            CreatedAt = new DateTime(2020, 10, 1, 20, 54, 42, 689, DateTimeKind.Local).AddTicks(9142),
                            NameAR = "نظم المعلومات",
                            NameEN = "IT"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2020, 10, 1, 20, 54, 42, 690, DateTimeKind.Local).AddTicks(568),
                            NameAR = "الدعم الفني",
                            NameEN = "Customer Service"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2020, 10, 1, 20, 54, 42, 690, DateTimeKind.Local).AddTicks(624),
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
                            CreatedAt = new DateTime(2020, 10, 1, 20, 54, 42, 690, DateTimeKind.Local).AddTicks(7531),
                            NameAR = "انتظار",
                            NameEN = "Waiting"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2020, 10, 1, 20, 54, 42, 690, DateTimeKind.Local).AddTicks(8940),
                            NameAR = "تخدم",
                            NameEN = "Serving"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2020, 10, 1, 20, 54, 42, 690, DateTimeKind.Local).AddTicks(8977),
                            NameAR = "مغلقة",
                            NameEN = "Closed"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2020, 10, 1, 20, 54, 42, 690, DateTimeKind.Local).AddTicks(8980),
                            NameAR = "تخلفت",
                            NameEN = "Missed"
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
                            ConcurrencyStamp = "8eb384ad-a685-486f-bcdc-a92cfd5d1b3b",
                            Name = "ADMIN",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "2e6b208e-fb70-4935-a09e-409fdd9ebdfd",
                            Name = "EMPLOYEE",
                            NormalizedName = "EMPLOYEE"
                        },
                        new
                        {
                            Id = 3,
                            ConcurrencyStamp = "7e829f34-f75f-4b51-aad2-b3d04d3e4ac7",
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

            modelBuilder.Entity("Core.Domain.Entity.BranchConfiguration", b =>
                {
                    b.HasOne("Core.Domain.Entity.LocationEntites.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Domain.Entity.Access.AppUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("Core.Domain.Entity.Access.AppUser", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedById");
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
