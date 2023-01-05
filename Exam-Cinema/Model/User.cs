using System.ComponentModel.DataAnnotations;

namespace Exam_Cinema.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Role { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public virtual IEnumerable<UserFilm>? UserFilms { get; set; }
        public int TakenFilms { get; set; } = 0;
       
    }
}
