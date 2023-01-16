namespace Exam_Cinema.Model.DTO
{
    public class GetUserFilmDto
    {
        public int? Id { get; set; }
        public int? UserId { get; set; }
        public string? UserFullName { get; set; }
        /// <summary>
        /// Library film id
        /// </summary>
        public int? LibraryFilmId { get; set; }
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
        public string? FilmDirector { get; set; }
        /// <summary>
        /// Тhe date when user take the film 
        /// </summary>
        public DateTime? FilmTaken { get; set; }


    }
}
