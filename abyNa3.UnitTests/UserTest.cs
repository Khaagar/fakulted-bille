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
        private static RepositoryMock<User> repositoryMock = new RepositoryMock<User>();
        private UserService _userService = new UserService(repositoryMock);
        private List<User> userDataMock = new List<User>{
                new User { Id = 0, UserName = "johndoe", Email = "john@doe", Password = "qweasdzxc" },
                new User { Id = 1, UserName = "harryPotter", Email = "parry.hotter@hogwart.com", Password = "12" }
            };
        public UserTest()
        {
        repositoryMock.FillData(userDataMock);
        }
        
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(4)]
        public void GetUsers_CheckReturnedListCount_ShouldFail(Int32 count)
        {
            // Arrange

            // Act
            var users = _userService.GetUsers().ToList();
            // Assert
            Assert.False(users.Count() == count);
        }

        [Theory]
        [InlineData(2)]
        public void GetUsers_CheckReturnedListCount_ShouldPass(Int32 count)
        {
            // Arrange

            // Act
            var users = _userService.GetUsers().ToList();
            // Assert
            Assert.True(users.Count() == count);
        }

        [Theory]
        [InlineData(0, "wrongUsername")]
        [InlineData(1, "usernameFromSpace")]
        public void GetUserById_HaveProperUsername_ShouldFail(Int32 id, string username )
        {
            // Arrange

            // Act
            var user = _userService.GetUser(id);
            // Assert
            Assert.NotEqual(user.UserName, username);
        }

        [Theory]
        [InlineData(0, "johndoe")]
        [InlineData(1, "harryPotter")]
        public void GetUserById_HaveProperUsername_ShouldPass(Int32 id, string username)
        {
            // Arrange

            repositoryMock.FillData(userDataMock);
            // Act
            var user = _userService.GetUser(id);
            // Assert
            Assert.Equal(user.UserName, username);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        public void GetUserById_UserExist_ShouldFail(Int32 id)
        {
            // Arrange

            repositoryMock.FillData(userDataMock);
            // Act
            var user = _userService.GetUser(id);
            // Assert
            Assert.False(user != null);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        public void GetUserById_UserExist_ShouldPass(Int32 id)
        {
            // Arrange

            repositoryMock.FillData(userDataMock);
            // Act
            var user = _userService.GetUser(id);
            // Assert
            Assert.True(user != null);
        }
    }
}
