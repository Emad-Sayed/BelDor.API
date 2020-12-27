using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    SSN = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<int>(nullable: true),
                    NameAR = table.Column<string>(nullable: true),
                    NameEN = table.Column<string>(nullable: true),
                    AddressAR = table.Column<string>(nullable: true),
                    AddressEN = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Branches_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Configurations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<int>(nullable: true),
                    StartReservationTime = table.Column<TimeSpan>(nullable: false),
                    EndReservationTime = table.Column<TimeSpan>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configurations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Configurations_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Departements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<int>(nullable: true),
                    NameAR = table.Column<string>(nullable: true),
                    NameEN = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departements_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TicketStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<int>(nullable: true),
                    NameAR = table.Column<string>(nullable: true),
                    NameEN = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TicketStatus_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BranchDepartement",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<int>(nullable: true),
                    BranchId = table.Column<int>(nullable: false),
                    DepartementId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchDepartement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BranchDepartement_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchDepartement_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BranchDepartement_Departements_DepartementId",
                        column: x => x.DepartementId,
                        principalTable: "Departements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    BranchDepartementId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_BranchDepartement_BranchDepartementId",
                        column: x => x.BranchDepartementId,
                        principalTable: "BranchDepartement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<int>(nullable: true),
                    TicketNumber = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    BranchDepartementId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_BranchDepartement_BranchDepartementId",
                        column: x => x.BranchDepartementId,
                        principalTable: "BranchDepartement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_TicketStatus_StatusId",
                        column: x => x.StatusId,
                        principalTable: "TicketStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TicketClosed",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<int>(nullable: true),
                    TicketId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketClosed", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TicketClosed_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TicketClosed_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "bc64b9a7-38ad-41d9-a469-dbbc399bf184", "ADMIN", "ADMIN" },
                    { 2, "b145f100-75e3-4770-aba1-fc4ef539c32a", "EMPLOYEE", "EMPLOYEE" },
                    { 3, "de97d780-2eb1-4c54-a8b9-0485b0746511", "VISITOR", "VISITOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SSN", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "3dd34086-23c8-422f-8bdb-10e1bff9b64d", "admin@admin.com", true, false, null, "admin@admin.com", null, "AQAAAAEAACcQAAAAENuwoJTBXgwCu+97goMc1veN9gMUiloSk53w/fMsMngJHzKSxOZ6X13jfuvRaMBKhA==", null, false, 0, "", false, "ADMIN" },
                    { 2, 0, "e4b279e4-0d5a-4fdb-a46f-d174e442584a", "employee@employee.com", true, false, null, "employee@employee.com", null, "AQAAAAEAACcQAAAAEMaTgzDeL6iX22VigQq+oRzglCV7BwCBHag19NSs3w6xeZ3VfmFyKXjbpkxnVGr6Cg==", null, false, 0, "", false, "EMPLOYEE" },
                    { 3, 0, "13978c3c-52aa-4e1f-b1ef-83014b98654f", "visitor@visitor.com", true, false, null, "visitor@visitor.com", null, "AQAAAAEAACcQAAAAEB1iUgdlwqjtHQsOBYwbJBe9evnNv4kSGHWVMCqOd3y6iiZp+r26bx7S+/Iaonlg9A==", null, false, 0, "", false, "VISITOR" }
                });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "AddressAR", "AddressEN", "CreatedAt", "CreatedById", "NameAR", "NameEN", "Phone" },
                values: new object[,]
                {
                    { 1, "القاهرة", "Cairo", new DateTime(2020, 9, 7, 1, 38, 48, 296, DateTimeKind.Local).AddTicks(6534), null, "القاهرة", "Cairo", "010" },
                    { 2, "الاسكندرية", "Alexandria", new DateTime(2020, 9, 7, 1, 38, 48, 298, DateTimeKind.Local).AddTicks(3876), null, "الاسكندرية", "Alexandria", "011" }
                });

            migrationBuilder.InsertData(
                table: "Departements",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "NameAR", "NameEN" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 9, 7, 1, 38, 48, 298, DateTimeKind.Local).AddTicks(6384), null, "نظم المعلومات", "IT" },
                    { 2, new DateTime(2020, 9, 7, 1, 38, 48, 298, DateTimeKind.Local).AddTicks(8237), null, "الدعم الفني", "Customer Service" },
                    { 3, new DateTime(2020, 9, 7, 1, 38, 48, 298, DateTimeKind.Local).AddTicks(8409), null, "الشكاوي", "Complains" }
                });

            migrationBuilder.InsertData(
                table: "TicketStatus",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "NameAR", "NameEN" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 9, 7, 1, 38, 48, 299, DateTimeKind.Local).AddTicks(5997), null, "انتظار", "WAITING" },
                    { 2, new DateTime(2020, 9, 7, 1, 38, 48, 299, DateTimeKind.Local).AddTicks(7646), null, "تخدم", "SERVING" },
                    { 3, new DateTime(2020, 9, 7, 1, 38, 48, 299, DateTimeKind.Local).AddTicks(7678), null, "مغلقة", "Closed" },
                    { 4, new DateTime(2020, 9, 7, 1, 38, 48, 299, DateTimeKind.Local).AddTicks(7678), null, "تخلف", "Missed" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "BranchDepartement",
                columns: new[] { "Id", "BranchId", "CreatedAt", "CreatedById", "DepartementId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 9, 7, 1, 38, 48, 298, DateTimeKind.Local).AddTicks(9692), null, 1 },
                    { 2, 1, new DateTime(2020, 9, 7, 1, 38, 48, 299, DateTimeKind.Local).AddTicks(1779), null, 2 },
                    { 4, 2, new DateTime(2020, 9, 7, 1, 38, 48, 299, DateTimeKind.Local).AddTicks(1815), null, 2 },
                    { 3, 1, new DateTime(2020, 9, 7, 1, 38, 48, 299, DateTimeKind.Local).AddTicks(1812), null, 3 },
                    { 5, 2, new DateTime(2020, 9, 7, 1, 38, 48, 299, DateTimeKind.Local).AddTicks(1817), null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "BranchDepartementId", "CreatedAt", "CreatedById", "UserId" },
                values: new object[] { 1, 1, new DateTime(2020, 9, 7, 1, 38, 48, 299, DateTimeKind.Local).AddTicks(3067), null, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BranchDepartement_BranchId",
                table: "BranchDepartement",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchDepartement_CreatedById",
                table: "BranchDepartement",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_BranchDepartement_DepartementId",
                table: "BranchDepartement",
                column: "DepartementId");

            migrationBuilder.CreateIndex(
                name: "IX_Branches_CreatedById",
                table: "Branches",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Configurations_CreatedById",
                table: "Configurations",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Departements_CreatedById",
                table: "Departements",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_BranchDepartementId",
                table: "Employees",
                column: "BranchDepartementId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CreatedById",
                table: "Employees",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UserId",
                table: "Employees",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketClosed_CreatedById",
                table: "TicketClosed",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TicketClosed_TicketId",
                table: "TicketClosed",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_BranchDepartementId",
                table: "Tickets",
                column: "BranchDepartementId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_CreatedById",
                table: "Tickets",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_StatusId",
                table: "Tickets",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketStatus_CreatedById",
                table: "TicketStatus",
                column: "CreatedById");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Configurations");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "TicketClosed");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "BranchDepartement");

            migrationBuilder.DropTable(
                name: "TicketStatus");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Departements");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
