using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MessageBoard.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "GroupName" },
                values: new object[] { 1, "Baby Animals" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "GroupName" },
                values: new object[] { 2, "Secret Missions" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "GroupName" },
                values: new object[] { 3, "Phobias" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "GroupId", "MessageAuthor", "MessageDate", "MessagePost" },
                values: new object[,]
                {
                    { 1, 1, "Jessie Finks", new DateTime(2021, 1, 21, 10, 49, 8, 838, DateTimeKind.Local).AddTicks(2340), "Kittens are my favorite baby animal" },
                    { 2, 1, "Arthur Aadvark", new DateTime(2021, 1, 21, 10, 49, 8, 857, DateTimeKind.Local).AddTicks(8000), "Puppies are my favorite baby animal" },
                    { 4, 2, "Agent Anonymous", new DateTime(2021, 1, 21, 10, 49, 8, 857, DateTimeKind.Local).AddTicks(8040), "When the minute hand strikes a tadpole's tail past the high-noon hour, meet me at the phantom clocktower behind O'Henry's for your secret mission" },
                    { 3, 3, "Not-a-podiatrist", new DateTime(2021, 1, 21, 10, 49, 8, 857, DateTimeKind.Local).AddTicks(8040), "I'm afraid of feet" },
                    { 5, 3, "FearOfClowns", new DateTime(2021, 1, 21, 10, 49, 8, 857, DateTimeKind.Local).AddTicks(8040), "Balloons are scary" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 3);
        }
    }
}
