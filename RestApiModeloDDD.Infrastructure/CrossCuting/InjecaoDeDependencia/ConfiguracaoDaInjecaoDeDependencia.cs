using Microsoft.Extensions.DependencyInjection;
using RestApiModeloDDD.Application;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Application.Interfaces.Mappers;
using RestApiModeloDDD.Application.Mapper;
using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiModeloDDD.Domain.Service;
using RestApiModeloDDD.Infrastructure.Data.Repositorys;


namespace RestApiModeloDDD.Infrastructure.CrossCuting.InjecaoDeDependencia
{
    public static class ConfiguracaoDaInjecaoDeDependencia
    {
        public static void ConfiguiDi(IServiceCollection service)
        {
            service.AddScoped<IApplicationServiceCliente, ApplicationServiceCliente>();
            service.AddScoped<IApplicationServiceProduto, ApplicationServiceProduto>();

            service.AddScoped<IServiceCliente, ServiceCliente>();
            service.AddScoped<IServiceProduto,ServiceProduto>();

            service.AddScoped<IRepositoryCliente, RepositoryCliente>();
            service.AddScoped<IRepositoryProduto, RepositoryProduto>();
            service.AddScoped<IServiceCliente, ServiceCliente>();

            service.AddScoped<IMapperCliente, MapperCliente>();
            service.AddScoped<IMapperProduto, MapperProduto>();
            
        }
    }
}
