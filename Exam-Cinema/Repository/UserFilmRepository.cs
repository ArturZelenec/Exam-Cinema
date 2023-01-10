using Exam_Cinema.Data;
using Exam_Cinema.Model;
using Exam_Cinema.Repository.IRepository;

namespace Exam_Cinema.Repository
{
    public class UserFilmRepository : Repository<UserFilm>, IUserFilmRepository
    {
        private readonly FilmContext _db;

        public UserFilmRepository(FilmContext db) : base(db)
        {
            _db = db;
        }

        public UserFilm Update(UserFilm userFilm)
        {
            userFilm.Updated = DateTime.Now;
            _db.UserFilms.Update(userFilm);
            _db.SaveChanges();
            return userFilm;
        }

        //public void UpdateDaysLate(int userFilmId, int daysLate)
        //{
        //    var userBook = _db.UserFilms.First(u => u.Id == userFilmId);
        //    //userFilms.DaysLate = daysLate;
        //    _db.UserFilms.Update(userBook);
        //    _db.SaveChanges();
        //}

    }
}
