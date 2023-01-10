﻿using Exam_Cinema.Data;
using Exam_Cinema.Model;
using Exam_Cinema.Model.DTO;
using Exam_Cinema.Repository.IRepository;
using Exam_Cinema.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        /// <returns></returns>
        [HttpGet("GetAll")]
        public ActionResult<List<GetLibraryFilmDto>> GetLibraryFilms()
        {
            var allLibraryFilms = _libraryFilmRepo.GetAll();
            return Ok(_adapter.Adapt(allLibraryFilms));
        }

        /// <summary>
        /// Grazina viena filma, esancia filmotekoje, pagal filmotekos filmo id
        /// </summary>
        /// <param name="id">filmotekos filmo id</param>
        /// <returns></returns>
        [HttpGet("Get/{id:int}")]
        public ActionResult<GetLibraryFilmDto> GetLibraryFilmById(int id)
        {
            var libraryFilm = _libraryFilmRepo.Get(lb => lb.Id == id);
            if (libraryFilm == null) return NotFound();
            return Ok(_adapter.Adapt(libraryFilm));
        }

        /// <summary>
        /// Pridedame viena nauja filma i filmoteka
        /// </summary>
        /// <param name="createLibraryFilmDto">Filmo duomenys</param>
        /// <returns></returns>
        [HttpPost("Add")]
        [Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<GetLibraryFilmDto> AddLibraryFilm(CreateLibraryFilmDto createLibraryFilmDto)
        {
            if (createLibraryFilmDto == null || createLibraryFilmDto.FilmISBN == "") return BadRequest();

            var film = _db.Films.FirstOrDefault(b => b.ISBN == createLibraryFilmDto.FilmISBN);
            if (film == null) return NotFound();

            LibraryFilm newLibraryFilm = _adapter.Adapt(createLibraryFilmDto.FilmISBN, film);
            _libraryFilmRepo.Create(newLibraryFilm);
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
        /// <returns></returns>
        [HttpDelete("Delete/{id:int}")]
        [Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult DeleteLibraryFilmById(int id)
        {
            var libraryFilm = _libraryFilmRepo.Get(lb => lb.Id == id);
            if (libraryFilm == null) return NotFound();

            while (_db.UserFilms.FirstOrDefault(ub => ub.LibraryFilmId == id) != null)
            {
                var userFilm = _db.UserFilms.First(ub => ub.LibraryFilmId == id);
                _db.UserFilms.Remove(userFilm);
                _db.SaveChanges();
            }

            _libraryFilmRepo.Remove(libraryFilm);

            return NoContent();
        }
    }
}
