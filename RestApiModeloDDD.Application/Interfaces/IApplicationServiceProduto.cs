using RestApiModeloDDD.Application.Dtos;

namespace RestApiModeloDDD.Application.Interfaces
{
    public interface IApplicationServiceProduto
    {
        void Add(ProdutoDto entityDto);
        void Update(ProdutoDto entityDto);
        void Delete(ProdutoDto entityDto);
        ProdutoDto GetByID(Guid id);
        IEnumerable<ProdutoDto> GetAll();
    }
}
