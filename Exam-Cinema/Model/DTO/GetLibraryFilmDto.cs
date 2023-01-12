namespace Exam_Cinema.Model.DTO
{
    public class GetLibraryFilmDto
    {
        /// <summary>
        /// Library film Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Film specific number
        /// </summary>
        public string? FilmISBN { get; set; }
        /// <summary>
        /// Film Title
        /// </summary>
        public string? FilmTitle { get; set; }
        /// <summary>
        /// Film Director
        /// </summary>
        public string? FilmDirector{ get; set; }
        /// <summary>
        /// Film format type
        /// </summary>
        public string? FilmFormatType{ get; set; }
        /// <summary>
        /// Film realese date
        /// </summary>
        public string? FilmPublishYear { get; set; }
        /// <summary>
        /// Film watching or not
        /// </summary>
        public bool IsTaken { get; set; }
        /// <summary>
        /// Watch film history
        /// </summary>
        public virtual List<LibraryFilmUserFilmDto>? LibraryFilmUserHistory { get; set; }
    }
}
