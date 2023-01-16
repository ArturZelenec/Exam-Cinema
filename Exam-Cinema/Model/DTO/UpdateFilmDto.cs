namespace Exam_Cinema.Model.DTO
{
    public class UpdateFilmDto
    {
        /// <summary>
        /// Film specific number
        /// </summary>
        public string ISBN { get; set; }

        /// <summary>
        /// Release date and time of the film
        /// </summary>
        public DateTime ReleaseDate { get; set; }

        /// <summary>
        /// Director of the film
        /// </summary>
        public string Director { get; set; }

        /// <summary>
        /// Film title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Format type of the film
        /// </summary>
        public string FormatType { get; set; }
    }
}
