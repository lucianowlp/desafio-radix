using Radix.Gateway.Domain;
using System.Collections.Generic;

namespace Radix.Gateway.Infra.Data.Repository
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : class
    {
        public long Delete(string id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> FindAll()
        {
            throw new System.NotImplementedException();
        }

        public T FindById(string id)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(T entity, string id)
        {
            throw new System.NotImplementedException();
        }
    }
}
