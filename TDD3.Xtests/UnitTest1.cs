using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using TDD3.Dto;
using TDD3.Interface;
using TDD3.Service;
using Xunit;


namespace TDD3.Xtests
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldReturnListOfUsers()
        {
            //arrange
            var users = new List<User>() {
                new User { Login="asd",Email="asd@m.pl", Password="asd",Id=1},
                new User{Login="afsd",Email="asfd@m.pl", Password="asfd",Id= 2} };

            var expected = new List<UserDto> {
                new UserDto { Login="asd",Email="asd@m.pl",Id=1},
                new UserDto{Login="afsd",Email="asfd@m.pl",Id= 2} };

            var _userRepository = new Mock<IRepository<User>>();
            _userRepository.Setup(x => x.GetAll()).Returns(users.AsQueryable());
            var _userService = new UserService(_userRepository.Object);

            var userController = new UserController(_userService); 

            //act
            List<UserDto> result = userController.Get();

            //assert
            Assert.Equal<UserDto>(expected, result);
        }


    }
}
