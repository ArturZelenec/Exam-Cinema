using System.ComponentModel.DataAnnotations;

namespace Exam_Cinema.Model
{
    public class Film
    {
        public Film()
        {
        }

        public Film(string isbn, string title, string director, EFormatType eFormatType, int publishYear)
        {
            ISBN = isbn;
            Title = title;
            Director = director;
            EFormatType = eFormatType;
            PublishYear = publishYear;
            Created = DateTime.Now;
            Updated = DateTime.Now;
        }

        [Key]

        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public EFormatType EFormatType { get; set; }
        public int PublishYear { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public int AvailableFilmsInLibrary { get; set; } = 0;
        public virtual IEnumerable<LibraryFilm>? LibraryFilms { get; set; }
    }

}
