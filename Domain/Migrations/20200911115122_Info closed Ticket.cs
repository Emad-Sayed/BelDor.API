using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class InfoclosedTicket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Information",
                table: "TicketClosed",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Information",
                table: "TicketClosed");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "3bd2a0b7-7280-4642-b4bf-facbfb4aee17");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "22954efb-8534-4d75-a0cd-bca4fdf49090");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "26cb45ba-874a-4bb0-9472-ab78f9d30190");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "379c8331-ae4c-436b-8b01-7de17be73dc1", "AQAAAAEAACcQAAAAEFUyOzdjPlwMn5MCF1Q4irsATmK/sfQa4WDVhZqgrA2CcOrZThT7M9mYxz5EJ7qHVA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a04c075f-8e4f-4520-8d75-c522187d7c4f", "AQAAAAEAACcQAAAAEKGrAwN+IwhNqV6cpmOI+gvlaBoRguyzzAn6Lzv+Xo2VDhVHXsQM3RVAtPdzNhUtPg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "64df596e-f00e-4e30-b117-f999c17f75ac", "AQAAAAEAACcQAAAAEIrW59tHeZ07bWIDpC+NPPKjBaviFR0UalSdkt1EfCBBm4zUvvU8xpkfiBQVgSZMJw==" });

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 11, 12, 49, 23, 917, DateTimeKind.Local).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 11, 12, 49, 23, 917, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 11, 12, 49, 23, 917, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 11, 12, 49, 23, 917, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 11, 12, 49, 23, 917, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 11, 12, 49, 23, 915, DateTimeKind.Local).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 11, 12, 49, 23, 917, DateTimeKind.Local).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 11, 12, 49, 23, 918, DateTimeKind.Local).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 11, 12, 49, 23, 917, DateTimeKind.Local).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 11, 12, 49, 23, 917, DateTimeKind.Local).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 11, 12, 49, 23, 917, DateTimeKind.Local).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 11, 12, 49, 23, 917, DateTimeKind.Local).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 11, 12, 49, 23, 918, DateTimeKind.Local).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 11, 12, 49, 23, 918, DateTimeKind.Local).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 11, 12, 49, 23, 918, DateTimeKind.Local).AddTicks(1882));
        }
    }
}
