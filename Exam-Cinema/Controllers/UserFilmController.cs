using Exam_Cinema.Data;
using Exam_Cinema.Model;
using Exam_Cinema.Model.DTO;
using Exam_Cinema.Repository.IRepository;
using Exam_Cinema.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

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
        /// <response code="200">Teisingai ivykdomas gavimas ir parodoma vieno filmo informacija</response>
        /// <response code="400">Blogas kreipimasis</response>
        /// <response code="404">Nerasta</response>
        /// <response code="500">Baisi klaida!</response>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("Get/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetUserFilmDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]


        public async Task<ActionResult<GetUserAllFilmsDTO>> GetUserFilmById(int id)
        {
            //var userFilm = await _userFilmRepo.Getdata_With_EagerLoading();
            var userFilm = await _userFilmRepo.GetAllAsync(x => x.UserId == id, new List<string> {"User","LibraryFilm"});

            return _adapter.Adapt(userFilm);

        }



        /// <summary>
        /// Paimti filma is filmotekos
        /// </summary>
        /// <response code="200">Teisingai ivykdomas gavimas ir parodoma vieno filmo informacija</response>
        /// <response code="400">Blogas kreipimasis</response>
        /// <response code="404">Nerasta</response>
        /// <response code="500">Baisi klaida!</response>
        /// <param name="createUserFilmDto">Parametrai: kas ima filma ir koki ima filma</param>
        /// <returns></returns>
        [HttpPost("TakeLibraryFilm")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetUserFilmDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<ActionResult<GetUserFilmDto>> TakeLibraryFilm(CreateUserFilmkDto createUserFilmDto)
        {
            if (createUserFilmDto == null) return BadRequest();

            var libraryFilm = await _libraryFilmRepo.GetAsync(b => b.Id == createUserFilmDto.LibraryFilmId);
            if (libraryFilm == null) return NotFound("libraryFilm = null");

            

            var getUserDto = await _userRepo.GetAsync(b => b.Id == createUserFilmDto.UserId);
            if (getUserDto == null) return NotFound("getUserDto = null");

            

            UserFilm newUserFilm = _adapter.Adapt(getUserDto, libraryFilm);
            _userFilmRepo.CreateAsync(newUserFilm);

            libraryFilm.IsTaken = true;
            await _libraryFilmRepo.UpdateAsync(libraryFilm);

            _userRepo.UpdateTakenLibraryFilms(getUserDto.UserId, +1);

            GetUserFilmDto getUserFilmDto = _adapter.Adapt(newUserFilm);

            return CreatedAtAction(nameof(GetUserFilmById), new { id = getUserFilmDto.UserId }, getUserFilmDto);
        }

    }
}
