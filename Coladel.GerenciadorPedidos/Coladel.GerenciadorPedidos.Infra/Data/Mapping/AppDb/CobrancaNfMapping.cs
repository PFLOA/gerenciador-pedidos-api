using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A4S.ERP.Infra.Data.Mapping
{
    public class CobrancaNfMapping : IEntityTypeConfiguration<CobrancaNf>
    {
        public void Configure(EntityTypeBuilder<CobrancaNf> builder)
        {
            builder.ToTable("cobranca_nf");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(p => p.DataVencimento).HasColumnName("data_vencimento");
            builder.Property(p => p.Duplicatas).HasColumnName("duplicatas");
            builder.Property(p => p.ValorLiquido).HasColumnName("valor_liquido");

            builder.HasOne(p => p.NotaFiscal).WithOne(p => p.Cobranca).HasForeignKey<NotaFiscal>(p => p.CobrancaId);
        }
    }
}
