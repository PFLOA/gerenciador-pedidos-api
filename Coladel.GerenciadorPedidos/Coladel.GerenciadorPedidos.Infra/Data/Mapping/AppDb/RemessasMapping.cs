using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A4S.ERP.Infra.Data.Mapping.AppDb
{
    public class RemessasMapping : IEntityTypeConfiguration<Remessas>
    {
        public void Configure(EntityTypeBuilder<Remessas> builder)
        {
            builder.ToTable("remessas");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id").HasColumnType("smallint(6)");
            builder.Property(p => p.ClienteId).HasColumnName("id_cliente").HasColumnType("smallint(6)");
            builder.Property(p => p.ContasReceberId).HasColumnName("id_contas_receber").HasColumnType("smallint(6)");
            builder.Property(p => p.ArquivoRemessa).HasColumnName("arquivo_remessa");
            builder.Property(p => p.HtmlBoleto).HasColumnName("html_boleto");

            builder.HasOne(x => x.Cliente).WithMany().HasForeignKey(x => x.ClienteId);
            builder.HasOne(x => x.ContasReceber).WithOne(x => x.Remessas).HasForeignKey<Remessas>(x => x.ContasReceberId);
        }
    }
}
