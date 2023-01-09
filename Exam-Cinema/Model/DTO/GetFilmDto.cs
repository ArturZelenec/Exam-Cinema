namespace Exam_Cinema.Model.DTO
{
    public class GetFilmDto
    {
        public string ISBN { get; set; }

        /// <summary>
        /// Film title and director seperated by space
        /// </summary>
        public string TitleAndDirector { get; set; }

        /// <summary>
        /// Release year of the film
        /// </summary>
        public int PublishYear { get; set; }
    }
}
