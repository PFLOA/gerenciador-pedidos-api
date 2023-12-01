using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A4S.ERP.Infra.Data.Mapping.AppDb
{
    public class ContasReceberMapping : IEntityTypeConfiguration<ContasReceber>
    {
        public void Configure(EntityTypeBuilder<ContasReceber> builder)
        {
            builder.ToTable("contas_receber");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id").HasColumnType("smallint(6)");

            builder.Property(p => p.ClienteId).HasColumnName("id_cliente");
            builder.Property(p => p.Guid).HasColumnName("guid");
            builder.Property(p => p.DataCadastro).HasColumnName("data_cadastro");
            builder.Property(p => p.CondicaoPagamentoId).HasColumnName("id_condicao_pagamento");
            builder.Property(p => p.Duplicata).HasColumnName("duplicata");
            builder.Property(p => p.ValorAbatimento).HasColumnName("valor_abatimento");
            builder.Property(p => p.ValorBruto).HasColumnName("valor_bruto");
            builder.Property(p => p.ValorLiquido).HasColumnName("valor_liquido");
            builder.Property(p => p.ValorPagamento).HasColumnName("valor_pago");
            builder.Property(p => p.ValorDesconto).HasColumnName("valor_desconto");
            builder.Property(p => p.DataPagamento).HasColumnName("data_pagamento");
            builder.Property(p => p.DataVencimento).HasColumnName("data_vencimento");
            builder.Property(p => p.Juros).HasColumnName("juros");
            builder.Property(p => p.Multa).HasColumnName("mora");
            builder.Property(p => p.Status).HasColumnName("status");

            builder.HasOne(p => p.CondicoesPagamento).WithMany(p => p.ContasReceber).HasForeignKey(p => p.CondicaoPagamentoId);
            builder.HasOne(p => p.Remessas).WithOne(p => p.ContasReceber).HasForeignKey<Remessas>(p => p.ContasReceberId);

        }
    }
}
