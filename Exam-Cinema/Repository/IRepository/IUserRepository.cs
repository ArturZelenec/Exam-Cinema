using Exam_Cinema.Model;
using Exam_Cinema.Model.DTO;
using System.Linq.Expressions;

namespace Exam_Cinema.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);
        LoginResponse Login(LoginRequest loginRequest);
        RegistrationResponse Register(RegistrationRequest registrationRequest);
        public List<GetUserDto> GetAll(Expression<Func<User, bool>>? filter = null);
        public GetUserDto Get(Expression<Func<User, bool>> filter = null);
        public void UpdateTakenLibraryFilms(int userId, int modifier);
        //public void UpdateBooksNotReturnedInTimeAndTotalDebt(int userId, int booksNotReturnedInTime, double totalDebt);
    }
}
