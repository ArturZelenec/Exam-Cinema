namespace Exam_Cinema.Model.DTO
{
    public class CreateFilmDto
    {
        public CreateFilmDto()
        {
        }

        /// <summary>
        /// Film specific number
        /// </summary>
        public string ISBN { get; set; }

        /// <summary>
        /// Film title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Director of the film
        /// </summary>
        public string Director { get; set; }

        /// <summary>
        /// Release year of the film
        /// </summary>
        public DateTime Release { get; set; }

        /// <summary>
        /// Format of the film
        /// </summary>
        public string FilmFormat { get; set; }
    }
}

