namespace Exam_Cinema.Model.DTO
{
    public class GetUserFilmkDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserFullName { get; set; }
        public int LibraryFilmkId { get; set; }
        public string FilmISBN { get; set; }
        public string FilmTitle { get; set; }
        public string FilmDirector { get; set; }
        public DateTime FilmTaken { get; set; }
        
    }
}
