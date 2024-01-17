using Microsoft.EntityFrameworkCore;
using RestApiModeloDDD.Domain.Entitys;

namespace RestApiModeloDDD.Infrastructure.Data
{

    public class DDDSqlContext : DbContext
    {
        public DDDSqlContext() { }

        public DDDSqlContext(DbContextOptions<DDDSqlContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DDDSqlContext).Assembly);
        }
    }

}
