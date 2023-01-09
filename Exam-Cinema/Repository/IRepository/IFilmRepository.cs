using Exam_Cinema.Model;

namespace Exam_Cinema.Repository.IRepository
{
    public interface IFilmRepository : IRepository<Film>
    {
        Film Update(Film film);
    
    }
}
