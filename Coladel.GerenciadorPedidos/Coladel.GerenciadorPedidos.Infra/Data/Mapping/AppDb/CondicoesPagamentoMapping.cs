using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A4S.ERP.Infra.Data.Mapping.AppDb
{
    public class CondicoesPagamentoMapping : IEntityTypeConfiguration<CondicoesPagamento>
    {
        public void Configure(EntityTypeBuilder<CondicoesPagamento> builder)
        {
            builder.ToTable("condicoes_pagamento");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id").HasColumnType("smallint(6)");

            builder.Property(p => p.BandeiraOperadoraId).HasColumnName("id_bandeira_operadora");
            builder.Property(p => p.ContaDebitarId).HasColumnName("id_conta_debitar");
            builder.Property(p => p.PlanoContasId).HasColumnName("id_plano_contas");
            builder.Property(p => p.MeioPagamentoId).HasColumnName("id_meio_pagamento");
            builder.Property(p => p.CnpjCredenciadoraCartao).HasColumnName("cnpj_credenciadora");
            builder.Property(p => p.CodCredenciadora).HasColumnName("cod_credenciadora");
            builder.Property(p => p.TaxaAdministrativa).HasColumnName("taxa_administrativa");
            builder.Property(p => p.QuantidadeParcelas).HasColumnName("quantidade_parcelas");
            builder.Property(p => p.IsDataComercial).HasColumnName("data_comercial");
            builder.Property(p => p.IsGeraMovimentacaoFinanceira).HasColumnName("gera_movimentacao_financeira");
            builder.Property(p => p.IsPrazo).HasColumnName("a_prazo");
            builder.Property(p => p.Descricao).HasColumnName("descricao");

            builder.HasOne(p => p.BandeiraOperadora).WithOne(p => p.CondicoesPagamento).HasForeignKey<CondicoesPagamento>(fk => fk.BandeiraOperadoraId);
            builder.HasOne(p => p.MeioPagamento).WithOne(p => p.CondicoesPagamento).HasForeignKey<CondicoesPagamento>(fk => fk.MeioPagamentoId);
            builder.HasOne(p => p.PlanoContas).WithOne(p => p.CondicoesPagamento).HasForeignKey<CondicoesPagamento>(fk => fk.PlanoContasId);
            builder.HasOne(p => p.ContaDebitar).WithOne(p => p.CondicoesPagamento).HasForeignKey<CondicoesPagamento>(fk => fk.ContaDebitarId);
        }
    }
}
