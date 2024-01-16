using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Application.Interfaces.Mappers;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiModeloDDD.Application
{
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        private readonly IServiceCliente _serviceCliente;
        private readonly IMapperCliente _mapperCliente;

        public ApplicationServiceCliente(IServiceCliente serviceCliente, IMapperCliente mapperCliente)
        {
            _serviceCliente = serviceCliente;
            _mapperCliente = mapperCliente;
        }

        public void Add(ClienteDto entityDto)
        {
            var cliente = _mapperCliente.MapperDtoEntity(entityDto);
            _serviceCliente.Add(cliente);
        }

        public void Delete(ClienteDto entityDto)
        {
            var cliente = _mapperCliente.MapperDtoEntity(entityDto);
            _serviceCliente.Delete(cliente);
        }

        public IEnumerable<ClienteDto> GetAll()
        {
            var clientes = _serviceCliente.GetAll();
            return _mapperCliente.MapperListEntityDto(clientes);
        }

        public ClienteDto GetByID(Guid id)
        {
            var cliente = _serviceCliente.GetByID(id);
            return _mapperCliente.MapperEntityDto(cliente);
        }

        public void Update(ClienteDto entityDto)
        {
            var cliente = _mapperCliente.MapperDtoEntity(entityDto);
            _serviceCliente.Update(cliente);
        }
    }
}
