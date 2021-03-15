using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimManagement.Core.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T GetById(object id);

        T Insert(T obj);

        bool Update(T obj);

        bool Delete(object id);

        bool Delete(T obj);

        void Save();
    }
}