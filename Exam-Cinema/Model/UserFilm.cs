using System.ComponentModel.DataAnnotations;

namespace Exam_Cinema.Model
{
    public class UserFilm
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int LibraryFilmId { get; set; }
        public virtual LibraryFilm LibraryFilm { get; set; }
        public DateTime FilmTaken { get; set; }
        public DateTime? FilmReturned { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public int DaysLate { get; set; } = 0;
    }
}
