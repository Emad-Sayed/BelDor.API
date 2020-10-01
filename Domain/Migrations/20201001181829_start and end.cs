using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class startandend : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddedHours",
                table: "BranchConfigurations");

            migrationBuilder.AddColumn<int>(
                name: "AddedEndHours",
                table: "BranchConfigurations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AddedStartHours",
                table: "BranchConfigurations",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddedEndHours",
                table: "BranchConfigurations");

            migrationBuilder.DropColumn(
                name: "AddedStartHours",
                table: "BranchConfigurations");

            migrationBuilder.AddColumn<int>(
                name: "AddedHours",
                table: "BranchConfigurations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "cd52a3be-d2eb-4119-9547-1c4081eb43e3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "a0689568-00ac-4937-915a-df3e7e3e6e2a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "efcb0de6-b9c6-4cd9-9713-58ba3d61ca80");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "39c3b1d4-d4f0-4d90-81b2-b62fbac61585", "AQAAAAEAACcQAAAAEMcxCMMMCouAns8ikp6aiLNwhmFyD5qz07zjHSFWWX9YogZSzxWZKa6vPcGGFp3b+w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3e11522c-f420-41cc-919f-9e572fc0e8a5", "AQAAAAEAACcQAAAAEIbzXsU8BRG6xBjtB+elekRWxO52+X08huESRP29lJHkRQai4+43Fc227MH1MZtm9Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "777e03c4-07e4-4c3d-b703-3e7f7bde3300", "AQAAAAEAACcQAAAAEBZsgTtZpKXmx4DBFw4ZACGO/go1zYq2LJomp4wumZnkey1QslozaUSyDYNcHwzaRQ==" });

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 11, 38, 284, DateTimeKind.Local).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 11, 38, 284, DateTimeKind.Local).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 11, 38, 284, DateTimeKind.Local).AddTicks(7619));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 11, 38, 284, DateTimeKind.Local).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 11, 38, 284, DateTimeKind.Local).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 11, 38, 282, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 11, 38, 284, DateTimeKind.Local).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 11, 38, 285, DateTimeKind.Local).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 11, 38, 284, DateTimeKind.Local).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 11, 38, 284, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 11, 38, 284, DateTimeKind.Local).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 11, 38, 284, DateTimeKind.Local).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 11, 38, 285, DateTimeKind.Local).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 11, 38, 285, DateTimeKind.Local).AddTicks(4756));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 11, 38, 285, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 11, 38, 285, DateTimeKind.Local).AddTicks(4813));
        }
    }
}
