using Exam_Cinema.Data;
using Exam_Cinema.Model;
using Exam_Cinema.Model.DTO;
using Exam_Cinema.Repository.IRepository;
using Exam_Cinema.Services.IServices;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Text;

namespace Exam_Cinema.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly FilmContext _db;
        private readonly IPasswordService _passwordService;
        private readonly IJwtService _jwtService;
        private readonly LoginResponse _emptyTokenAndNullUser = new LoginResponse
        {
            Token = "",
            User = null
        };

        public UserRepository(FilmContext db, IConfiguration conf, IPasswordService passwordService, IJwtService jwtService)
        {
            _db = db;
            _passwordService = passwordService;
            _jwtService = jwtService;
        }

        public async Task<bool> IsUniqueUserAsync(string username)
        {
            var isUniq = await _db.Users.AnyAsync(u => u.Username == username); //????? !_db
            if (isUniq == null)
            {
                return true;
            }
            return false;
        }
        public async Task<LoginResponse> LoginAsync(LoginRequest loginRequest)
        {
            var inputPastwordBytes = Encoding.UTF8.GetBytes(loginRequest.Password);
            var user = await _db.Users.FirstOrDefaultAsync(u => u.Username.ToLower() == loginRequest.Username.ToLower());

            if (user == null) return _emptyTokenAndNullUser;

            if (!_passwordService.VerifyPasswordHash(loginRequest.Password, user.PasswordHash, user.PasswordSalt)) return _emptyTokenAndNullUser;

            var token = _jwtService.GetJwtToken(user.Id, user.Role);

            LoginResponse loginResponse = new()
            {
                Token = token,
                User = new RegistrationResponse()
                {
                    Id = user.Id,
                    Username = user.Username,
                    FullName = user.FullName,
                    Role = user.Role
                }
            };

            return loginResponse;
        }

        public async Task<RegistrationResponse> RegisterAsync(RegistrationRequest registrationRequest)
        {
            _passwordService.CreatePasswordHash(registrationRequest.Password, out byte[] hash, out byte[] salt);

            User user = new()
            {
                Username = registrationRequest.Username,
                PasswordHash = hash,
                PasswordSalt = salt,
                FullName = registrationRequest.FullName,
                Role = registrationRequest.Role,
                Created = DateTime.Now,
                Updated = DateTime.Now
            };

            RegistrationResponse registrationResponse = new()
            {
                Username = registrationRequest.Username,
                FullName = registrationRequest.FullName,
                Role = registrationRequest.Role
            };

            _db.Users.Add(user);
            await _db.SaveChangesAsync();

            return registrationResponse;
        }

        public async Task<List<GetUserDto>> GetAllAsync(Expression<Func<User, bool>>? filter = null)
        {
            IQueryable<User> users = _db.Users;
            if (filter != null) users = _db.Users.Where(filter);

            var userDto = new List<GetUserDto>();
            foreach (var user in users)
            {
                userDto.Add(new GetUserDto()
                {
                    UserId = user.Id,
                    FullName = user.FullName,
                    Role = user.Role,
                    TakenLibraryFilms = user.TakenFilms
                });

            }
            return userDto;
        }

        public async Task<GetUserDto> GetAsync(Expression<Func<User, bool>> filter)
        {
            User user = await _db.Users.Where(filter).FirstOrDefaultAsync();
            var userDto = new GetUserDto()
            {
                UserId = user.Id,
                FullName = user.FullName,
                Role = user.Role,
                TakenLibraryFilms = user.TakenFilms,
                //FilmsNotReturnedInTime = user.FilmsNotReturnedInTime,
                //TotalDebt = user.TotalDebt
            };
            return userDto;
        }

        public async Task UpdateTakenLibraryFilms(int userId, int modifier)
        {
            User user = _db.Users.First(u => u.Id == userId);
            user.TakenFilms += modifier;
            _db.Users.Update(user);
            await _db.SaveChangesAsync();
        }

        //public void UpdateBooksNotReturnedInTimeAndTotalDebt(int userId, int booksNotReturnedInTime, double totalDebt)
        //{
        //    User user = _db.Users.First(u => u.Id == userId);
        //    user.BooksNotReturnedInTime = booksNotReturnedInTime;
        //    user.TotalDebt = totalDebt;
        //    _db.Users.Update(user);
        //    _db.SaveChanges();
        //}

    }
}
