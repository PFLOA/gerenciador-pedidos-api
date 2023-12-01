using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A4S.ERP.Infra.Data.Mapping
{
    public class ModeloMapping : IEntityTypeConfiguration<Modelo>
    {
        public void Configure(EntityTypeBuilder<Modelo> builder)
        {
            builder.ToTable("modelo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id").HasColumnType("smallint(6)");
            builder.Property(p => p.Descricao).HasColumnName("descricao").HasColumnType("varchar(36)");
        }
    }
}
