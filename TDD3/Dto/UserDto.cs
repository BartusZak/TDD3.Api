using System;
using System.Collections.Generic;
using System.Text;

namespace TDD3.Dto
{
    public class UserDto
    {
        public long Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }

        public override bool Equals(object obj)
        {
            var user = (UserDto)obj;

            return user.Email == Email && user.Login == Login && Id == user.Id;

        }

        public override int GetHashCode()
        {
            return new { Login, Email, Id }.GetHashCode();
        }
    }
}
