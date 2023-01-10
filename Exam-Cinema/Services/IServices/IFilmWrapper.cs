using Exam_Cinema.Model;
using Exam_Cinema.Model.DTO;

namespace Exam_Cinema.Services.IServices
{
    public interface IFilmWrapper
    {
        GetFilmDto Bind(Film film);
        Film Bind(CreateFilmDto book);
        Film Bind(UpdateFilmDto book);

    }
}
