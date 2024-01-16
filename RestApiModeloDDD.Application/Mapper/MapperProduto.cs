using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces.Mappers;
using RestApiModeloDDD.Domain.Entitys;

namespace RestApiModeloDDD.Application.Mapper
{
    public class MapperProduto : IMapperProduto
    {
        public Produto MapperDtoEntity(ProdutoDto entityMapper)
        {
            return new Produto
            {
                Nome = entityMapper.Nome,
                Id = entityMapper.Id,
                Valor = entityMapper.Valor
            };
        }

        public ProdutoDto MapperEntityDto(Produto entityMapper)
        {
            return new ProdutoDto
            {
                Nome = entityMapper.Nome,
                Id = entityMapper.Id,
                Valor = entityMapper.Valor
            };
        }

        public IEnumerable<ProdutoDto> MapperListEntityDto(IEnumerable<Produto> entitysDtos)
        {
            return entitysDtos.Select(c =>

             new ProdutoDto
             {
                 Nome = c.Nome,
                 Id = c.Id,
                 Valor = c.Valor
             });
        }
    }
}
