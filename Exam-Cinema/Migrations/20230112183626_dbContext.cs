using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exam_Cinema.Migrations
{
    public partial class dbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0020198817",
                columns: new[] { "Created", "Director", "PublishYear", "Title", "Updated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 36, 26, 196, DateTimeKind.Local).AddTicks(7171), "Quentin Tarantino", 1994, "Pulp Fiction: ", new DateTime(2023, 1, 12, 20, 36, 26, 196, DateTimeKind.Local).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0439136350",
                columns: new[] { "Created", "Director", "PublishYear", "Title", "Updated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 36, 26, 196, DateTimeKind.Local).AddTicks(7191), "Christopher Nolan", 2010, "Inception: ", new DateTime(2023, 1, 12, 20, 36, 26, 196, DateTimeKind.Local).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0451526929",
                columns: new[] { "Created", "Director", "PublishYear", "Title", "Updated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 36, 26, 196, DateTimeKind.Local).AddTicks(7186), "David Fincher", 1999, "Fight Club: ", new DateTime(2023, 1, 12, 20, 36, 26, 196, DateTimeKind.Local).AddTicks(7188) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0451528905",
                columns: new[] { "Created", "Director", "PublishYear", "Title", "Updated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 36, 26, 196, DateTimeKind.Local).AddTicks(7161), "Sidney Lumet", 1957, "12 Angry Men: ", new DateTime(2023, 1, 12, 20, 36, 26, 196, DateTimeKind.Local).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0553211765",
                columns: new[] { "Created", "Director", "PublishYear", "Title", "Updated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 36, 26, 196, DateTimeKind.Local).AddTicks(7095), "Frank Darabonts", 1994, "The Shawshank Redemption: ", new DateTime(2023, 1, 12, 20, 36, 26, 196, DateTimeKind.Local).AddTicks(7145) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0553213113",
                columns: new[] { "Created", "Director", "PublishYear", "Title", "Updated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 36, 26, 196, DateTimeKind.Local).AddTicks(7176), "Sergio Leone", 1966, "The Good, the Bad and the Ugly: ", new DateTime(2023, 1, 12, 20, 36, 26, 196, DateTimeKind.Local).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0786275391",
                columns: new[] { "Created", "Director", "PublishYear", "Title", "Updated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 36, 26, 196, DateTimeKind.Local).AddTicks(7150), "Francis Ford Coppola", 1972, "The Godfather: ", new DateTime(2023, 1, 12, 20, 36, 26, 196, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0847980790",
                columns: new[] { "Created", "Director", "PublishYear", "Title", "Updated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 36, 26, 196, DateTimeKind.Local).AddTicks(7166), "Steven Spielberg", 1993, "Schindler's List: ", new DateTime(2023, 1, 12, 20, 36, 26, 196, DateTimeKind.Local).AddTicks(7168) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "1400079985",
                columns: new[] { "Created", "Director", "PublishYear", "Title", "Updated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 36, 26, 196, DateTimeKind.Local).AddTicks(7181), "Robert Zemeckis", 1994, "Forrest Gump: ", new DateTime(2023, 1, 12, 20, 36, 26, 196, DateTimeKind.Local).AddTicks(7183) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "1856134032",
                columns: new[] { "Created", "Director", "PublishYear", "Title", "Updated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 36, 26, 196, DateTimeKind.Local).AddTicks(7155), "Christopher Nolan", 2008, "The Dark Knight: ", new DateTime(2023, 1, 12, 20, 36, 26, 196, DateTimeKind.Local).AddTicks(7158) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "1856136124",
                columns: new[] { "Created", "Director", "PublishYear", "Title", "Updated" },
                values: new object[] { new DateTime(2023, 1, 12, 20, 36, 26, 196, DateTimeKind.Local).AddTicks(7197), "Lilly Wachowski", 1999, "The Matrix: ", new DateTime(2023, 1, 12, 20, 36, 26, 196, DateTimeKind.Local).AddTicks(7199) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0020198817",
                columns: new[] { "Created", "Director", "PublishYear", "Title", "Updated" },
                values: new object[] { new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1543), "F. Scott Fitzgerald", 1992, "The Great Gatsby", new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0439136350",
                columns: new[] { "Created", "Director", "PublishYear", "Title", "Updated" },
                values: new object[] { new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1559), "Rowling, J. K.", 1999, "Harry Potter And The Prisoner Of Azkaban", new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0451526929",
                columns: new[] { "Created", "Director", "PublishYear", "Title", "Updated" },
                values: new object[] { new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1555), "William Shakespeare", 1998, "Hamlet", new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0451528905",
                columns: new[] { "Created", "Director", "PublishYear", "Title", "Updated" },
                values: new object[] { new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1535), "Miguel de Cervantes", 2003, "Don Quixote", new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1537) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0553211765",
                columns: new[] { "Created", "Director", "PublishYear", "Title", "Updated" },
                values: new object[] { new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1486), "Charles Dickens", 1989, "A Tale of Two Cities", new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1524) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0553213113",
                columns: new[] { "Created", "Director", "PublishYear", "Title", "Updated" },
                values: new object[] { new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1547), "Herman Melville", 1981, "Moby Dick", new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0786275391",
                columns: new[] { "Created", "Director", "PublishYear", "Title", "Updated" },
                values: new object[] { new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1527), "Antoine de Saint-Exupery", 2005, "The Little Prince", new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1529) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "0847980790",
                columns: new[] { "Created", "Director", "PublishYear", "Title", "Updated" },
                values: new object[] { new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1539), "Agatha Christie", 1939, "And Then There Were None", new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "1400079985",
                columns: new[] { "Created", "Director", "PublishYear", "Title", "Updated" },
                values: new object[] { new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1551), "Leo Tolstoy", 2008, "War and Peace", new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1553) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "1856134032",
                columns: new[] { "Created", "Director", "PublishYear", "Title", "Updated" },
                values: new object[] { new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1531), "Rowling, J. K.", 1997, "Harry Potter and The Philosopher's Stone", new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1533) });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "ISBN",
                keyValue: "1856136124",
                columns: new[] { "Created", "Director", "PublishYear", "Title", "Updated" },
                values: new object[] { new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1563), "Rowling, J. K.", 1998, "Harry Potter and the Chamber of Secrets", new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1565) });
        }
    }
}
