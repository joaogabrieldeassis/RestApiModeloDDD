using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;

namespace RestApiModeloDDD.Domain.Service
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> _repositoryBase;

        public ServiceBase(IRepositoryBase<T> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public void Add(T entity)
        {
            _repositoryBase.Add(entity);
        }

        public void Delete(T entity)
        {
            _repositoryBase.Delete(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _repositoryBase.GetAll();
        }

        public T GetByID(Guid id)
        {
            return _repositoryBase.GetByID(id);
        }

        public void Update(T entity)
        {
            _repositoryBase.Update(entity);
        }
    }
}
