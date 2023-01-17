using Exam_Cinema.Model;
using Microsoft.EntityFrameworkCore;

namespace Exam_Cinema.Data
{
    public class FilmContext : DbContext
    {
        public FilmContext(DbContextOptions<FilmContext> options) : base(options) { }

        public DbSet<Film> Films { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserFilm> UserFilms { get; set; }
        public DbSet<LibraryFilm> LibraryFilms { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var books = modelBuilder.Entity<Film>();
            books.HasData(
                new Film("0553211765", "The Shawshank Redemption: ", "Frank Darabonts", EFormatType.FullHD, 1994),
                new Film("0786275391", "The Godfather: ", "Francis Ford Coppola", EFormatType.UltraHD, 1972),
                new Film("1856134032", "The Dark Knight: ", "Christopher Nolan", EFormatType.HD, 2008),
                new Film("0451528905", "12 Angry Men: ", "Sidney Lumet", EFormatType.HD, 1957),
                new Film("0847980790", "Schindler's List: ", "Steven Spielberg", EFormatType.FullHD, 1993),
                new Film("0020198817", "Pulp Fiction: ", "Quentin Tarantino", EFormatType.UltraHD, 1994),
                new Film("0553213113", "The Good, the Bad and the Ugly: ", "Sergio Leone", EFormatType.HD, 1966),
                new Film("1400079985", "Forrest Gump: ", "Robert Zemeckis", EFormatType.HD, 1994),
                new Film("0451526929", "Fight Club: ", "David Fincher", EFormatType.UltraHD, 1999),
                new Film("0439136350", "Inception: ", "Christopher Nolan", EFormatType.UltraHD, 2010),
                new Film("1856136124", "The Matrix: ", "Lilly Wachowski", EFormatType.FullHD, 1999)
                );
            books.Property(b => b.Title)
                 .HasMaxLength(200);
            books.Property(b => b.Director)
                 .HasMaxLength(100);
            books.Property(b => b.EFormatType)
                 .HasConversion<string>()
                 .HasMaxLength(50);

            var users = modelBuilder.Entity<User>();
            users.Property(u => u.Username)
                .HasMaxLength(100);
            users.Property(u => u.FullName)
                .HasMaxLength(100);
        }
    }
}
