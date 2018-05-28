using System.Collections.Generic;

namespace Radix.Gateway.Domain.Repository
{
    public interface IBaseRepository<T>
        where T : class
    {
        void Insert(T entity);
        void Update(T entity, string id);
        long Delete(string id);
        IEnumerable<T> FindAll();
        T FindById(string id);
    }
}