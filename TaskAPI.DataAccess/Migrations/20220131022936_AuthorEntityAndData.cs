using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskAPI.DataAccess.Migrations
{
    public partial class AuthorEntityAndData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Todos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "Supun Vindula" },
                    { 2, "Kushini Kalupahana" },
                    { 3, "Maneesha Randeniya" },
                    { 4, "Basuru Wickramarachchi" }
                });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Created", "Due" },
                values: new object[] { 1, new DateTime(2022, 1, 31, 7, 59, 36, 578, DateTimeKind.Local).AddTicks(371), new DateTime(2022, 2, 5, 7, 59, 36, 581, DateTimeKind.Local).AddTicks(7799) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Created", "Due", "Status" },
                values: new object[] { 2, new DateTime(2022, 1, 31, 7, 59, 36, 581, DateTimeKind.Local).AddTicks(8740), new DateTime(2022, 2, 3, 7, 59, 36, 581, DateTimeKind.Local).AddTicks(8743), 2 });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Created", "Due" },
                values: new object[] { 1, new DateTime(2022, 1, 31, 7, 59, 36, 581, DateTimeKind.Local).AddTicks(8760), new DateTime(2022, 2, 4, 7, 59, 36, 581, DateTimeKind.Local).AddTicks(8761) });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Todos");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 1, 30, 16, 11, 37, 915, DateTimeKind.Local).AddTicks(5236), new DateTime(2022, 2, 4, 16, 11, 37, 918, DateTimeKind.Local).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Due", "Status" },
                values: new object[] { new DateTime(2022, 1, 30, 16, 11, 37, 919, DateTimeKind.Local).AddTicks(9188), new DateTime(2022, 2, 2, 16, 11, 37, 919, DateTimeKind.Local).AddTicks(9198), 0 });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 1, 30, 16, 11, 37, 919, DateTimeKind.Local).AddTicks(9314), new DateTime(2022, 2, 3, 16, 11, 37, 919, DateTimeKind.Local).AddTicks(9315) });
        }
    }
}
