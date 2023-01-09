using Exam_Cinema.Model;

namespace Exam_Cinema.Repository.IRepository
{
    public interface ILibraryFilmRepository : IRepository<LibraryFilm>
    {
        LibraryFilm Update(LibraryFilm libraryFilm);
    }
}
