using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "e09c6da3-7781-43b8-b2ed-660bce2ace1e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "39e49188-8024-41a0-b177-47aca7e89d69");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "c1b06cfe-5569-47dd-b20b-1a11a13afd5a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 4, "536cbd04-23df-46e0-9902-fb948edb4491", "MANAGER", "MANAGER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1d3c867a-6f46-4c00-b4f0-656b70c914f0", "AQAAAAEAACcQAAAAEPA5csxDQKazjTzrGoWk4SPjdzTPluZhQyubkR5L9OigWkcvJGdaLQpEQ7IRKRiRmg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9d07a745-0bd4-477b-afef-13d9d4af7591", "AQAAAAEAACcQAAAAEB5Nj0DDryF337IPd7p4pYOs8XPy0p6KOjjAt+NXNe1phK1jm/RskUy6CX4UuP1lsg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "401d7929-f7bd-4201-b2f6-40d2c22b08a3", "AQAAAAEAACcQAAAAEP0UrJe/Ns/YDLCvquGW0t4dy+R2WD5QItfAvCzuO+DBzFFKpYAYZgQe2XeSmVWHww==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { 4, 0, "7d6168ad-310c-4378-9a4d-a9201263770a", "manager@manager.com", true, false, null, "manager@manager.com", null, "AQAAAAEAACcQAAAAEBBmoOdSDuIQaTE9mDHB9VYa6FOiOf737caZwTgAVHXxzcGhRpyCLFNR4FeDfhEITg==", null, null, false, "", false, "MANAGER" });

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 22, 28, 37, 613, DateTimeKind.Local).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 22, 28, 37, 613, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 22, 28, 37, 613, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 22, 28, 37, 613, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 22, 28, 37, 613, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 22, 28, 37, 611, DateTimeKind.Local).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 22, 28, 37, 612, DateTimeKind.Local).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 22, 28, 37, 614, DateTimeKind.Local).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 22, 28, 37, 613, DateTimeKind.Local).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 22, 28, 37, 613, DateTimeKind.Local).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 22, 28, 37, 613, DateTimeKind.Local).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 22, 28, 37, 613, DateTimeKind.Local).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 22, 28, 37, 614, DateTimeKind.Local).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 22, 28, 37, 614, DateTimeKind.Local).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 22, 28, 37, 614, DateTimeKind.Local).AddTicks(1958));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 22, 28, 37, 614, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { 4, 4 });

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "BranchId", "CreatedAt", "CreatedById", "UpdatedById", "UserId" },
                values: new object[] { 2, 3, new DateTime(2020, 10, 1, 22, 28, 37, 613, DateTimeKind.Local).AddTicks(8529), null, null, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "2ae99ad0-301e-4c5d-a489-2c17783b12d8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "ac317427-6e35-48f9-9fd4-6cd34e82e5bb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "558861fb-f30e-4ae4-8e7f-4832624cb31b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b4fda100-3963-47af-99c4-fe92efd0fcaa", "AQAAAAEAACcQAAAAEPaAZ0QCHLiXuZ/Uz3wXK4yRFjhwhX9WSFoXJZpVY2CiANuJMsHb4mKA09MdvgcMSw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "02f082a6-2eb6-4897-ad97-dc74d132aba2", "AQAAAAEAACcQAAAAEJ1aye88E3tjcoIHfRW3Ggb8xNd3Zl7skq8lf9LvOZjWAi7hhR5wlhM4lmAr0UCvmQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2bdc0146-a19d-4fcc-99eb-d9426909388f", "AQAAAAEAACcQAAAAEJ6lkd9ugv6SXYoIvU6CFCzsaa9mfRHB5NzeELZ/nCv/exJqwr+ECr4sNBXkQFXgMA==" });

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 21, 38, 56, 640, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 21, 38, 56, 640, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 21, 38, 56, 640, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 21, 38, 56, 640, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 21, 38, 56, 640, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 21, 38, 56, 638, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 21, 38, 56, 640, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 21, 38, 56, 641, DateTimeKind.Local).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 21, 38, 56, 640, DateTimeKind.Local).AddTicks(5237));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 21, 38, 56, 640, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 21, 38, 56, 640, DateTimeKind.Local).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 21, 38, 56, 640, DateTimeKind.Local).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 21, 38, 56, 641, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 21, 38, 56, 641, DateTimeKind.Local).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 21, 38, 56, 641, DateTimeKind.Local).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 21, 38, 56, 641, DateTimeKind.Local).AddTicks(3017));
        }
    }
}
