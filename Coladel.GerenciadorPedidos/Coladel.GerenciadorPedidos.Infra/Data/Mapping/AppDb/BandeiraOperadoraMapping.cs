using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A4S.ERP.Infra.Data.Mapping.AppDb
{
    public class BandeiraOperadoraMapping : IEntityTypeConfiguration<BandeiraOperadora>
    {
        public void Configure(EntityTypeBuilder<BandeiraOperadora> builder)
        {
            builder.ToTable("bandeira_operadoras");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id").HasColumnType("smallint(6)");

            builder.Property(p => p.Descricao).HasColumnName("descricao");
        }
    }
}
