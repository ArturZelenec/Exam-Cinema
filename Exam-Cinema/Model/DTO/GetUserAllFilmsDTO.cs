namespace Exam_Cinema.Model.DTO
{
    public class GetUserAllFilmsDTO
    {
        public string? FilmISBN { get; set; }
        public string? FilmTitle { get; set; }
        public string? FilmDirector { get; set; }
        public List<GetUserFilmDto> Films { get; set; } = new List<GetUserFilmDto>();

    }
}
