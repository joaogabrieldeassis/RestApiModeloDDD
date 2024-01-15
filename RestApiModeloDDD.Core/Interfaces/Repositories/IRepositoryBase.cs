
namespace RestApiModeloDDD.Domain.Core.Interfaces.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        void Add(T entity); 
        void Update(T entity);
        void Delete(T entity);
        T GetByID(Guid id);
        IEnumerable<T> GetAll();
    }
}
