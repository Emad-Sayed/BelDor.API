using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class activequeuetoticket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ActiveQueueId",
                table: "Tickets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "1d0bcd9c-515d-426e-866a-090f1ce6c47f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "e590b795-8362-48ce-bf4d-5beb14b2156e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "fbde6db0-b1a2-402b-9bb7-ecac095c406c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "4481e064-48f0-447d-8b83-cf211d659519");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "73e90125-a493-45f5-bfb7-0d9c180f37dd", "AQAAAAEAACcQAAAAEPaIx87/0kjIn3eBg1PZM+247wGo+hRIxNU0ty6LrFEwPt9BSiHatOieSbqT+vJRaQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8d779ce4-6a7e-4690-9bb0-193a7664faf8", "AQAAAAEAACcQAAAAEFoTj4mfUiuBZzDU5UktJEUg8nyLrUyPCtwUIxJP2ONPid77vvgInsUpGKyh0lFzHg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "baddf9bd-7795-4fdc-89cd-8a1e55722771", "AQAAAAEAACcQAAAAEK6ij2+bIYi3av8S92GXgGIqNSFXe7qvWJ2SIpBt9IbSlTgPhx0705oSmxRdqPfsMQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "24b9a061-bdc6-4710-8b5e-d4e904ea42b9", "AQAAAAEAACcQAAAAECAJkHLk1HeGw901y1mjSPpP/8YnbP++vJjrH1IVw5d1ptbJBqCd6VcO/VGCFn3JSA==" });

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 12, 28, 2, 49, 32, 496, DateTimeKind.Local).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 12, 28, 2, 49, 32, 496, DateTimeKind.Local).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 12, 28, 2, 49, 32, 496, DateTimeKind.Local).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 12, 28, 2, 49, 32, 496, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 12, 28, 2, 49, 32, 496, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 12, 28, 2, 49, 32, 491, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 12, 28, 2, 49, 32, 496, DateTimeKind.Local).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 12, 28, 2, 49, 32, 497, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 12, 28, 2, 49, 32, 496, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 12, 28, 2, 49, 32, 496, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 12, 28, 2, 49, 32, 496, DateTimeKind.Local).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 12, 28, 2, 49, 32, 496, DateTimeKind.Local).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchId", "CreatedAt" },
                values: new object[] { 2, new DateTime(2020, 12, 28, 2, 49, 32, 497, DateTimeKind.Local).AddTicks(1737) });

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 12, 28, 2, 49, 32, 497, DateTimeKind.Local).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 12, 28, 2, 49, 32, 497, DateTimeKind.Local).AddTicks(5598));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 12, 28, 2, 49, 32, 497, DateTimeKind.Local).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 12, 28, 2, 49, 32, 497, DateTimeKind.Local).AddTicks(5654));

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ActiveQueueId",
                table: "Tickets",
                column: "ActiveQueueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_ActiveQueues_ActiveQueueId",
                table: "Tickets",
                column: "ActiveQueueId",
                principalTable: "ActiveQueues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_ActiveQueues_ActiveQueueId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_ActiveQueueId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "ActiveQueueId",
                table: "Tickets");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "f6cb4152-6f9f-4538-aed5-eaab1a789b84");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "d329be2e-5975-4075-9506-224014a53672");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "082cba3a-cbd9-4e8f-91be-6bff7a53e879");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "0ba38bc8-9c1e-4ad2-ab66-5dc78ab2f7bd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "88add370-41f4-48d8-b936-c85aba275b8b", "AQAAAAEAACcQAAAAEHw6Zbrh39jhupsRnVbxiEvyqFfPtvvyQEuLKi+UOFbanKEcp40Pz8oDhYDqtELvgw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6c2c61f6-8dac-4713-8203-232157d23698", "AQAAAAEAACcQAAAAEFzVMznFyxqFOXvYb7qoFciYtdMf/QQS/nZO+NIvZGper10r2UaJAusQhattGJDzHA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b3b70929-28d7-4e83-aacf-6160d59d7319", "AQAAAAEAACcQAAAAEBhInfGXuxdovh36rROo/OdJyfTXmI0UbINnEZEyCSxAFiiLhS0EWvCvyMQyP2ZLHg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4dc14310-a91f-469e-8a2f-224ba053be40", "AQAAAAEAACcQAAAAEBc1rP939tAEgBFFTbZuj92fU8kudMsuAndFpQU9Kw/+VwgfhheDICfpb1wnOy27pg==" });

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 12, 28, 2, 21, 11, 39, DateTimeKind.Local).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 12, 28, 2, 21, 11, 39, DateTimeKind.Local).AddTicks(5273));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 12, 28, 2, 21, 11, 39, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 12, 28, 2, 21, 11, 39, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "BranchDepartement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 12, 28, 2, 21, 11, 39, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 12, 28, 2, 21, 11, 32, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 12, 28, 2, 21, 11, 38, DateTimeKind.Local).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 12, 28, 2, 21, 11, 40, DateTimeKind.Local).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 12, 28, 2, 21, 11, 38, DateTimeKind.Local).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 12, 28, 2, 21, 11, 39, DateTimeKind.Local).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "Departements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 12, 28, 2, 21, 11, 39, DateTimeKind.Local).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 12, 28, 2, 21, 11, 39, DateTimeKind.Local).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BranchId", "CreatedAt" },
                values: new object[] { 3, new DateTime(2020, 12, 28, 2, 21, 11, 40, DateTimeKind.Local).AddTicks(196) });

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 12, 28, 2, 21, 11, 40, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 12, 28, 2, 21, 11, 40, DateTimeKind.Local).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 12, 28, 2, 21, 11, 40, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 12, 28, 2, 21, 11, 40, DateTimeKind.Local).AddTicks(6076));
        }
    }
}
