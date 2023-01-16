using Exam_Cinema.Data;
using Exam_Cinema.Model;
using Exam_Cinema.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Exam_Cinema.Repository
{
    public class UserFilmRepository : Repository<UserFilm>, IUserFilmRepository
    {
        private readonly FilmContext _db;
        private readonly IHttpContextAccessor _httpContextAccessor; //////////////////////////////
        

        public UserFilmRepository(FilmContext db, IHttpContextAccessor httpContextAccessor) : base(db) //////////////////////////////////////
        {
            _db = db;
            _httpContextAccessor = httpContextAccessor;
        }
        
        public async Task<UserFilm> UpdateAsync(UserFilm userFilm)
        {
            userFilm.Updated = DateTime.Now;
            _db.UserFilms.Update(userFilm);
            await _db.SaveChangesAsync();
            return userFilm;
        }

        //egerlouding
        public async Task<IEnumerable<UserFilm>> Getdata_With_EagerLoading()
        {
            //var currentUserId = int.Parse(_httpContextAccessor.HttpContext.User.Identity.Name);  //////////////////////////////////////////
            var duomenys = await _db.UserFilms
            .Include(f => f.User)
            //.Include(f => f.User).Where(x => x.UserId == currentUserId) ////////////////////////////////////////////
            .Include(f => f.LibraryFilm)
            .ThenInclude(f => f.Film)
            .ToListAsync();

            return duomenys;

        }

    }
}
