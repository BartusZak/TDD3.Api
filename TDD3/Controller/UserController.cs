using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using TDD3.Dto;
using TDD3.Interface;

namespace TDD3
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public List<UserDto> Get()
        {
            var users = _userService.GetAll();

            return users;
        }
    }
}
