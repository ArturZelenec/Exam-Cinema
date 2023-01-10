using Exam_Cinema.Model;
using Exam_Cinema.Model.DTO;

namespace Exam_Cinema.Services.IServices
{
    public interface ILibraryFilmAdapter
    {
        GetLibraryFilmDto Adapt(LibraryFilm libraryFilm);
        List<GetLibraryFilmDto> Adapt(IEnumerable<LibraryFilm> libraryFilms);
        LibraryFilm Adapt(string isbn, Film film);
    }
}
