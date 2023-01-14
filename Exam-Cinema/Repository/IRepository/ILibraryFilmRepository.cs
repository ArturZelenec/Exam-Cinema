using Exam_Cinema.Model;

namespace Exam_Cinema.Repository.IRepository
{
    public interface ILibraryFilmRepository : IRepository<LibraryFilm>
    {
        Task<IEnumerable<LibraryFilm>> Getdata_With_EagerLoading();
        Task<LibraryFilm> UpdateAsync(LibraryFilm libraryFilm);
    }
}
