using Exam_Cinema.Model;

namespace Exam_Cinema.Repository.IRepository
{
    public interface IUserFilmRepository : IRepository<UserFilm>
    {
        //Task<IEnumerable<UserFilm>> Getdata_With_EagerLoading();
        Task<UserFilm> UpdateAsync(UserFilm userFilm);

    }
}
