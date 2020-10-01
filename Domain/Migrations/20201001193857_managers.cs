using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class managers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<int>(nullable: true),
                    UpdatedById = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    BranchId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Managers_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Managers_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Managers_AspNetUsers_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Managers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Managers_BranchId",
                table: "Managers",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Managers_CreatedById",
                table: "Managers",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Managers_UpdatedById",
                table: "Managers",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Managers_UserId",
                table: "Managers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Managers");

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
    }
}
