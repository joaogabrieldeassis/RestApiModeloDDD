using RestApiModeloDDD.Infrastructure.CrossCuting.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiModeloDDD.Infrastructure.CrossCuting.Mapper
{
    public class MapperEntity<T> : IMapperEntity<T> where T : class
    {
        public T MapperDtoEntity(T entityMapper)
        {
            throw new NotImplementedException();
        }

        public T MapperEntityDto(T entityMapper)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> MapperListEntityDto(IEnumerable<T> entitysDtos)
        {
            throw new NotImplementedException();
        }
    }
}
