using RestApiModeloDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiModeloDDD.Infrastructure.CrossCuting.Interfaces
{
    public interface IMapperEntity<T> where T : class
    {
        T MapperDtoEntity(T entityMapper);
        IEnumerable<T> MapperListEntityDto(IEnumerable<T> entitysDtos);
        T MapperEntityDto(T entityMapper);
    }
}
