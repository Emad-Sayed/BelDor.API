using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class updatetimespanbranch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddedEndHours",
                table: "BranchConfigurations");

            migrationBuilder.DropColumn(
                name: "AddedStartHours",
                table: "BranchConfigurations");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "EndTime",
                table: "BranchConfigurations",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "StartTime",
                table: "BranchConfigurations",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "8eb384ad-a685-486f-bcdc-a92cfd5d1b3b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "2e6b208e-fb70-4935-a09e-409fdd9ebdfd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "7e829f34-f75f-4b51-aad2-b3d04d3e4ac7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ab728b2f-7aea-4ae9-bd50-e44892f886dc", "AQAAAAEAACcQAAAAEDVkvOpC2I5sfQgK1ZEdS+nssMlyYg11ZVABTdmp6PqtH9P07XAXAavLnk0umTY03g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ee3f2864-adba-4de8-b4f2-1a079833940f", "AQAAAAEAACcQAAAAEM/U/VMWcOjz1G5LaHRNMjKaWjMt3tD5aQ1BzkbT+5zlm3Xo5guV5QabQ6bNujG20w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cb883cc3-bcb3-4fd6-98ba-a4c0fda28186", "AQAAAAEAACcQAAAAEN/+UCIZBuKXN+rIlEhlfwqCTxGIa5yMTAcECKTrR3YIp16OEi3rkgRPaiLYn1r+Tg==" });

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 54, 42, 690, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 54, 42, 690, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 54, 42, 690, DateTimeKind.Local).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 54, 42, 690, DateTimeKind.Local).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 54, 42, 690, DateTimeKind.Local).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 54, 42, 687, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 54, 42, 689, DateTimeKind.Local).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 54, 42, 691, DateTimeKind.Local).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 54, 42, 689, DateTimeKind.Local).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 54, 42, 690, DateTimeKind.Local).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 54, 42, 690, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 54, 42, 690, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 54, 42, 690, DateTimeKind.Local).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 54, 42, 690, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 54, 42, 690, DateTimeKind.Local).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 54, 42, 690, DateTimeKind.Local).AddTicks(8980));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "BranchConfigurations");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "BranchConfigurations");

            migrationBuilder.AddColumn<int>(
                name: "AddedEndHours",
                table: "BranchConfigurations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AddedStartHours",
                table: "BranchConfigurations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "fd99ccf0-afc3-4113-ad43-a376412a492c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "b7384d1a-989e-4ea1-9ef0-ae80f1058503");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "4deaa209-65fd-4e72-9c72-05b2ad74e186");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a4e877ac-14bf-4160-ac4c-a9393d6483de", "AQAAAAEAACcQAAAAEGWUfxi4EThshhdS4JbUk4GJi6+F5cjJxTb4JH0ewGYVofWPZdEgAsPVMA7uN2TC8Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a8f04e5d-a803-454c-885a-2cfc032ad7e0", "AQAAAAEAACcQAAAAEJxannCpxG4BX3/XAcUv3lHtYSszxSYkDiLKvhc1/1hFxTEsTjGOCo0d/vyZuEH0Vw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b5e626f7-9611-4eef-8070-9edbfce473c2", "AQAAAAEAACcQAAAAEGTXjneycVq7ZI+Lh3MLDcSlD6IEAJWgMRFf96OwRIS0aOqgWlo/gA7BJ15S+jlPOw==" });

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 18, 28, 698, DateTimeKind.Local).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 18, 28, 698, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 18, 28, 698, DateTimeKind.Local).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 18, 28, 698, DateTimeKind.Local).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 18, 28, 698, DateTimeKind.Local).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 18, 28, 696, DateTimeKind.Local).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 18, 28, 698, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 18, 28, 699, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 18, 28, 698, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 18, 28, 698, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 18, 28, 698, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 18, 28, 698, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 18, 28, 699, DateTimeKind.Local).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 18, 28, 699, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 18, 28, 699, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 18, 28, 699, DateTimeKind.Local).AddTicks(1527));
        }
    }
}
