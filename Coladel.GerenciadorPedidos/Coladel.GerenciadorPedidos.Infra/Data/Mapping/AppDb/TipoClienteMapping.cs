using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A4S.ERP.Infra.Data.Mapping.AppDb
{
    public class TipoClienteMapping : IEntityTypeConfiguration<TipoCliente>
    {
        public void Configure(EntityTypeBuilder<TipoCliente> builder)
        {
            builder.ToTable("tipo_clientes");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id").HasColumnType("smallint(6)");

            builder.Property(p => p.Descricao).HasColumnName("descricao");
        }
    }
}
