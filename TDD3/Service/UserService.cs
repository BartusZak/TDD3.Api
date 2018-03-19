using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TDD3.Dto;
using TDD3.Interface;

namespace TDD3.Service
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public List<UserDto> GetAll()
        {
            IQueryable<User> users = _userRepository.GetAll();
            var usersToReturn = new List<UserDto>();
            users.ToList().ForEach(x => {
                usersToReturn.Add(new UserDto
                {
                    Email = x.Email,
                    Id = x.Id,
                    Login = x.Login
                });
            });

            return usersToReturn;
        }
    }
}
