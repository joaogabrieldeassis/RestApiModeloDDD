using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;
using RestApiModeloDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiModeloDDD.Infrastructure.Data.Repositorys
{
    public class RepositoryCliente : RepositoryBase<Cliente>,IRepositoryCliente
    {
        protected RepositoryCliente(SqlContext context)
            : base(context)
        {
        }

    }
}
