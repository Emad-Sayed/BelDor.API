using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class branchConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BranchConfigurations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<int>(nullable: true),
                    UpdatedById = table.Column<int>(nullable: true),
                    BranchId = table.Column<int>(nullable: false),
                    AddedTime = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchConfigurations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BranchConfigurations_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchConfigurations_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BranchConfigurations_AspNetUsers_UpdatedById",
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


            migrationBuilder.CreateIndex(
                name: "IX_BranchConfigurations_BranchId",
                table: "BranchConfigurations",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchConfigurations_CreatedById",
                table: "BranchConfigurations",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_BranchConfigurations_UpdatedById",
                table: "BranchConfigurations",
                column: "UpdatedById");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BranchConfigurations");

            migrationBuilder.DeleteData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 4);

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
    }
}
