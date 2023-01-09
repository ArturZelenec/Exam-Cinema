namespace Exam_Cinema.Model.DTO
{
    public class FilterFilmRequestDto
    {
        /// <summary>
        /// Film title
        /// </summary>
        public string Title { get; set; } = "";

        /// <summary>
        /// Director of the film
        /// </summary>
        public string Director { get; set; } = "";

        /// <summary>
        /// Format of the film
        /// </summary>
        public string FormatTipe { get; set; } = "";
    }
}
