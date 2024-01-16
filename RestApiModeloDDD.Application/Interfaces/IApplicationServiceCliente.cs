using RestApiModeloDDD.Application.Dtos;


namespace RestApiModeloDDD.Application.Interfaces
{
    public interface IApplicationServiceCliente 
    {
        void Add(ClienteDto entityDto);
        void Update(ClienteDto entityDto);
        void Delete(ClienteDto entityDto);
        ClienteDto GetByID(Guid id);
        IEnumerable<ClienteDto> GetAll();

    }
}
