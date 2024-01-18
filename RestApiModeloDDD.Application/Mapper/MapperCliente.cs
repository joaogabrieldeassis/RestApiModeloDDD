using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces.Mappers;
using RestApiModeloDDD.Domain.Entitys;

namespace RestApiModeloDDD.Application.Mapper
{
    public class MapperCliente : IMapperCliente
    {

        public Cliente MapperDtoEntity(ClienteDto entityMapper)
        {
            return new Cliente
            {
                Nome = entityMapper.Nome,
                SobreNome = entityMapper.Sobrenome,
                Email = entityMapper.Email,
            };
        }

        public ClienteDto MapperEntityDto(Cliente entityMapper)
        {
            return new ClienteDto
            {
                Id = entityMapper.Id,
                Email = entityMapper.Email,
                Sobrenome = entityMapper.SobreNome,
                Nome = entityMapper.Nome
            };
        }

        public IEnumerable<ClienteDto> MapperListEntityDto(IEnumerable<Cliente> entitysDtos)
        {
            return entitysDtos.Select(c =>
            new ClienteDto
            {
                Id = c.Id,
                Email = c.Email,
                Nome = c.Nome,
                Sobrenome = c.SobreNome

            });
        }
    }
}
