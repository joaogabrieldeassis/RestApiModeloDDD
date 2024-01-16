using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Domain.Entitys;

namespace RestApiModeloDDD.Application.Interfaces.Mappers
{
    public interface IMapperProduto
    {
        Produto MapperDtoEntity(ProdutoDto entityMapper);
        IEnumerable<ProdutoDto> MapperListEntityDto(IEnumerable<Produto> entitysDtos);
        ProdutoDto MapperEntityDto(Produto entityMapper);
    }
}
