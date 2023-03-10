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
    [Migration("20230105235107_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.12");

            modelBuilder.Entity("Exam_Cinema.Model.Film", b =>
                {
                    b.Property<string>("ISBN")
                        .HasColumnType("TEXT");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("AvailableFilmsInLibrary")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
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
                            Author = "Charles Dickens",
                            AvailableFilmsInLibrary = 0,
                            Created = new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7769),
                            EFormatType = "DVD",
                            PublishYear = 1989,
                            Title = "A Tale of Two Cities",
                            Updated = new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7807)
                        },
                        new
                        {
                            ISBN = "0786275391",
                            Author = "Antoine de Saint-Exupery",
                            AvailableFilmsInLibrary = 0,
                            Created = new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7810),
                            EFormatType = "VHS",
                            PublishYear = 2005,
                            Title = "The Little Prince",
                            Updated = new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7812)
                        },
                        new
                        {
                            ISBN = "1856134032",
                            Author = "Rowling, J. K.",
                            AvailableFilmsInLibrary = 0,
                            Created = new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7813),
                            EFormatType = "DVD",
                            PublishYear = 1997,
                            Title = "Harry Potter and The Philosopher's Stone",
                            Updated = new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7815)
                        },
                        new
                        {
                            ISBN = "0451528905",
                            Author = "Miguel de Cervantes",
                            AvailableFilmsInLibrary = 0,
                            Created = new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7817),
                            EFormatType = "VHS",
                            PublishYear = 2003,
                            Title = "Don Quixote",
                            Updated = new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7818)
                        },
                        new
                        {
                            ISBN = "0847980790",
                            Author = "Agatha Christie",
                            AvailableFilmsInLibrary = 0,
                            Created = new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7820),
                            EFormatType = "DVD",
                            PublishYear = 1939,
                            Title = "And Then There Were None",
                            Updated = new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7821)
                        },
                        new
                        {
                            ISBN = "0020198817",
                            Author = "F. Scott Fitzgerald",
                            AvailableFilmsInLibrary = 0,
                            Created = new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7823),
                            EFormatType = "VHS",
                            PublishYear = 1992,
                            Title = "The Great Gatsby",
                            Updated = new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7824)
                        },
                        new
                        {
                            ISBN = "0553213113",
                            Author = "Herman Melville",
                            AvailableFilmsInLibrary = 0,
                            Created = new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7826),
                            EFormatType = "DVD",
                            PublishYear = 1981,
                            Title = "Moby Dick",
                            Updated = new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7827)
                        },
                        new
                        {
                            ISBN = "1400079985",
                            Author = "Leo Tolstoy",
                            AvailableFilmsInLibrary = 0,
                            Created = new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7829),
                            EFormatType = "VHS",
                            PublishYear = 2008,
                            Title = "War and Peace",
                            Updated = new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7831)
                        },
                        new
                        {
                            ISBN = "0451526929",
                            Author = "William Shakespeare",
                            AvailableFilmsInLibrary = 0,
                            Created = new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7832),
                            EFormatType = "DVD",
                            PublishYear = 1998,
                            Title = "Hamlet",
                            Updated = new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7834)
                        },
                        new
                        {
                            ISBN = "0439136350",
                            Author = "Rowling, J. K.",
                            AvailableFilmsInLibrary = 0,
                            Created = new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7835),
                            EFormatType = "DVD",
                            PublishYear = 1999,
                            Title = "Harry Potter And The Prisoner Of Azkaban",
                            Updated = new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7837)
                        },
                        new
                        {
                            ISBN = "1856136124",
                            Author = "Rowling, J. K.",
                            AvailableFilmsInLibrary = 0,
                            Created = new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7839),
                            EFormatType = "DVD",
                            PublishYear = 1998,
                            Title = "Harry Potter and the Chamber of Secrets",
                            Updated = new DateTime(2023, 1, 6, 1, 51, 6, 943, DateTimeKind.Local).AddTicks(7841)
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

                    b.ToTable("LibraryFilm");
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

                    b.Property<int>("DaysLate")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("FilmReturned")
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

                    b.ToTable("UserFilm");
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
