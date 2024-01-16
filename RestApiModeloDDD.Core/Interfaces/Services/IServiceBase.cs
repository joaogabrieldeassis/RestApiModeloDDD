using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiModeloDDD.Domain.Core.Interfaces.Services
{
    public interface IServiceBase<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetByID(Guid id);
        IEnumerable<T> GetAll();
    }
}
