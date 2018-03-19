using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD3.Interface
{
    public interface IRepository<T> where T : Entity
    {
        IQueryable<User> GetAll();
    }
}
