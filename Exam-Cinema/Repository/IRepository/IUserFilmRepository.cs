using Exam_Cinema.Model;

namespace Exam_Cinema.Repository.IRepository
{
    public interface IUserFilmRepository : IRepository<UserFilm>
    {
        Task<UserFilm> UpdateAsync(UserFilm userFilm);
        //void UpdateDaysLate(int userBookId, int daysLate);
    }
}
