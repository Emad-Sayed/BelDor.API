using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class branchConfigurationupdateAddedTimeToAddedHours : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddedTime",
                table: "BranchConfigurations");

            migrationBuilder.AddColumn<int>(
                name: "AddedHours",
                table: "BranchConfigurations",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddedHours",
                table: "BranchConfigurations");

            migrationBuilder.AddColumn<int>(
                name: "AddedTime",
                table: "BranchConfigurations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "fb345155-e58b-4de8-a90b-66384aeb9779");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "f4c7a095-4bff-42b4-ab2c-730f9a68b793");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "d7885ee5-eb56-42b8-bc33-c6a8c39df9fa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2300a2ff-6595-4faa-be0f-dc4f5de6034c", "AQAAAAEAACcQAAAAEM5RJNeDWz4tywhRWPhvNmAMmcGXwQEkzm+huTO8aGm8MbIXKiIM/foVldhEU+IfNw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "483b6b68-1e93-43c5-ad89-37663f1b2a19", "AQAAAAEAACcQAAAAEI6rNC5uk0ZrnCaKvCEUbjo6S2PdKDDtEiGgSNda0c9d5jaXyjCIiaTi5sVzvQPmaw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "66074f2b-fdc2-4f45-b41e-8faa9e9b45da", "AQAAAAEAACcQAAAAEIZi+/bwgLAJFbynADE6t9MuszfP8gXNIJvEsjTeI4H2/Yc1/6oax1McEf8KJngkxw==" });

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 8, 14, 277, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 8, 14, 277, DateTimeKind.Local).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 8, 14, 277, DateTimeKind.Local).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 8, 14, 277, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 8, 14, 277, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 8, 14, 275, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 8, 14, 277, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 8, 14, 278, DateTimeKind.Local).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 8, 14, 277, DateTimeKind.Local).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 8, 14, 277, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 8, 14, 277, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 8, 14, 277, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 8, 14, 278, DateTimeKind.Local).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 8, 14, 278, DateTimeKind.Local).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 8, 14, 278, DateTimeKind.Local).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 20, 8, 14, 278, DateTimeKind.Local).AddTicks(1374));
        }
    }
}
