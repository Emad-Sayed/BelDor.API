using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class phonetovisitor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SSN",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "433220f2-40e2-418f-a6ae-2b18fb91b14d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "11c5107e-f2d0-476a-a50b-c6fe407a5bc8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "18a52efa-8c9c-4b2f-99c2-bc7c8fcfe890");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c577cd2d-278c-491c-8ea8-9a269445b268", "AQAAAAEAACcQAAAAEF2tCFJaIqp+hmUwfs4l3tdm78eyoD15QkG7xjf0vRp6+N3TPmrvOsc4NcAaG62ooA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3b942ec0-da10-4ef1-aec0-6670287574b3", "AQAAAAEAACcQAAAAENGweBy//9nUsve3JLH4aooX/6oQdVqGYhfO8n71CXztvGQ/+xKScorOHzD+NrsnIA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9b726991-7328-45bb-8ca1-ef9a43848dee", "AQAAAAEAACcQAAAAEEbyoSRWe7mfZl4O1ooIDzausUFsas6hqoO51JXeFP6duanhC0x4qNTtSC4vyW5FfA==" });

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 19, 47, 46, 564, DateTimeKind.Local).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 19, 47, 46, 564, DateTimeKind.Local).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 19, 47, 46, 564, DateTimeKind.Local).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 19, 47, 46, 564, DateTimeKind.Local).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 19, 47, 46, 564, DateTimeKind.Local).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 19, 47, 46, 562, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 19, 47, 46, 563, DateTimeKind.Local).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 19, 47, 46, 564, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 19, 47, 46, 563, DateTimeKind.Local).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 19, 47, 46, 564, DateTimeKind.Local).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 19, 47, 46, 564, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 19, 47, 46, 564, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 19, 47, 46, 564, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 19, 47, 46, 564, DateTimeKind.Local).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 19, 47, 46, 564, DateTimeKind.Local).AddTicks(8116));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "SSN",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "91797b6f-90e1-458e-8088-fffc90c7c2b3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "273f6666-17db-4d66-9035-e633a13e1e06");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "7bdef33b-ef04-4d05-8199-10a6d3b541c9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "99dcd362-d19d-41a5-80ca-0da7543952d2", "AQAAAAEAACcQAAAAEIX5Bqruv5yrMfgaeU2q5K1laJr9XUb2FAOtQ5EjzMbDxt6HAIKmu7/yeYhY/b78JA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "49b36b02-bbd6-489a-858b-f660c456db33", "AQAAAAEAACcQAAAAELnpUeWXPS98EUdNY4NdTnze78IrtQzan8S8D22IU12rDg+7fMX9xI3qPQM5F+6//Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eed67a5a-2d23-4450-9723-581937573f07", "AQAAAAEAACcQAAAAELhlXRIuNaJ1BPCKBkyEUeQFtZYRtCGCpNnTixtTdrDSFF/wTZeB36f7tr/FYDwggA==" });

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 11, 13, 51, 20, 992, DateTimeKind.Local).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 11, 13, 51, 20, 992, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 11, 13, 51, 20, 992, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 11, 13, 51, 20, 992, DateTimeKind.Local).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 11, 13, 51, 20, 992, DateTimeKind.Local).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 11, 13, 51, 20, 990, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 11, 13, 51, 20, 992, DateTimeKind.Local).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 11, 13, 51, 20, 993, DateTimeKind.Local).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 11, 13, 51, 20, 992, DateTimeKind.Local).AddTicks(2618));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 11, 13, 51, 20, 992, DateTimeKind.Local).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 11, 13, 51, 20, 992, DateTimeKind.Local).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 11, 13, 51, 20, 992, DateTimeKind.Local).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 11, 13, 51, 20, 993, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 11, 13, 51, 20, 993, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 11, 13, 51, 20, 993, DateTimeKind.Local).AddTicks(1293));
        }
    }
}
