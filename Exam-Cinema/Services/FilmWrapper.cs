using Exam_Cinema.Model;
using Exam_Cinema.Model.DTO;
using Exam_Cinema.Services.IServices;

namespace Exam_Cinema.Services
{
    public class FilmWrapper : IFilmWrapper
    {
        public GetFilmDto Bind(Film film)
        {
            return new GetFilmDto
            {
                ISBN = film.ISBN,
                PublishYear = film.PublishYear,
                TitleAndDirector = film.Title + " " + film.Director
            };
        }

        public Film Bind(CreateFilmDto film)
        {
            return new Film
            {
                ISBN = film.ISBN,
                Title = film.Title,
                Director = film.Director,
                PublishYear = film.Release.Year,
                EFormatType = (EFormatType)Enum.Parse(typeof(EFormatType), film.FilmFormat),
                Created = DateTime.Now,
                Updated = DateTime.Now
            };
        }

        public Film Bind(UpdateFilmDto film)
        {
            return new Film
            {
                ISBN = film.ISBN,
                Title = film.Title,
                Director = film.Director,
                PublishYear = film.ReleaseDate.Year,
                EFormatType = (EFormatType)Enum.Parse(typeof(EFormatType), film.FormatType)
            };
        }
    }
}
