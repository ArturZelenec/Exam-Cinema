using Exam_Cinema.Model;
using Exam_Cinema.Model.DTO;

namespace Exam_Cinema.Services.IServices
{
    public interface IUserFilmAdapter
    {
        public UserFilm Adapt(GetUserDto user, LibraryFilm libraryFilm);
        public GetUserFilmDto Adapt(UserFilm userFilm);
    }
}
