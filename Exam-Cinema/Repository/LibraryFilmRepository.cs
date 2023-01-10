using Exam_Cinema.Data;
using Exam_Cinema.Model;
using Exam_Cinema.Repository.IRepository;

namespace Exam_Cinema.Repository
{
    public class LibraryFilmRepository : Repository<LibraryFilm>, ILibraryFilmRepository
    {
        private readonly FilmContext _db;

        public LibraryFilmRepository(FilmContext db) : base(db)
        {
            _db = db;
        }

        public async Task<LibraryFilm> UpdateAsync(LibraryFilm libraryFilm)
        {
            libraryFilm.Updated = DateTime.Now;
            _db.LibraryFilms.Update(libraryFilm);
            await _db.SaveChangesAsync();
            return libraryFilm;
        }
    }
}

