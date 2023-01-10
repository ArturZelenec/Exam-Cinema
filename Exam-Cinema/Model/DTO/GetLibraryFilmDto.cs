namespace Exam_Cinema.Model.DTO
{
    public class GetLibraryFilmDto
    {
        public int Id { get; set; }
        public string FilmISBN { get; set; }
        public string FilmTitle { get; set; }
        public string FilmDirector{ get; set; }
        public string FilmFormatType{ get; set; }
        public string FilmPublishYear { get; set; }
        public bool IsTaken { get; set; }
        public virtual List<LibraryFilmUserFilmDto>? LibraryFilmUserHistory { get; set; }
    }
}
