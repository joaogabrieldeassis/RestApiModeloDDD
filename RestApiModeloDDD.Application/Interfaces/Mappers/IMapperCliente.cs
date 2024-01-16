using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Domain.Entitys;

namespace RestApiModeloDDD.Application.Interfaces.Mappers
{
    public interface IMapperCliente
    {
        Cliente MapperDtoEntity(ClienteDto entityMapper);
        IEnumerable<ClienteDto> MapperListEntityDto(IEnumerable<Cliente> entitysDtos);
        ClienteDto MapperEntityDto(Cliente entityMapper);
    }
}
