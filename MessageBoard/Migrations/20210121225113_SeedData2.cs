using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MessageBoard.Migrations
{
    public partial class SeedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "MessageDate",
                value: new DateTime(2021, 1, 21, 14, 51, 13, 225, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "MessageDate",
                value: new DateTime(2021, 1, 21, 14, 51, 13, 255, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "MessageDate",
                value: new DateTime(2021, 1, 21, 14, 51, 13, 255, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4,
                column: "MessageDate",
                value: new DateTime(2021, 1, 21, 14, 51, 13, 255, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5,
                column: "MessageDate",
                value: new DateTime(2021, 1, 21, 14, 51, 13, 255, DateTimeKind.Local).AddTicks(2160));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "MessageDate",
                value: new DateTime(2021, 1, 21, 10, 49, 8, 838, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "MessageDate",
                value: new DateTime(2021, 1, 21, 10, 49, 8, 857, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "MessageDate",
                value: new DateTime(2021, 1, 21, 10, 49, 8, 857, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4,
                column: "MessageDate",
                value: new DateTime(2021, 1, 21, 10, 49, 8, 857, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5,
                column: "MessageDate",
                value: new DateTime(2021, 1, 21, 10, 49, 8, 857, DateTimeKind.Local).AddTicks(8040));
        }
    }
}
