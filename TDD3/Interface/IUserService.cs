using System;
using System.Collections.Generic;
using System.Text;
using TDD3.Dto;

namespace TDD3.Interface
{
    public interface IUserService
    {
        List<UserDto> GetAll();
    }
}
