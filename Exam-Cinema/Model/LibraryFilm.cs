using System.ComponentModel.DataAnnotations;

namespace Exam_Cinema.Model
{
    public class LibraryFilm
    {
        [Key]
        public int Id { get; set; }
        public string FilmISBN { get; set; }
        public virtual Film Film { get; set; }
        public bool IsTaken { get; set; }
        public virtual IEnumerable<UserFilm>? UserFilms { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
