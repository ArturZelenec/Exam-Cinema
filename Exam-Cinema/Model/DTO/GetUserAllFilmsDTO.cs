namespace Exam_Cinema.Model.DTO
{
    public class GetUserAllFilmsDTO
    {
        /// <summary>
        /// Film specific number
        /// </summary>
        public string? FilmISBN { get; set; }
        /// <summary>
        /// Film title
        /// </summary>
        public string? FilmTitle { get; set; }
        /// <summary>
        /// Film director
        /// </summary>
        public string? FilmDirector { get; set; }
        /// <summary>
        /// User films
        /// </summary>
        public List<GetUserFilmDto> Films { get; set; } = new List<GetUserFilmDto>();

    }
}
