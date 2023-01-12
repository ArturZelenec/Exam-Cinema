using Exam_Cinema.Model;
using Exam_Cinema.Model.DTO;
using Exam_Cinema.Services.IServices;

namespace Exam_Cinema.Services
{
    public class UserFilmAdapter : IUserFilmAdapter
    {
        public UserFilm Adapt(GetUserDto user, LibraryFilm libraryFilm)
        {
            return new UserFilm()
            {
                UserId = user.UserId,
                LibraryFilmId = libraryFilm.Id,
                FilmTaken = DateTime.Now,
                Created = DateTime.Now,
                Updated = DateTime.Now
            };
        }

        public GetUserFilmDto Adapt(UserFilm userFilm)
        {
            return new GetUserFilmDto()
            {
                Id = userFilm.Id,
                UserId = userFilm.UserId,
                UserFullName = userFilm.User?.FullName,
                LibraryFilmId = userFilm.LibraryFilmId,
                FilmISBN = userFilm.LibraryFilm.Film?.ISBN,
                FilmTitle = userFilm.LibraryFilm.Film?.Title,
                FilmDirector = userFilm.LibraryFilm.Film?.Director,
                FilmTaken = userFilm.FilmTaken,
            };
        }

        public GetUserAllFilmsDTO Adapt(IEnumerable<UserFilm> userFilms)
        {
            var result = new GetUserAllFilmsDTO();
            foreach (var userFilm in userFilms) 
            {
                result.Films.Add(new GetUserFilmDto
                {
                    
                    Id = userFilm.Id,
                    UserId = userFilm.UserId,
                    UserFullName = userFilm.User?.FullName,
                    LibraryFilmId = userFilm.LibraryFilmId,
                    FilmISBN = userFilm.LibraryFilm.Film?.ISBN,
                    FilmTitle = userFilm.LibraryFilm.Film?.Title,
                    FilmDirector = userFilm.LibraryFilm.Film?.Director,
                    FilmTaken = userFilm.FilmTaken,
                });
            }
            return result;
            //return new GetUserFilmDto()
            //{

            //    Id = userFilm.Id,
            //    UserId = userFilm.UserId,
            //    UserFullName = userFilm.User.FullName,
            //    LibraryFilmId = userFilm.LibraryFilmId,
            //    FilmISBN = userFilm.LibraryFilm.Film.ISBN,
            //    FilmTitle = userFilm.LibraryFilm.Film.Title,
            //    FilmDirector = userFilm.LibraryFilm.Film.Director,
            //    FilmTaken = userFilm.FilmTaken,

            //};
        }
    }
}
