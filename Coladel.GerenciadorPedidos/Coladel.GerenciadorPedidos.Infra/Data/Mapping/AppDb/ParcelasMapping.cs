using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A4S.ERP.Infra.Data.Mapping.AppDb
{
    public class ParcelasMapping : IEntityTypeConfiguration<Parcelas>
    {
        public void Configure(EntityTypeBuilder<Parcelas> builder)
        {
            builder.ToTable("parcelas");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id").HasColumnType("smallint(6)");

            builder.Property(p => p.Acrescimo).HasColumnName("acrescimo").HasColumnType("varchar(12)");
            builder.Property(p => p.CondicoesPagamentoId).HasColumnName("id_condicoes_pagamento").HasColumnType("varchar(100)");
            builder.Property(p => p.Dias).HasColumnName("dias");
            builder.Property(p => p.NumeroParcela).HasColumnName("numero_parcela");
            builder.Property(p => p.Rateio).HasColumnName("rateio");

            builder.HasOne(p => p.CondicoesPagamento).WithMany(p => p.Parcelas).HasForeignKey(fk => fk.CondicoesPagamentoId);
        }
    }
}
