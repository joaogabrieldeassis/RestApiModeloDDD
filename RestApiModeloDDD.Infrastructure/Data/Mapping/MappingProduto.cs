using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestApiModeloDDD.Domain.Entitys;

namespace RestApiModeloDDD.Infrastructure.Data.Mapping
{
    public class MappingProduto : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(c => c.Id);
                
            builder.Property(c=>c.IsDisponivel)
                .IsRequired();

            builder.Property(c=>c.Nome)
                .HasMaxLength(300)
                .IsRequired();

            builder.Property(c => c.Valor)
               .HasMaxLength(400)
               .IsRequired();
        }
    }
}
