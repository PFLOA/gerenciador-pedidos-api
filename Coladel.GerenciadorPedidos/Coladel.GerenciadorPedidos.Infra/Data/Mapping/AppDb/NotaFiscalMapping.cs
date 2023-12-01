using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A4S.ERP.Infra.Data.Mapping
{
    public class NotaFiscalMapping : IEntityTypeConfiguration<NotaFiscal>
    {
        public void Configure(EntityTypeBuilder<NotaFiscal> builder)
        {
            builder.ToTable("nota_fiscal");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(p => p.TransporteNfId).HasColumnName("id_transporte");
            builder.Property(p => p.CobrancaId).HasColumnName("id_cobranca");
            builder.Property(p => p.ClienteId).HasColumnName("id_cliente");
            builder.Property(p => p.TributosNfId).HasColumnName("id_tributos");
            builder.Property(p => p.Guid).HasColumnName("guid");
            builder.Property(p => p.DataCadastro).HasColumnName("data_cadastro");
            builder.Property(p => p.DataEmissao).HasColumnName("data_emissao");
            builder.Property(p => p.DataSaida).HasColumnName("data_saida");
            builder.Property(p => p.Chave).HasColumnName("chave").HasColumnType("varchar(50)");
            builder.Property(p => p.Total).HasColumnName("total").HasColumnType("decimal(62,2)");
            builder.Property(p => p.TotalTributos).HasColumnName("valor_total_tributos").HasColumnType("decimal(62,2)");
            builder.Property(p => p.InformacoesComplementares).HasColumnName("informacoes_complementares").HasColumnType("varchar(500)");

            builder.HasOne(p => p.Cliente).WithMany(p => p.NotasFiscais).HasForeignKey(fk => fk.ClienteId);
            builder.HasOne(p => p.Cobranca).WithOne(p => p.NotaFiscal).HasForeignKey<NotaFiscal>(p => p.CobrancaId);
            builder.HasOne(p => p.TransporteNf).WithOne(p => p.NotaFiscal).HasForeignKey<NotaFiscal>(p => p.TransporteNfId);
            builder.HasOne(p => p.TributosNf).WithOne(p => p.NotaFiscal).HasForeignKey<NotaFiscal>(p => p.TributosNfId);
        }
    }
}
