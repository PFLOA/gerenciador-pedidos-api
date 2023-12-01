using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A4S.ERP.Infra.Data.Mapping
{
    public class TransporteNfMapping : IEntityTypeConfiguration<TransporteNf>
    {
        public void Configure(EntityTypeBuilder<TransporteNf> builder)
        {
            builder.ToTable("transporte_nf");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(p => p.TransportadoraId).HasColumnName("nf");
            builder.Property(p => p.Marca).HasColumnName("observacoes");
            builder.Property(p => p.ModFrete).HasColumnName("status");
            builder.Property(p => p.Volumes).HasColumnName("total");

            builder.HasOne(t => t.Transportadora).WithMany(t => t.TransporteNf).HasForeignKey(fk => fk.TransportadoraId);
        }
    }
}
