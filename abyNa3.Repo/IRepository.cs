using System;
using System.Collections.Generic;
using System.Text;
using abyNa3.Data;

namespace abyNa3.Repo
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(long id);
    }
}
