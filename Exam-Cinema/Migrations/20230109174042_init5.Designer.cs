// <auto-generated />
using System;
using Exam_Cinema.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Exam_Cinema.Migrations
{
    [DbContext(typeof(FilmContext))]
    [Migration("20230109174042_init5")]
    partial class init5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.12");

            modelBuilder.Entity("Exam_Cinema.Model.Film", b =>
                {
                    b.Property<string>("ISBN")
                        .HasColumnType("TEXT");

                    b.Property<int>("AvailableFilmsInLibrary")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("EFormatType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("PublishYear")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("TEXT");

                    b.HasKey("ISBN");

                    b.ToTable("Films");

                    b.HasData(
                        new
                        {
                            ISBN = "0553211765",
                            AvailableFilmsInLibrary = 0,
                            Created = new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1486),
                            Director = "Charles Dickens",
                            EFormatType = "FullHD",
                            PublishYear = 1989,
                            Title = "A Tale of Two Cities",
                            Updated = new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1524)
                        },
                        new
                        {
                            ISBN = "0786275391",
                            AvailableFilmsInLibrary = 0,
                            Created = new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1527),
                            Director = "Antoine de Saint-Exupery",
                            EFormatType = "UltraHD",
                            PublishYear = 2005,
                            Title = "The Little Prince",
                            Updated = new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1529)
                        },
                        new
                        {
                            ISBN = "1856134032",
                            AvailableFilmsInLibrary = 0,
                            Created = new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1531),
                            Director = "Rowling, J. K.",
                            EFormatType = "HD",
                            PublishYear = 1997,
                            Title = "Harry Potter and The Philosopher's Stone",
                            Updated = new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1533)
                        },
                        new
                        {
                            ISBN = "0451528905",
                            AvailableFilmsInLibrary = 0,
                            Created = new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1535),
                            Director = "Miguel de Cervantes",
                            EFormatType = "HD",
                            PublishYear = 2003,
                            Title = "Don Quixote",
                            Updated = new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1537)
                        },
                        new
                        {
                            ISBN = "0847980790",
                            AvailableFilmsInLibrary = 0,
                            Created = new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1539),
                            Director = "Agatha Christie",
                            EFormatType = "FullHD",
                            PublishYear = 1939,
                            Title = "And Then There Were None",
                            Updated = new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1541)
                        },
                        new
                        {
                            ISBN = "0020198817",
                            AvailableFilmsInLibrary = 0,
                            Created = new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1543),
                            Director = "F. Scott Fitzgerald",
                            EFormatType = "UltraHD",
                            PublishYear = 1992,
                            Title = "The Great Gatsby",
                            Updated = new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1545)
                        },
                        new
                        {
                            ISBN = "0553213113",
                            AvailableFilmsInLibrary = 0,
                            Created = new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1547),
                            Director = "Herman Melville",
                            EFormatType = "HD",
                            PublishYear = 1981,
                            Title = "Moby Dick",
                            Updated = new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1549)
                        },
                        new
                        {
                            ISBN = "1400079985",
                            AvailableFilmsInLibrary = 0,
                            Created = new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1551),
                            Director = "Leo Tolstoy",
                            EFormatType = "HD",
                            PublishYear = 2008,
                            Title = "War and Peace",
                            Updated = new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1553)
                        },
                        new
                        {
                            ISBN = "0451526929",
                            AvailableFilmsInLibrary = 0,
                            Created = new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1555),
                            Director = "William Shakespeare",
                            EFormatType = "UltraHD",
                            PublishYear = 1998,
                            Title = "Hamlet",
                            Updated = new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1557)
                        },
                        new
                        {
                            ISBN = "0439136350",
                            AvailableFilmsInLibrary = 0,
                            Created = new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1559),
                            Director = "Rowling, J. K.",
                            EFormatType = "UltraHD",
                            PublishYear = 1999,
                            Title = "Harry Potter And The Prisoner Of Azkaban",
                            Updated = new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1561)
                        },
                        new
                        {
                            ISBN = "1856136124",
                            AvailableFilmsInLibrary = 0,
                            Created = new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1563),
                            Director = "Rowling, J. K.",
                            EFormatType = "FullHD",
                            PublishYear = 1998,
                            Title = "Harry Potter and the Chamber of Secrets",
                            Updated = new DateTime(2023, 1, 9, 19, 40, 42, 643, DateTimeKind.Local).AddTicks(1565)
                        });
                });

            modelBuilder.Entity("Exam_Cinema.Model.LibraryFilm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("FilmISBN")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsTaken")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FilmISBN");

                    b.ToTable("LibraryFilms");
                });

            modelBuilder.Entity("Exam_Cinema.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TakenFilms")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Exam_Cinema.Model.UserFilm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FilmTaken")
                        .HasColumnType("TEXT");

                    b.Property<int>("LibraryFilmId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("LibraryFilmId");

                    b.HasIndex("UserId");

                    b.ToTable("UserFilms");
                });

            modelBuilder.Entity("Exam_Cinema.Model.LibraryFilm", b =>
                {
                    b.HasOne("Exam_Cinema.Model.Film", "Film")
                        .WithMany("LibraryFilms")
                        .HasForeignKey("FilmISBN")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Film");
                });

            modelBuilder.Entity("Exam_Cinema.Model.UserFilm", b =>
                {
                    b.HasOne("Exam_Cinema.Model.LibraryFilm", "LibraryFilm")
                        .WithMany("UserFilms")
                        .HasForeignKey("LibraryFilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Exam_Cinema.Model.User", "User")
                        .WithMany("UserFilms")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LibraryFilm");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Exam_Cinema.Model.Film", b =>
                {
                    b.Navigation("LibraryFilms");
                });

            modelBuilder.Entity("Exam_Cinema.Model.LibraryFilm", b =>
                {
                    b.Navigation("UserFilms");
                });

            modelBuilder.Entity("Exam_Cinema.Model.User", b =>
                {
                    b.Navigation("UserFilms");
                });
#pragma warning restore 612, 618
        }
    }
}
