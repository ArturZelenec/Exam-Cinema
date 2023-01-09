namespace Exam_Cinema.Model.DTO
{
    public class GetLibraryFilmDto
    {
        public int Id { get; set; }
        public string BookISBN { get; set; }
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public string BookCoverType { get; set; }
        public string BookPublishYear { get; set; }
        public bool IsTaken { get; set; }
        public virtual List<LibraryFilmUserFilmDto>? LibraryFilmUserHistory { get; set; }
    }
}
