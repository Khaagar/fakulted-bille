using System;
using System.Collections.Generic;
using System.Text;
using abyNa3.Data;

namespace abyNa3.Service
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
        User GetUser(long id);

    }
}
