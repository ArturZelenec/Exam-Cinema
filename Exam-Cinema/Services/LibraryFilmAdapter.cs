using Exam_Cinema.Model;
using Exam_Cinema.Model.DTO;
using Exam_Cinema.Services.IServices;

namespace Exam_Cinema.Services
{
    public class LibraryFilmAdapter : ILibraryFilmAdapter
    {
        public GetLibraryFilmDto Adapt(LibraryFilm libraryFilm)
        {
            List<LibraryFilmUserFilmDto> libraryFilmUserHistory = null;
            if (libraryFilm.UserFilms != null)
            {
                libraryFilmUserHistory = libraryFilm.UserFilms
                .Select(userFilm => Adapt(userFilm))
                .ToList();
            };

            return new GetLibraryFilmDto()
            {
                Id = libraryFilm.Id,
                FilmISBN = libraryFilm.FilmISBN,
                FilmTitle = libraryFilm.Film?.Title,
                FilmDirector = libraryFilm.Film?.Director,
                FilmFormatType = libraryFilm.Film?.EFormatType.ToString(),
                FilmPublishYear = libraryFilm.Film?.PublishYear.ToString(),
                IsTaken = libraryFilm.IsTaken,
                LibraryFilmUserHistory = libraryFilmUserHistory
                
            };
        }

        public List<GetLibraryFilmDto> Adapt(IEnumerable<LibraryFilm> libraryFilms)
        {
            List<GetLibraryFilmDto> result = new List<GetLibraryFilmDto>();
            foreach (var libraryFilm in libraryFilms)
                result.Add(Adapt(libraryFilm));
            return result;
        }

        public LibraryFilmUserFilmDto Adapt(UserFilm userFilm)
        {
            return new LibraryFilmUserFilmDto()
            {
                Name = userFilm.User.FullName,
                FilmTaken = userFilm.FilmTaken,
                
            };
        }


        public LibraryFilm Adapt(string isbn, Film film)
        {
            return new LibraryFilm()
            {
                FilmISBN = isbn,
                Film = film,
                IsTaken = false,
                Created = DateTime.Now,
                Updated = DateTime.Now
            };
        }
    }
}
