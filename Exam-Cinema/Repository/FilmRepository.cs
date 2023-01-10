using Exam_Cinema.Data;
using Exam_Cinema.Model;
using Exam_Cinema.Repository.IRepository;

namespace Exam_Cinema.Repository
{
    public class FilmRepository : Repository<Film>, IFilmRepository
    {
        private readonly FilmContext _db;

        public FilmRepository(FilmContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Film> UpdateAsync(Film film)
        {

            film.Updated = DateTime.Now;
            _db.Films.Update(film);
            await _db.SaveChangesAsync();
            return film;
        }
    }
}
