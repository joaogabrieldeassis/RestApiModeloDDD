using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiModeloDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiModeloDDD.Domain.Service
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        public ServiceProduto(IRepositoryBase<Produto> repositoryBase) 
            : base(repositoryBase)
        {
        }
    }
}
