using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A4S.ERP.Infra.Data.Mapping.AppDb
{
    public class MeioPagamentoMapping : IEntityTypeConfiguration<MeioPagamento>
    {
        public void Configure(EntityTypeBuilder<MeioPagamento> builder)
        {
            builder.ToTable("meios_pagamento");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id").HasColumnType("smallint(6)");

            builder.Property(p => p.Descricao).HasColumnName("descricao");
        }
    }
}
