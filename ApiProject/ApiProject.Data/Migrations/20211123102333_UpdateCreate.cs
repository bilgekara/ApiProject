using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiProject.Data.Migrations
{
    public partial class UpdateCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PathName",
                table: "Photos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 23, 13, 23, 32, 190, DateTimeKind.Local).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 23, 13, 23, 32, 190, DateTimeKind.Local).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 23, 13, 23, 32, 190, DateTimeKind.Local).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "PathName" },
                values: new object[] { new DateTime(2021, 11, 23, 13, 23, 32, 187, DateTimeKind.Local).AddTicks(1233), new DateTime(2021, 11, 23, 13, 23, 32, 186, DateTimeKind.Local).AddTicks(9231), null });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "PathName" },
                values: new object[] { new DateTime(2021, 11, 23, 13, 23, 32, 187, DateTimeKind.Local).AddTicks(3326), new DateTime(2021, 11, 23, 13, 23, 32, 187, DateTimeKind.Local).AddTicks(3324), null });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "PathName" },
                values: new object[] { new DateTime(2021, 11, 23, 13, 23, 32, 187, DateTimeKind.Local).AddTicks(3331), new DateTime(2021, 11, 23, 13, 23, 32, 187, DateTimeKind.Local).AddTicks(3330), null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 23, 13, 23, 32, 192, DateTimeKind.Local).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 23, 13, 23, 32, 208, DateTimeKind.Local).AddTicks(330));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PathName",
                table: "Photos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 22, 10, 22, 32, 954, DateTimeKind.Local).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 22, 10, 22, 32, 954, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 22, 10, 22, 32, 954, DateTimeKind.Local).AddTicks(2676));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "PathName" },
                values: new object[] { new DateTime(2021, 11, 22, 10, 22, 32, 951, DateTimeKind.Local).AddTicks(952), new DateTime(2021, 11, 22, 10, 22, 32, 950, DateTimeKind.Local).AddTicks(9964), 0 });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "PathName" },
                values: new object[] { new DateTime(2021, 11, 22, 10, 22, 32, 951, DateTimeKind.Local).AddTicks(2430), new DateTime(2021, 11, 22, 10, 22, 32, 951, DateTimeKind.Local).AddTicks(2428), 0 });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "PathName" },
                values: new object[] { new DateTime(2021, 11, 22, 10, 22, 32, 951, DateTimeKind.Local).AddTicks(2436), new DateTime(2021, 11, 22, 10, 22, 32, 951, DateTimeKind.Local).AddTicks(2435), 0 });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 22, 10, 22, 32, 956, DateTimeKind.Local).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 22, 10, 22, 32, 971, DateTimeKind.Local).AddTicks(7179));
        }
    }
}
