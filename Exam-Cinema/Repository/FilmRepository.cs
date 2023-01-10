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

        public Film Update(Film film)
        {

            film.Updated = DateTime.Now;
            _db.Films.Update(film);
            _db.SaveChanges();
            return film;
        }
    }
}
