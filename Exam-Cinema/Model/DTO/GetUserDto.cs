namespace Exam_Cinema.Model.DTO
{
    public class GetUserDto
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public int TakenLibraryFilms{ get; set; }
        public int FilmsNotReturnedInTime { get; set; }
        public double TotalDebt { get; set; }
    }
}
