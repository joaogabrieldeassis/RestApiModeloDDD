using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RestApiModeloDDD.Application.Interfaces.Mappers;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Application;
using RestApiModeloDDD.Application.Mapper;
using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiModeloDDD.Domain.Service;
using RestApiModeloDDD.Infrastructure.CrossCuting.InjecaoDeDependencia;
using RestApiModeloDDD.Infrastructure.Data;
using RestApiModeloDDD.Infrastructure.Data.Repositorys;

namespace TestApiModeloDDD.API.ConfigurationProgram
{
    public static class ConfiguracaoDaProgram
    {
        public static void ConfiguracaoDaDI(this IServiceCollection service)
        {
            service.AddScoped<IRepositoryCliente, RepositoryCliente>();
            service.AddScoped<IRepositoryProduto, RepositoryProduto>();

            service.AddScoped<IServiceCliente, ServiceCliente>();
            service.AddScoped<IServiceProduto, ServiceProduto>();

            

            service.AddScoped<IMapperCliente, MapperCliente>();
            service.AddScoped<IMapperProduto, MapperProduto>();

            service.AddScoped<IApplicationServiceCliente, ApplicationServiceCliente>();
            service.AddScoped<IApplicationServiceProduto, ApplicationServiceProduto>();

            

            

            

            //ConfiguracaoDaInjecaoDeDependencia.ConfiguiDi(service);                  
        }        

        public static void ConfiguracaoSql(this IServiceCollection services, IConfiguration configuration)
        {
            var connection = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<DDDSqlContext>(x => x.UseSqlServer(connection));
        }
    }
}
