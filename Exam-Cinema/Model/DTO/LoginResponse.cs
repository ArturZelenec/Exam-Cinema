namespace Exam_Cinema.Model.DTO
{
    public class LoginResponse
    {
        public RegistrationResponse? User { get; set; }

        public string Token { get; set; }
        //public int Id { get; set; }
    }
}
