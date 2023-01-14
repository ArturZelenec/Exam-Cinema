using Exam_Cinema.Data;
using Exam_Cinema.Model;
using Exam_Cinema.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

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

        public async Task<IEnumerable<LibraryFilm>> Getdata_With_EagerLoading()
        {

            var duomenys = await _db.LibraryFilms
            .Include(f => f.Film)
            .ThenInclude(f => f.LibraryFilms)
            .ToListAsync();

            return duomenys;

        }
    }
}

