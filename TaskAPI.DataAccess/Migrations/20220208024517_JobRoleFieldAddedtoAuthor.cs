using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskAPI.DataAccess.Migrations
{
    public partial class JobRoleFieldAddedtoAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobRole",
                table: "Authors",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "JobRole",
                value: "Systems Engineer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "JobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "JobRole",
                value: "QA");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 2, 8, 8, 15, 16, 790, DateTimeKind.Local).AddTicks(1038), new DateTime(2022, 2, 13, 8, 15, 16, 793, DateTimeKind.Local).AddTicks(1841) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 2, 8, 8, 15, 16, 793, DateTimeKind.Local).AddTicks(2629), new DateTime(2022, 2, 11, 8, 15, 16, 793, DateTimeKind.Local).AddTicks(2632) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 2, 8, 8, 15, 16, 793, DateTimeKind.Local).AddTicks(2648), new DateTime(2022, 2, 12, 8, 15, 16, 793, DateTimeKind.Local).AddTicks(2649) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobRole",
                table: "Authors");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 2, 2, 8, 19, 15, 355, DateTimeKind.Local).AddTicks(8105), new DateTime(2022, 2, 7, 8, 19, 15, 358, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 2, 2, 8, 19, 15, 358, DateTimeKind.Local).AddTicks(5732), new DateTime(2022, 2, 5, 8, 19, 15, 358, DateTimeKind.Local).AddTicks(5735) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 2, 2, 8, 19, 15, 358, DateTimeKind.Local).AddTicks(5751), new DateTime(2022, 2, 6, 8, 19, 15, 358, DateTimeKind.Local).AddTicks(5753) });
        }
    }
}
