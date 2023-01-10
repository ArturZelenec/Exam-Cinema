using Exam_Cinema.Data;
using Exam_Cinema.Model;
using Exam_Cinema.Model.DTO;
using Exam_Cinema.Repository.IRepository;
using Exam_Cinema.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exam_Cinema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserFilmController : ControllerBase
    {
        private readonly FilmContext _db;
        private readonly IUserFilmRepository _userFilmRepo;
        private readonly ILibraryFilmRepository _libraryFilmRepo;
        private readonly IUserRepository _userRepo;
        private readonly IUserFilmAdapter _adapter;
        

        public UserFilmController(FilmContext db,
                                  IUserFilmRepository userFilmRepo,
                                  IUserFilmAdapter adapter,
                                  ILibraryFilmRepository libraryFilmRepo,
                                  IUserRepository userRepo)
                                  
        {
            _db = db;
            _userFilmRepo = userFilmRepo;
            _adapter = adapter;
            _libraryFilmRepo = libraryFilmRepo;
            _userRepo = userRepo;
           
        }

        /// <summary>
        /// Grazina visu imtu filmu istorija
        /// </summary>
        /// <returns></returns>
        //[HttpGet("GetAll")]
        //public ActionResult<List<GetUserFilmDto>> GetAction()
        //{
        //    var getUserFilmDtoList = _userFilmRepo.GetAll()
        //                                          .Select(userFilms => _adapter.Adapt(userFilms))
        //                                          .ToList();
        //    return getUserFilmDtoList;
        //}

        /// <summary>
        /// Grazina vieno kliento ziuretu filmu istorija
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("Get/{id:int}")]
        public ActionResult<GetUserFilmDto> GetUserFilmById(int id)
        {
            var userFilm = _userFilmRepo.Get(ub => ub.UserId == id);
            return _adapter.Adapt(userFilm);
        }

        /// <summary>
        /// Paimti filma is filmotekos
        /// </summary>
        /// <param name="createUserFilmDto">Parametrai: kas ima filma ir koki ima filma</param>
        /// <returns></returns>
        [HttpPost("TakeLibraryFilm")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<GetUserFilmDto> TakeLibraryFilm(CreateUserFilmkDto createUserFilmDto)
        {
            if (createUserFilmDto == null) return BadRequest();

            var libraryFilm = _libraryFilmRepo.Get(b => b.Id == createUserFilmDto.LibraryFilmId);
            if (libraryFilm == null) return NotFound("libraryFilm = null");

            //var canThisBookBeTaken = _libraryHelper.CanThisBookBeTaken(libraryFilm);
            //if (!canThisBookBeTaken.Answer) return NotFound(canThisBookBeTaken.Message);

            var getUserDto = _userRepo.Get(b => b.Id == createUserFilmDto.UserId);
            if (getUserDto == null) return NotFound("getUserDto = null");

            //var canThisUserTakeABook = _libraryHelper.CanThisUserTakeABook(getUserDto);
            //if (!canThisUserTakeABook.Answer) return NotFound(canThisUserTakeABook.Message);

            UserFilm newUserFilm = _adapter.Adapt(getUserDto, libraryFilm);
            _userFilmRepo.Create(newUserFilm);

            libraryFilm.IsTaken = true;
            _libraryFilmRepo.Update(libraryFilm);

            _userRepo.UpdateTakenLibraryFilms(getUserDto.UserId, +1);

            GetUserFilmDto getUserFilmDto = _adapter.Adapt(newUserFilm);

            return CreatedAtAction(nameof(GetUserFilmById), new { id = getUserFilmDto.UserId }, getUserFilmDto);
        }

        /// <summary>
        /// Graziname knyga i biblioteka
        /// </summary>
        /// <param name="id">bibliotekos knygos id</param>
        /// <returns></returns>
        //[HttpPut("ReturnLibraryBook/{id:int}")]
        //[ProducesResponseType(StatusCodes.Status201Created)]
        //public IActionResult ReturnLibraryBookById(int id)
        //{
        //    var userBook = _userFilmRepo.Get(b => b.Id == id);
        //    if (userBook == null) return NotFound("userBook == null");

        //    var libraryBook = _libraryFilmRepo.Get(b => b.Id == userBook.LibraryBookId);
        //    if (libraryBook == null) return NotFound("libraryBook == null");

        //    userBook.BookReturned = DateTime.Now;
        //    _userFilmRepo.Update(userBook);

        //    libraryBook.IsTaken = false;
        //    _libraryFilmRepo.Update(libraryBook);

        //    _userRepo.UpdateTakenLibraryBooks(userBook.UserId, -1);

        //    return NoContent();
        //}
    }
}
