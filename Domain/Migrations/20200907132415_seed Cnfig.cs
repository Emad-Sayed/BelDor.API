using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class seedCnfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ee70eca5-b961-4c5b-86a1-dc76c1403ade");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "f1976cc8-0393-4f74-8f33-6fdf73af0fc7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "cf00f591-e4e5-4243-b7d3-a1268fcd37f5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2dfd28f2-cbd0-4b91-b2bc-f3de16a5286d", "AQAAAAEAACcQAAAAEMXx2UpR3WiAHJ24JmRjpMimpWfpxzw1LnLQWGR6Vr9On46D9k00nhDqTa0iVDocKA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cee4a840-a98c-47fb-a930-6fc572cc1db0", "AQAAAAEAACcQAAAAEJE5H6i2iur4pND2ob2eX70HqzooXj5Vf3tIpEO+fo7CGZNDPt48WaxoW61HSu/Tlw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fbf437c2-8af1-473e-aac4-8e8b58a0eeeb", "AQAAAAEAACcQAAAAEAdTY9dVL2/WFpgMOGHqbVDlc3c7m9tvwdXA0m8CV7CcOrZ3g0nxUGxIHbP+DFM5jA==" });

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 15, 24, 14, 369, DateTimeKind.Local).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 15, 24, 14, 369, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 15, 24, 14, 369, DateTimeKind.Local).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 15, 24, 14, 369, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 15, 24, 14, 369, DateTimeKind.Local).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 15, 24, 14, 367, DateTimeKind.Local).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 15, 24, 14, 369, DateTimeKind.Local).AddTicks(825));

            migrationBuilder.InsertData(
                table: "Configurations",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "EndReservationTime", "StartReservationTime" },
                values: new object[] { 1, new DateTime(2020, 9, 7, 15, 24, 14, 370, DateTimeKind.Local).AddTicks(2653), null, new TimeSpan(0, 18, 30, 0, 0), new TimeSpan(0, 7, 30, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 15, 24, 14, 369, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 15, 24, 14, 369, DateTimeKind.Local).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 15, 24, 14, 369, DateTimeKind.Local).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 15, 24, 14, 369, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "NameEN" },
                values: new object[] { new DateTime(2020, 9, 7, 15, 24, 14, 370, DateTimeKind.Local).AddTicks(122), "Waiting" });

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "NameEN" },
                values: new object[] { new DateTime(2020, 9, 7, 15, 24, 14, 370, DateTimeKind.Local).AddTicks(1533), "Serving" });

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 15, 24, 14, 370, DateTimeKind.Local).AddTicks(1569));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "bc64b9a7-38ad-41d9-a469-dbbc399bf184");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "b145f100-75e3-4770-aba1-fc4ef539c32a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "de97d780-2eb1-4c54-a8b9-0485b0746511");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3dd34086-23c8-422f-8bdb-10e1bff9b64d", "AQAAAAEAACcQAAAAENuwoJTBXgwCu+97goMc1veN9gMUiloSk53w/fMsMngJHzKSxOZ6X13jfuvRaMBKhA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e4b279e4-0d5a-4fdb-a46f-d174e442584a", "AQAAAAEAACcQAAAAEMaTgzDeL6iX22VigQq+oRzglCV7BwCBHag19NSs3w6xeZ3VfmFyKXjbpkxnVGr6Cg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "13978c3c-52aa-4e1f-b1ef-83014b98654f", "AQAAAAEAACcQAAAAEB1iUgdlwqjtHQsOBYwbJBe9evnNv4kSGHWVMCqOd3y6iiZp+r26bx7S+/Iaonlg9A==" });

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 1, 38, 48, 298, DateTimeKind.Local).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 1, 38, 48, 299, DateTimeKind.Local).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 1, 38, 48, 299, DateTimeKind.Local).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 1, 38, 48, 299, DateTimeKind.Local).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 1, 38, 48, 299, DateTimeKind.Local).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 1, 38, 48, 296, DateTimeKind.Local).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 1, 38, 48, 298, DateTimeKind.Local).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 1, 38, 48, 298, DateTimeKind.Local).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 1, 38, 48, 298, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 1, 38, 48, 298, DateTimeKind.Local).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 1, 38, 48, 299, DateTimeKind.Local).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "NameEN" },
                values: new object[] { new DateTime(2020, 9, 7, 1, 38, 48, 299, DateTimeKind.Local).AddTicks(5997), "WAITING" });

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "NameEN" },
                values: new object[] { new DateTime(2020, 9, 7, 1, 38, 48, 299, DateTimeKind.Local).AddTicks(7646), "SERVING" });

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 1, 38, 48, 299, DateTimeKind.Local).AddTicks(7678));
        }
    }
}
