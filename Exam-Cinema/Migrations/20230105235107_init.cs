using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exam_Cinema.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    ISBN = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Author = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    EFormatType = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    PublishYear = table.Column<int>(type: "INTEGER", nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Updated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AvailableFilmsInLibrary = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.ISBN);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    FullName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "BLOB", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "BLOB", nullable: false),
                    Role = table.Column<string>(type: "TEXT", nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Updated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TakenFilms = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LibraryFilm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FilmISBN = table.Column<string>(type: "TEXT", nullable: false),
                    IsTaken = table.Column<bool>(type: "INTEGER", nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Updated = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryFilm", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LibraryFilm_Films_FilmISBN",
                        column: x => x.FilmISBN,
                        principalTable: "Films",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserFilm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    LibraryFilmId = table.Column<int>(type: "INTEGER", nullable: false),
                    FilmTaken = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FilmReturned = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Updated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DaysLate = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFilm", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserFilm_LibraryFilm_LibraryFilmId",
                        column: x => x.LibraryFilmId,
                        principalTable: "LibraryFilm",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFilm_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "ISBN", "Author", "AvailableFilmsInLibrary", "Created", "EFormatType", "PublishYear", "Title", "Updated" },
                values: new object[] { "0020198817", "F. Scott Fitzgerald", 0, new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7823), "VHS", 1992, "The Great Gatsby", new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7824) });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "ISBN", "Author", "AvailableFilmsInLibrary", "Created", "EFormatType", "PublishYear", "Title", "Updated" },
                values: new object[] { "0439136350", "Rowling, J. K.", 0, new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7835), "DVD", 1999, "Harry Potter And The Prisoner Of Azkaban", new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7837) });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "ISBN", "Author", "AvailableFilmsInLibrary", "Created", "EFormatType", "PublishYear", "Title", "Updated" },
                values: new object[] { "0451526929", "William Shakespeare", 0, new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7832), "DVD", 1998, "Hamlet", new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7834) });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "ISBN", "Author", "AvailableFilmsInLibrary", "Created", "EFormatType", "PublishYear", "Title", "Updated" },
                values: new object[] { "0451528905", "Miguel de Cervantes", 0, new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7817), "VHS", 2003, "Don Quixote", new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7818) });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "ISBN", "Author", "AvailableFilmsInLibrary", "Created", "EFormatType", "PublishYear", "Title", "Updated" },
                values: new object[] { "0553211765", "Charles Dickens", 0, new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7769), "DVD", 1989, "A Tale of Two Cities", new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7807) });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "ISBN", "Author", "AvailableFilmsInLibrary", "Created", "EFormatType", "PublishYear", "Title", "Updated" },
                values: new object[] { "0553213113", "Herman Melville", 0, new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7826), "DVD", 1981, "Moby Dick", new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7827) });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "ISBN", "Author", "AvailableFilmsInLibrary", "Created", "EFormatType", "PublishYear", "Title", "Updated" },
                values: new object[] { "0786275391", "Antoine de Saint-Exupery", 0, new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7810), "VHS", 2005, "The Little Prince", new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7812) });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "ISBN", "Author", "AvailableFilmsInLibrary", "Created", "EFormatType", "PublishYear", "Title", "Updated" },
                values: new object[] { "0847980790", "Agatha Christie", 0, new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7820), "DVD", 1939, "And Then There Were None", new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7821) });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "ISBN", "Author", "AvailableFilmsInLibrary", "Created", "EFormatType", "PublishYear", "Title", "Updated" },
                values: new object[] { "1400079985", "Leo Tolstoy", 0, new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7829), "VHS", 2008, "War and Peace", new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7831) });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "ISBN", "Author", "AvailableFilmsInLibrary", "Created", "EFormatType", "PublishYear", "Title", "Updated" },
                values: new object[] { "1856134032", "Rowling, J. K.", 0, new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7813), "DVD", 1997, "Harry Potter and The Philosopher's Stone", new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7815) });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "ISBN", "Author", "AvailableFilmsInLibrary", "Created", "EFormatType", "PublishYear", "Title", "Updated" },
                values: new object[] { "1856136124", "Rowling, J. K.", 0, new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7839), "DVD", 1998, "Harry Potter and the Chamber of Secrets", new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7841) });

            migrationBuilder.CreateIndex(
                name: "IX_LibraryFilm_FilmISBN",
                table: "LibraryFilm",
                column: "FilmISBN");

            migrationBuilder.CreateIndex(
                name: "IX_UserFilm_LibraryFilmId",
                table: "UserFilm",
                column: "LibraryFilmId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFilm_UserId",
                table: "UserFilm",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserFilm");

            migrationBuilder.DropTable(
                name: "LibraryFilm");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Films");
        }
    }
}
