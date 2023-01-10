using Exam_Cinema.Model;
using Exam_Cinema.Model.DTO;
using System.Linq.Expressions;

namespace Exam_Cinema.Repository.IRepository
{
    public interface IUserRepository
    {
        Task<bool> IsUniqueUserAsync(string username);
        Task<LoginResponse> LoginAsync(LoginRequest loginRequest);
        Task<RegistrationResponse> RegisterAsync(RegistrationRequest registrationRequest);
        Task<List<GetUserDto>> GetAllAsync(Expression<Func<User, bool>>? filter = null);
        Task<GetUserDto> GetAsync(Expression<Func<User, bool>> filter = null);
        Task UpdateTakenLibraryFilms(int userId, int modifier);
        //public void UpdateBooksNotReturnedInTimeAndTotalDebt(int userId, int booksNotReturnedInTime, double totalDebt);
    }
}
