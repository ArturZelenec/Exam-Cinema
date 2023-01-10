using Exam_Cinema.Data;
using Exam_Cinema.Model;
using Exam_Cinema.Model.DTO;
using Exam_Cinema.Repository.IRepository;
using Exam_Cinema.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Mime;

namespace Exam_Cinema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private readonly FilmContext _db;
        private readonly IFilmWrapper _wrapper;
        private readonly ILogger<FilmController> _logger;
        private readonly IFilmRepository _filmRepo;

        public FilmController(FilmContext db, IFilmWrapper wrapper, ILogger<FilmController> logger, IFilmRepository filmRepo)
        {
            _db = db;
            _wrapper = wrapper;
            _logger = logger;
            _filmRepo = filmRepo;
        }

        /// <summary>
        /// Uzklausia visu filmu sarasa is duomenu bazes
        /// </summary>
        /// <returns>Grazina rezultata</returns>
        /// <response code="200">Teisingai ivykdomas gavimas ir parodoma visus filmus</response>
        /// <response code="500">Baisi klaida!</response>
        [HttpGet("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetFilmDto>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<ActionResult<IEnumerable<GetFilmDto>>> GetAllFilms()
        {
            _logger.LogInformation("HttpGet AllFilmss() buvo iskvietas {0} ", DateTime.Now);
            try
            {
                var getAll = await _filmRepo.GetAllAsync();
                return Ok(getAll
                    .Select(film => _wrapper.Bind(film))
                    .ToList());
            }
            catch (Exception e)
            {
                _logger.LogError(e, "HttpGet AllFilms() nuluzo {0}", DateTime.Now);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Uzklausia filma is duomenu bazes pagal specifini isbn
        /// </summary>
        /// <param name="isbn">Uzklausiamos filmo isbn</param>
        /// <returns>Grazina rezultata</returns>
        /// <response code="200">Teisingai ivykdomas gavimas ir parodoma vieno filmo informacija</response>
        /// <response code="400">Blogas kreipimasis</response>
        /// <response code="404">Nerasta</response>
        /// <response code="500">Baisi klaida!</response>
        [HttpGet("Get/{isbn}", Name = "GetFilm")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetFilmDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<ActionResult<GetFilmDto>> GetFilmByISBN(string isbn)
        {
            _logger.LogInformation("HttpGet GetFilmByISBN(isbn = {0}) buvo iskvietas {1} ", isbn, DateTime.Now);
            try
            {
                if (isbn == "")
                {
                    _logger.LogError("HttpGet GetFilmByISBN(isbn = {0}) su blogu isbn {1} ", isbn, DateTime.Now);
                    return NotFound(); // return BadRequest();
                }

                var film = await _filmRepo.GetAsync(b => b.ISBN == isbn);
                if (film == null)
                {
                    _logger.LogError("HttpGet GetFilmByISBN(isbn = {0}) filmas su tokiu isbn nerastas {1} ", isbn, DateTime.Now);
                    return NotFound();
                }

                return Ok(_wrapper.Bind(film));
            }
            catch (Exception e)
            {
                _logger.LogError(e, "HttpGet GetFilmByISBN(isbn = {0}) nuluzo {1} ", isbn, DateTime.Now);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }


        /// <summary>
        /// Sukuria nauja filma, gali sukurti tik adminas
        /// </summary>
        /// <param name="createFilmDto">Filmo objektas</param>
        /// <returns>Grazina rezultata</returns>
        /// <response code="201">Sekmingai sukuriama nauja filma</response>
        /// <response code="400">Blogas kreipimasis</response>
        /// <response code="401">Bando prisijungti ne adminas</response>
        /// <response code="500">Baisi klaida!</response>
        [HttpPost("Create")]
        [Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(IEnumerable<CreateFilmDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<ActionResult<CreateFilmDto>> CreateFilm(CreateFilmDto createFilmDto)
        {
            _logger.LogInformation("HttpPost CreateFilm(createFilmDto = {0}) buvo iskvietas {1} ", JsonConvert.SerializeObject(createFilmDto), DateTime.Now);
            try
            {
                if (createFilmDto == null)
                {
                    _logger.LogError("HttpPost CreateBook(createBookDto) createBookDto objektas == null {1} ", DateTime.Now);
                    return BadRequest();
                }

                Film newFilm = _wrapper.Bind(createFilmDto);
                _filmRepo.CreateAsync(newFilm);

                return CreatedAtAction(nameof(GetFilmByISBN), new { isbn = newFilm.ISBN }, createFilmDto);

            }
            catch (Exception e)
            {
                _logger.LogError(e, "HttpPost CreateBook(createBookDto = {0}) nuluzo {1} ", JsonConvert.SerializeObject(createFilmDto), DateTime.Now);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }


        /// <summary>
        /// Filmu filtravimas pagal pavadinima arba reziseriu
        /// </summary>
        /// <param name="title">Pavadinimo filtras</param>
        /// <param name="author">Autoriaus filtras</param>
        /// <returns>Grazina rezultata</returns>
        /// <response code="200">Grazina visus rastus filmus pagal ivestus filtrus</response>
        /// <response code="500">Baisi klaida!</response>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetFilmDto>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("Filter")]
        public async Task<ActionResult<List<GetFilmDto>>> Filter([FromQuery] FilterFilmRequestDto req)
        {
            _logger.LogInformation("HttpGet Filter(FilterFilmsRequestDto req = {0}) buvo iskviestas {1} ", req, DateTime.Now);
            try
            {
                var films = await _filmRepo.GetAllAsync(b => b.Title.Contains(req.Title != null ? req.Title : "") &&
                                                  b.Director.Contains(req.Director != null ? req.Director : ""));

                var filmsDto = new List<GetFilmDto>();
                if (films != null)
                {
                    foreach (var film in films)
                    {
                        filmsDto.Add(_wrapper.Bind(film));
                    }
                }
                return Ok(filmsDto);
            }
            catch (Exception e)
            {
                _logger.LogError("HttpGet Filter(FilterFilmsRequestDto req = {0}) nuluzo {1} ", req, DateTime.Now);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }


        /// <summary>
        /// Atnaujiname filma, siusdami filmo objekta, gali atnaujinti tik adminas
        /// </summary>
        /// <param name="filmUpdated">Filmo objektas su visais atnaujintais laukais</param>
        /// <returns></returns>
        /// <response code="204">Sekmingai atnaujintas filmas</response>
        /// <response code="400">Blogas kreipimasis</response>
        /// <response code="401">Bando prisijungti ne adminas</response>
        /// <response code="500">Baisi klaida!</response>
        [HttpPut("Update")]
        [Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(IEnumerable<CreateFilmDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateFilm(UpdateFilmDto filmUpdated)
        {
            _logger.LogInformation("HttpPut UpdateFilm(filmUpdated = {0}) buvo iskvietas {1} ", JsonConvert.SerializeObject(filmUpdated), DateTime.Now);
            try
            {
                if (filmUpdated == null)
                {
                    _logger.LogError("HttpPut UpdateFilm(filmUpdated) filmUpdated objektas == null {1} ", DateTime.Now);
                    return BadRequest();
                }

                Film film = _wrapper.Bind(filmUpdated);
                await _filmRepo.UpdateAsync(film);
                return NoContent();

            }
            catch (Exception e)
            {
                _logger.LogError(e, "HttpPut UpdateFilm(filmUpdated = {0}) nuluzo {1} ", JsonConvert.SerializeObject(filmUpdated), DateTime.Now);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }


        /// <summary>
        /// Trinamas filmas is duomenu bazes pagal specifini isbn, gali istrinti tik adminas
        /// </summary>
        /// <param name="isbn">Norimo istrinti filmo isbn</param>
        /// <returns>Grazina rezultata</returns>
        /// <response code="204">Sekmingai istrinta</response>
        /// <response code="400">Blogas kreipimasis</response>
        /// <response code="401">Bando prisijungti ne adminas</response>
        /// <response code="404">Nerasta</response>
        /// <response code="500">Baisi klaida!</response>
        [HttpDelete("Delete/{isbn}")]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ActionResult))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeleteFilmByISBN(string isbn)
        {
            _logger.LogInformation("HttpDelete DeleteFilmByISBN(isbn = {0}) buvo iskvietas {1} ", isbn, DateTime.Now);
            try
            {
                var film = await _filmRepo.GetAsync(b => b.ISBN == isbn);
                if (film == null)
                {
                    _logger.LogError("HttpDelete DeleteFilmByISBN(isbn = {0}) filmas su tokiu isbn nerastas {1} ", isbn, DateTime.Now);
                    return NotFound();
                }

                await _filmRepo.RemoveAsync(film);
                //_db.Books.Remove(book);
                //_db.SaveChanges();

                return NoContent();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "HttpDelete DeleteFilmByISBN(isbn = {0}) nuluzo {1} ", isbn, DateTime.Now);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

    }
}
