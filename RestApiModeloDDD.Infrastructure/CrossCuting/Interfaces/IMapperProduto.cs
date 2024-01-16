using RestApiModeloDDD.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiModeloDDD.Infrastructure.CrossCuting.Interfaces
{
    public interface IMapperProduto : IMapperEntity<ProdutoDto>
    {
    }
}
