using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exam_Cinema.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LibraryFilm_Films_FilmISBN",
                table: "LibraryFilm");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFilm_LibraryFilm_LibraryFilmId",
                table: "UserFilm");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFilm_Users_UserId",
                table: "UserFilm");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserFilm",
                table: "UserFilm");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LibraryFilm",
                table: "LibraryFilm");

            migrationBuilder.RenameTable(
                name: "UserFilm",
                newName: "UserFilms");

            migrationBuilder.RenameTable(
                name: "LibraryFilm",
                newName: "LibraryFilms");

            migrationBuilder.RenameColumn(
                name: "Author",
                table: "Films",
                newName: "Director");

            migrationBuilder.RenameIndex(
                name: "IX_UserFilm_UserId",
                table: "UserFilms",
                newName: "IX_UserFilms_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserFilm_LibraryFilmId",
                table: "UserFilms",
                newName: "IX_UserFilms_LibraryFilmId");

            migrationBuilder.RenameIndex(
                name: "IX_LibraryFilm_FilmISBN",
                table: "LibraryFilms",
                newName: "IX_LibraryFilms_FilmISBN");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserFilms",
                table: "UserFilms",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LibraryFilms",
                table: "LibraryFilms",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0020198817",
                columns: new[] { "Created", "EFormatType", "Updated" },
                values: new object[] { new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1543), "UltraHD", new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0439136350",
                columns: new[] { "Created", "EFormatType", "Updated" },
                values: new object[] { new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1559), "UltraHD", new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0451526929",
                columns: new[] { "Created", "EFormatType", "Updated" },
                values: new object[] { new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1555), "UltraHD", new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0451528905",
                columns: new[] { "Created", "EFormatType", "Updated" },
                values: new object[] { new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1535), "HD", new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1537) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0553211765",
                columns: new[] { "Created", "EFormatType", "Updated" },
                values: new object[] { new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1486), "FullHD", new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1524) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0553213113",
                columns: new[] { "Created", "EFormatType", "Updated" },
                values: new object[] { new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1547), "HD", new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0786275391",
                columns: new[] { "Created", "EFormatType", "Updated" },
                values: new object[] { new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1527), "UltraHD", new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1529) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0847980790",
                columns: new[] { "Created", "EFormatType", "Updated" },
                values: new object[] { new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1539), "FullHD", new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "1400079985",
                columns: new[] { "Created", "EFormatType", "Updated" },
                values: new object[] { new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1551), "HD", new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1553) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "1856134032",
                columns: new[] { "Created", "EFormatType", "Updated" },
                values: new object[] { new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1531), "HD", new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1533) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "1856136124",
                columns: new[] { "Created", "EFormatType", "Updated" },
                values: new object[] { new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1563), "FullHD", new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1565) });

            migrationBuilder.AddForeignKey(
                name: "FK_LibraryFilms_Films_FilmISBN",
                table: "LibraryFilms",
                column: "FilmISBN",
                principalTable: "Films",
                principalColumn: "ISBN",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserFilms_LibraryFilms_LibraryFilmId",
                table: "UserFilms",
                column: "LibraryFilmId",
                principalTable: "LibraryFilms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserFilms_Users_UserId",
                table: "UserFilms",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LibraryFilms_Films_FilmISBN",
                table: "LibraryFilms");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFilms_LibraryFilms_LibraryFilmId",
                table: "UserFilms");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFilms_Users_UserId",
                table: "UserFilms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserFilms",
                table: "UserFilms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LibraryFilms",
                table: "LibraryFilms");

            migrationBuilder.RenameTable(
                name: "UserFilms",
                newName: "UserFilm");

            migrationBuilder.RenameTable(
                name: "LibraryFilms",
                newName: "LibraryFilm");

            migrationBuilder.RenameColumn(
                name: "Director",
                table: "Films",
                newName: "Author");

            migrationBuilder.RenameIndex(
                name: "IX_UserFilms_UserId",
                table: "UserFilm",
                newName: "IX_UserFilm_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserFilms_LibraryFilmId",
                table: "UserFilm",
                newName: "IX_UserFilm_LibraryFilmId");

            migrationBuilder.RenameIndex(
                name: "IX_LibraryFilms_FilmISBN",
                table: "LibraryFilm",
                newName: "IX_LibraryFilm_FilmISBN");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserFilm",
                table: "UserFilm",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LibraryFilm",
                table: "LibraryFilm",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0020198817",
                columns: new[] { "Created", "EFormatType", "Updated" },
                values: new object[] { new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2268), "VHS", new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0439136350",
                columns: new[] { "Created", "EFormatType", "Updated" },
                values: new object[] { new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2280), "DVD", new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0451526929",
                columns: new[] { "Created", "EFormatType", "Updated" },
                values: new object[] { new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2277), "DVD", new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2278) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0451528905",
                columns: new[] { "Created", "EFormatType", "Updated" },
                values: new object[] { new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2262), "VHS", new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2263) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0553211765",
                columns: new[] { "Created", "EFormatType", "Updated" },
                values: new object[] { new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2213), "DVD", new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2253) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0553213113",
                columns: new[] { "Created", "EFormatType", "Updated" },
                values: new object[] { new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2271), "DVD", new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0786275391",
                columns: new[] { "Created", "EFormatType", "Updated" },
                values: new object[] { new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2256), "VHS", new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0847980790",
                columns: new[] { "Created", "EFormatType", "Updated" },
                values: new object[] { new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2265), "DVD", new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2266) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "1400079985",
                columns: new[] { "Created", "EFormatType", "Updated" },
                values: new object[] { new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2274), "VHS", new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "1856134032",
                columns: new[] { "Created", "EFormatType", "Updated" },
                values: new object[] { new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2259), "DVD", new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2260) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "1856136124",
                columns: new[] { "Created", "EFormatType", "Updated" },
                values: new object[] { new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2283), "DVD", new DateTime(2023, 1, 6, 1, 57, 35, 486, DateTimeKind.Local).AddTicks(2284) });

            migrationBuilder.AddForeignKey(
                name: "FK_LibraryFilm_Films_FilmISBN",
                table: "LibraryFilm",
                column: "FilmISBN",
                principalTable: "Films",
                principalColumn: "ISBN",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserFilm_LibraryFilm_LibraryFilmId",
                table: "UserFilm",
                column: "LibraryFilmId",
                principalTable: "LibraryFilm",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserFilm_Users_UserId",
                table: "UserFilm",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
