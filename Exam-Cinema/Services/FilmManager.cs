using Exam_Cinema.Data;
using Exam_Cinema.Model.DTO;
using Exam_Cinema.Services.IServices;

namespace Exam_Cinema.Services
{
    public class FilmManager : IFilmManager
    {
        private readonly IFilmWrapper _wrapper;
        private readonly IFilmSet _context;

        public FilmManager(IFilmWrapper wrapper, IFilmSet context)
        {
            _wrapper = wrapper;
            _context = context;
        }
        public List<GetFilmDto> Get()
        {
            var sarasas = _context.Films;
            var dto = sarasas.Select(s => _wrapper.Bind(s)).ToList();
            return dto;
        }
    }
}
