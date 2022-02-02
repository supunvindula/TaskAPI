using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskAPI.DataAccess.Migrations
{
    public partial class Addeddataannotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Todos",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Authors",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressNo",
                table: "Authors",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Authors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Authors",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddressNo", "City", "Street" },
                values: new object[] { "45", "Gampaha", "Daham Mawatha" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddressNo", "City", "Street" },
                values: new object[] { "15", "Kandy", "Nawam Mawatha" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddressNo", "City", "Street" },
                values: new object[] { "789", "Colombo", "Bulls Rd" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddressNo", "City", "Street" },
                values: new object[] { "25", "Palastine", "Radan Rd" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressNo",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Authors");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Todos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 1, 31, 7, 59, 36, 578, DateTimeKind.Local).AddTicks(371), new DateTime(2022, 2, 5, 7, 59, 36, 581, DateTimeKind.Local).AddTicks(7799) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 1, 31, 7, 59, 36, 581, DateTimeKind.Local).AddTicks(8740), new DateTime(2022, 2, 3, 7, 59, 36, 581, DateTimeKind.Local).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 1, 31, 7, 59, 36, 581, DateTimeKind.Local).AddTicks(8760), new DateTime(2022, 2, 4, 7, 59, 36, 581, DateTimeKind.Local).AddTicks(8761) });
        }
    }
}
