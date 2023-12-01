using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A4S.ERP.Infra.Data.Mapping
{
    public class EmbalagemMapping : IEntityTypeConfiguration<Embalagem>
    {
        public void Configure(EntityTypeBuilder<Embalagem> builder)
        {
            builder.ToTable("embalagens");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id").HasColumnType("smallint(6)");
            builder.Property(p => p.Descricao).HasColumnName("descricao").HasColumnType("varchar(12)");
            builder.Property(p => p.Dimensoes).HasColumnName("dimensoes").HasColumnType("varchar(100)");
            builder.Property(p => p.UnidadesId).HasColumnName("id_unidade");

            builder.HasOne(p => p.Unidades).WithMany(p => p.Embalagens).HasForeignKey(fk => fk.UnidadesId);
        }
    }
}
