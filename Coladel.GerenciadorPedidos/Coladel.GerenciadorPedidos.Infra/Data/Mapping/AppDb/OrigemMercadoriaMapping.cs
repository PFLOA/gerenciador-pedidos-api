using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A4S.ERP.Infra.Data.Mapping
{
    public class OrigemMercadoriaMapping : IEntityTypeConfiguration<OrigemMercadoria>
    {
        public void Configure(EntityTypeBuilder<OrigemMercadoria> builder)
        {
            builder.ToTable("origem_mercadoria");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(p => p.Descricao).HasColumnName("descricao").HasColumnType("varchar(126)");
        }
    }
}
