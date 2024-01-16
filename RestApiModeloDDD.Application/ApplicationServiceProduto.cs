using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Application.Interfaces.Mappers;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RestApiModeloDDD.Application
{
    public class ApplicationServiceProduto : IApplicationServiceProduto
    {
        private readonly IMapperProduto _mapperProduto;
        private readonly IServiceProduto _serviceProduto;

        public ApplicationServiceProduto(IMapperProduto mapperProduto, IServiceProduto serviceProduto)
        {
            _mapperProduto = mapperProduto;
            _serviceProduto = serviceProduto;
        }


        public void Add(ProdutoDto entityDto)
        {
            var produto = _mapperProduto.MapperDtoEntity(entityDto);
            _serviceProduto.Add(produto);
        }

        public void Delete(ProdutoDto entityDto)
        {
            var produto = _mapperProduto.MapperDtoEntity(entityDto);
            _serviceProduto.Delete(produto);
        }

        public IEnumerable<ProdutoDto> GetAll()
        {
           var produtos = _serviceProduto.GetAll();
            return _mapperProduto.MapperListEntityDto(produtos);
        }

        public ProdutoDto GetByID(Guid id)
        {
            var produto = _serviceProduto.GetByID(id);
            return _mapperProduto.MapperEntityDto(produto);
        }

        public void Update(ProdutoDto entityDto)
        {
            var produto = _mapperProduto.MapperDtoEntity(entityDto);
            _serviceProduto.Update(produto);
        }
    }
}
