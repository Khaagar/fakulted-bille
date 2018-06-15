using abyNa3.Data;
using abyNa3.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace abyNa3.UnitTests
{
    public class UserTest
    {
        private UserService _userService; 
        
        public UserTest()
        {
            var usersRespositoryMock = new RepositoryMock<User>();
            var userData = new List<User>{
                new User(0, "test", "test@test", "passtest"),
                new User(1, "tset", "tset@tset", "password")
            };
            usersRespositoryMock.FillData(userData);
            _userService = new UserService(usersRespositoryMock); 
        }


        [Fact]
        public void TestGetAllUsers()
        {
            // Arrange

            // Act
            var users = _userService.GetUsers().ToList();
            // Assert
            Assert.False(users.Count() == 3, "true");
            Assert.False(users.Count() == 0, "true");
            Assert.True(users.Count() == 2, "false");
            Assert.False(users.Count() == 1, "true");
        }

        [Fact]
        public void TestGetUserById()
        {
            // Arrange
            var userId = 1;
            // Act
            var user = _userService.GetUser(userId);
            // Assert
            Assert.False(user.UserName.Equals("test"), "false");
            Assert.False(user.UserName.Equals("test2"), "true");
        }
    }
}
