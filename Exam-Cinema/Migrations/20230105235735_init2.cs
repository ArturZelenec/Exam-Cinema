using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exam_Cinema.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DaysLate",
                table: "UserFilm");

            migrationBuilder.DropColumn(
                name: "FilmReturned",
                table: "UserFilm");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0020198817",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2268), new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0439136350",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2280), new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0451526929",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2277), new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2278) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0451528905",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2262), new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2263) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0553211765",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2213), new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2253) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0553213113",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2271), new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0786275391",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2256), new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0847980790",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2265), new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2266) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "1400079985",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2274), new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "1856134032",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2259), new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2260) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "1856136124",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2283), new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2284) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DaysLate",
                table: "UserFilm",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FilmReturned",
                table: "UserFilm",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0020198817",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7823), new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7824) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0439136350",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7835), new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7837) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0451526929",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7832), new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7834) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0451528905",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7817), new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7818) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0553211765",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7769), new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0553213113",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7826), new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7827) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0786275391",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7810), new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7812) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0847980790",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7821) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "1400079985",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7829), new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7831) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "1856134032",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7813), new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "1856136124",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7839), new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7841) });
        }
    }
}
