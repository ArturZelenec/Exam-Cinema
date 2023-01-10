using Exam_Cinema.Model;

namespace Exam_Cinema.Repository.IRepository
{
    public interface IFilmRepository : IRepository<Film>
    {
        Task<Film> UpdateAsync(Film film);
    
    }
}
