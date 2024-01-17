using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestApiModeloDDD.Domain.Entitys;

namespace RestApiModeloDDD.Infrastructure.Data.Mapping
{
    public class MappingCliente : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.Id);
                             
            builder.Property(c=>c.Nome)
                .HasMaxLength(155)
                .IsRequired() ;

            builder.Property(c => c.Email)
                .HasMaxLength(155)
                .IsRequired();

            builder.Property(c => c.SobreNome)
                .HasMaxLength(155)
                .IsRequired();

            builder.Property(c => c.IsAtivo);

            builder.Property(c => c.DataCadastro);
                        
        }
    }
}
