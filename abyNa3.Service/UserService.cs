using System;
using abyNa3.Data;
using abyNa3.Repo;
using System.Collections.Generic;

namespace abyNa3.Service
{
    public class UserService: IUserService
    {
        private IRepository<User> userRepository;

        public UserService(IRepository<User> userRepository)
        {
            this.userRepository = userRepository;
        }

        public IEnumerable<User> GetUsers()
        {
            return userRepository.GetAll();
        }

        public User GetUser(long id)
        {
            return userRepository.Get(id);
        }

    }
}
