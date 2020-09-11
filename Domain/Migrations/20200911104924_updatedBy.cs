using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class updatedBy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UpdatedById",
                table: "TicketStatus",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedById",
                table: "Tickets",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedById",
                table: "TicketClosed",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedById",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedById",
                table: "Departements",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedById",
                table: "Configurations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedById",
                table: "Branches",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedById",
                table: "BranchDepartement",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_TicketStatus_UpdatedById",
                table: "TicketStatus",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_UpdatedById",
                table: "Tickets",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TicketClosed_UpdatedById",
                table: "TicketClosed",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UpdatedById",
                table: "Employees",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Departements_UpdatedById",
                table: "Departements",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Configurations_UpdatedById",
                table: "Configurations",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Branches_UpdatedById",
                table: "Branches",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_BranchDepartement_UpdatedById",
                table: "BranchDepartement",
                column: "UpdatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_BranchDepartement_AspNetUsers_UpdatedById",
                table: "BranchDepartement",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Branches_AspNetUsers_UpdatedById",
                table: "Branches",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Configurations_AspNetUsers_UpdatedById",
                table: "Configurations",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Departements_AspNetUsers_UpdatedById",
                table: "Departements",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_AspNetUsers_UpdatedById",
                table: "Employees",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TicketClosed_AspNetUsers_UpdatedById",
                table: "TicketClosed",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_AspNetUsers_UpdatedById",
                table: "Tickets",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TicketStatus_AspNetUsers_UpdatedById",
                table: "TicketStatus",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BranchDepartement_AspNetUsers_UpdatedById",
                table: "BranchDepartement");

            migrationBuilder.DropForeignKey(
                name: "FK_Branches_AspNetUsers_UpdatedById",
                table: "Branches");

            migrationBuilder.DropForeignKey(
                name: "FK_Configurations_AspNetUsers_UpdatedById",
                table: "Configurations");

            migrationBuilder.DropForeignKey(
                name: "FK_Departements_AspNetUsers_UpdatedById",
                table: "Departements");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_AspNetUsers_UpdatedById",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketClosed_AspNetUsers_UpdatedById",
                table: "TicketClosed");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_AspNetUsers_UpdatedById",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketStatus_AspNetUsers_UpdatedById",
                table: "TicketStatus");

            migrationBuilder.DropIndex(
                name: "IX_TicketStatus_UpdatedById",
                table: "TicketStatus");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_UpdatedById",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_TicketClosed_UpdatedById",
                table: "TicketClosed");

            migrationBuilder.DropIndex(
                name: "IX_Employees_UpdatedById",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Departements_UpdatedById",
                table: "Departements");

            migrationBuilder.DropIndex(
                name: "IX_Configurations_UpdatedById",
                table: "Configurations");

            migrationBuilder.DropIndex(
                name: "IX_Branches_UpdatedById",
                table: "Branches");

            migrationBuilder.DropIndex(
                name: "IX_BranchDepartement_UpdatedById",
                table: "BranchDepartement");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "TicketStatus");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "TicketClosed");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Departements");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Configurations");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "BranchDepartement");

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

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 15, 24, 14, 370, DateTimeKind.Local).AddTicks(2653));

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
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 15, 24, 14, 370, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 15, 24, 14, 370, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "TicketStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 15, 24, 14, 370, DateTimeKind.Local).AddTicks(1569));
        }
    }
}
