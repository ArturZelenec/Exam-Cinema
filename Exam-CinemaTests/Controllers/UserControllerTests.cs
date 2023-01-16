using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exam_Cinema.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Microsoft.Extensions.Logging;
using Exam_Cinema.Repository.IRepository;
using Exam_Cinema.Model;
using Exam_Cinema.Services;
using Exam_Cinema.Services.IServices;
using Exam_Cinema.Model.DTO;

namespace Exam_Cinema.Controllers.Tests
{
    [TestClass()]
    public class UserControllerTests
    {
        [TestMethod()]
        public void LoginTest()
        {
            // Arrange
            //var logger = new Mock<ILogger<UserController>>();
            //var userService = new Mock<IUserService>();

            //var fake_username = "fake_username";
            //var fake_password = "fake_password";
            //var fake_user = new User { Id = 1, Name = fake_username, Role = "admin" };

            //Mock<IUserRepository> mockUserRepository = new Mock<IUserRepository>();
            //mockUserRepository.Setup(x => x.TryLogin(fake_username, fake_password, out fake_user)).Returns(true);


            //IJwtService jwtService = new JwtService(mockConfiguration.Object);

            //// Act
            //var result = new UserController(mockUserRepository.Object, userService.Object, jwtService, logger.Object);
            //var actual = result.Login(new LoginRequest { UserName = fake_username, Password = fake_password });

            //// Assert
            //Assert.IsInstanceOfType(actual, typeof(UnauthorizedObjectResult));
        }
    }
}