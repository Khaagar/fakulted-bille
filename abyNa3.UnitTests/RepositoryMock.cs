using System;
using System.Collections.Generic;
using abyNa3.Data;
using abyNa3.Repo;
using System.Linq;

namespace abyNa3.UnitTests
{
    public class RepositoryMock<T> : IRepository<T> where T : User
    {
        public List<T> userMock = new List<T>();

        public T Get(long id)
        {
            return userMock.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return userMock;
        }

        public void FillData(List<T> data)
        {
            userMock.Clear();
            userMock.AddRange(data);
        }
    }
}
