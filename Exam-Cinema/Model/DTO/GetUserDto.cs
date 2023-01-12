namespace Exam_Cinema.Model.DTO
{
    public class GetUserDto
    {
        /// <summary>
        /// User Id
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// User full name
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// User Role (admin, user)
        /// </summary>
        public string Role { get; set; }
        /// <summary>
        /// Watched films
        /// </summary>
        public int TakenLibraryFilms{ get; set; }
        
    }
}
