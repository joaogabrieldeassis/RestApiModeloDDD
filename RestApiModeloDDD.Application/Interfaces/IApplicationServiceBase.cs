
namespace RestApiModeloDDD.Application.Interfaces
{
    public interface IApplicationServiceBase<T> where T : class
    {
        void Add(T entityDto);
        void Update(T entityDto);
        void Delete(T entityDto);
        T GetByID(Guid id);
        IEnumerable<T> GetAll();
    }
}
