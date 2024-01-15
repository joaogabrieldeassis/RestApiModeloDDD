using Microsoft.EntityFrameworkCore;
using RestApiModeloDDD.Domain.Entitys;

namespace RestApiModeloDDD.Infrastructure.Data
{
    
        public class SqlContext : DbContext
        {
            public SqlContext() { }
            public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }



            public DbSet<Cliente> Clientes { get; set; }
            public DbSet<Produto> Produtos { get; set; }
            

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.ApplyConfigurationsFromAssembly(typeof(SqlContext).Assembly);
                /*foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(x => x.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;            
                base.OnModelCreating(modelBuilder);*/
            }
        }
    
}
