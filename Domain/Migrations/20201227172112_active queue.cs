using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class activequeue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActiveQueues",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<int>(nullable: true),
                    UpdatedById = table.Column<int>(nullable: true),
                    StartHour = table.Column<TimeSpan>(nullable: false),
                    EndHour = table.Column<TimeSpan>(nullable: false),
                    isActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActiveQueues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActiveQueues_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ActiveQueues_AspNetUsers_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                column: "CreatedAt",
                value: new DateTime(2020, 12, 28, 2, 21, 11, 40, DateTimeKind.Local).AddTicks(196));

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

            migrationBuilder.CreateIndex(
                name: "IX_ActiveQueues_CreatedById",
                table: "ActiveQueues",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ActiveQueues_UpdatedById",
                table: "ActiveQueues",
                column: "UpdatedById");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActiveQueues");

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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "536cbd04-23df-46e0-9902-fb948edb4491");

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7d6168ad-310c-4378-9a4d-a9201263770a", "AQAAAAEAACcQAAAAEBBmoOdSDuIQaTE9mDHB9VYa6FOiOf737caZwTgAVHXxzcGhRpyCLFNR4FeDfhEITg==" });

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
                table: "Managers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 22, 28, 37, 613, DateTimeKind.Local).AddTicks(8529));

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
        }
    }
}
