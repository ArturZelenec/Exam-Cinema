using Exam_Cinema.Model;
using Microsoft.EntityFrameworkCore;

namespace Exam_Cinema.Data
{
    public class FilmContext : DbContext
    {
        public FilmContext(DbContextOptions<FilmContext> options) : base(options) { }

        public DbSet<Film> Films { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var books = modelBuilder.Entity<Film>();
            books.HasData(
                new Film("0553211765", "A Tale of Two Cities", "Charles Dickens", EFormatType.DVD, 1989),
                new Film("0786275391", "The Little Prince", "Antoine de Saint-Exupery", EFormatType.VHS, 2005),
                new Film("1856134032", "Harry Potter and The Philosopher's Stone", "Rowling, J. K.", EFormatType.DVD, 1997),
                new Film("0451528905", "Don Quixote", "Miguel de Cervantes", EFormatType.VHS, 2003),
                new Film("0847980790", "And Then There Were None", "Agatha Christie", EFormatType.DVD, 1939),
                new Film("0020198817", "The Great Gatsby", "F. Scott Fitzgerald", EFormatType.VHS, 1992),
                new Film("0553213113", "Moby Dick", "Herman Melville", EFormatType.DVD, 1981),
                new Film("1400079985", "War and Peace", "Leo Tolstoy", EFormatType.VHS, 2008),
                new Film("0451526929", "Hamlet", "William Shakespeare", EFormatType.DVD, 1998),
                new Film("0439136350", "Harry Potter And The Prisoner Of Azkaban", "Rowling, J. K.", EFormatType.DVD, 1999),
                new Film("1856136124", "Harry Potter and the Chamber of Secrets", "Rowling, J. K.", EFormatType.DVD, 1998)
                );
            books.Property(b => b.Title)
                 .HasMaxLength(200);
            books.Property(b => b.Author)
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
