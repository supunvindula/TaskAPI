using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskAPI.DataAccess.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 7, new DateTime(2022, 1, 30, 16, 11, 37, 915, DateTimeKind.Local).AddTicks(5236), "Get some text books for school", new DateTime(2022, 2, 4, 16, 11, 37, 918, DateTimeKind.Local).AddTicks(8992), 0, "Get books for school - DB" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 8, new DateTime(2022, 1, 30, 16, 11, 37, 919, DateTimeKind.Local).AddTicks(9188), "Buy from Daraz", new DateTime(2022, 2, 2, 16, 11, 37, 919, DateTimeKind.Local).AddTicks(9198), 0, "Get a headphone - DB" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 9, new DateTime(2022, 1, 30, 16, 11, 37, 919, DateTimeKind.Local).AddTicks(9314), "To protect from mosquitos", new DateTime(2022, 2, 3, 16, 11, 37, 919, DateTimeKind.Local).AddTicks(9315), 0, "Put a cover to the window - DB" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
