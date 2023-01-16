using Exam_Cinema.Data;
using Exam_Cinema.Model;
using Exam_Cinema.Model.DTO;
using Exam_Cinema.Repository.IRepository;
using Exam_Cinema.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace Exam_Cinema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryFilmController : ControllerBase
    {
        private readonly FilmContext _db;
        private readonly ILibraryFilmAdapter _adapter;
        private readonly ILibraryFilmRepository _libraryFilmRepo;

        public LibraryFilmController(FilmContext db, ILibraryFilmRepository libraryFilmRepository, ILibraryFilmAdapter adapter)
        {
            _db = db;
            _libraryFilmRepo = libraryFilmRepository;
            _adapter = adapter;
        }

        /// <summary>
        /// Grazina visus filmus is filmotekos
        /// </summary>
        /// <returns>Grazina rezultata</returns>
        /// /// <response code="200">Teisingai ivykdomas gavimas ir parodoma visus filmus</response>
        /// <response code="500">Baisi klaida!</response>
        [HttpGet("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetLibraryFilmDto>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<ActionResult<List<GetLibraryFilmDto>>> GetLibraryFilms()
        {
            var allLibraryFilms = await _libraryFilmRepo.Getdata_With_EagerLoading();
            return Ok(_adapter.Adapt(allLibraryFilms));
        }

        /// <summary>
        /// Grazina viena filma, esancia filmotekoje, pagal filmotekos filmo id
        /// </summary>
        /// <param name="id">filmotekos filmo id</param>
        /// <returns>Grazina rezultata</returns>
        /// <response code="200">Teisingai ivykdomas gavimas ir parodoma vieno filmo informacija</response>
        /// <response code="400">Blogas kreipimasis</response>
        /// <response code="404">Nerasta</response>
        /// <response code="500">Baisi klaida!</response>
        [HttpGet("Get/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetLibraryFilmDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<ActionResult<GetLibraryFilmDto>> GetLibraryFilmById(int id)
        {
            var libraryFilm = await _libraryFilmRepo.Getdata_With_EagerLoading();
            if (libraryFilm == null) return NotFound();
            libraryFilm = libraryFilm.Where(x => x.Id == id);
            return Ok(_adapter.Adapt(libraryFilm));


            //var libraryFilm = await _libraryFilmRepo.GetAsync(lb => lb.Id == id);
            //if (libraryFilm == null) return NotFound();
            //return Ok(_adapter.Adapt(libraryFilm));
        }

        /// <summary>
        /// Pridedame viena nauja filma i filmoteka
        /// </summary>
        /// <param name="createLibraryFilmDto">Filmo duomenys</param>
        /// <returns>Grazina rezultata</returns>
        /// <response code="201">Sekmingai sukuriama nauja filma</response>
        /// <response code="400">Blogas kreipimasis</response>
        /// <response code="401">Bando prisijungti ne adminas</response>
        /// <response code="500">Baisi klaida!</response>
        [HttpPost("Add")]
        [Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<ActionResult<GetLibraryFilmDto>> AddLibraryFilm(CreateLibraryFilmDto createLibraryFilmDto)
        {
            if (createLibraryFilmDto == null || createLibraryFilmDto.FilmISBN == "") return BadRequest();

            var film = _db.Films.FirstOrDefault(b => b.ISBN == createLibraryFilmDto.FilmISBN);
            if (film == null) return NotFound();

            LibraryFilm newLibraryFilm = _adapter.Adapt(createLibraryFilmDto.FilmISBN, film);
            await _libraryFilmRepo.CreateAsync(newLibraryFilm);
            GetLibraryFilmDto getLibraryFilmDto = _adapter.Adapt(newLibraryFilm);

            return CreatedAtAction(nameof(GetLibraryFilmById), new { id = newLibraryFilm.Id }, getLibraryFilmDto);
        }

        /// <summary>
        /// Pridedamas norimas kiekis filmu i filmoteka
        /// </summary>
        /// <param name="libraryFilmDto">filmo duomenys</param>
        /// <param name="count">norimas kiekis</param>
        /// <returns></returns>
        //[HttpPost("AddMany/{count:int}")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //public ActionResult AddManyLibraryFilms(CreateLibraryFilmDto libraryFilmDto, int count)
        //{
        //    if (libraryFilmDto == null || libraryFilmDto.FilmISBN == "" || count <= 0) return BadRequest();

        //    var film = _db.Films.FirstOrDefault(b => b.ISBN == libraryFilmDto.FilmISBN);
        //    if (film == null) return NotFound();

        //    for (int i = 0; i < count; i++)
        //    {
        //        LibraryFilm newLibraryFilm = _adapter.Adapt(libraryFilmDto.FilmISBN, film);
        //        _libraryFilmRepo.Create(newLibraryFilm);
        //    }

        //    return Ok();
        //}

        /// <summary>
        /// Istriname filma is filmotekos pagal filmotekos filmo id
        /// </summary>
        /// <param name="id">filmotekos filmo id</param>
        /// <returns>Grazina rezultata</returns>
        /// <response code="204">Sekmingai istrinta</response>
        /// <response code="400">Blogas kreipimasis</response>
        /// <response code="401">Bando prisijungti ne adminas</response>
        /// <response code="404">Nerasta</response>
        /// <response code="500">Baisi klaida!</response>
        [HttpDelete("Delete/{id:int}")]
        [Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteLibraryFilmById(int id)
        {
            var libraryFilm = await _libraryFilmRepo.GetAsync(lb => lb.Id == id);
            if (libraryFilm == null) return NotFound();

            while (_db.UserFilms.FirstOrDefault(ub => ub.LibraryFilmId == id) != null)
            {
                var userFilm = _db.UserFilms.First(ub => ub.LibraryFilmId == id);
                _db.UserFilms.Remove(userFilm);
                _db.SaveChanges();
            }

            await _libraryFilmRepo.RemoveAsync(libraryFilm);

            return NoContent();
        }
    }
}
