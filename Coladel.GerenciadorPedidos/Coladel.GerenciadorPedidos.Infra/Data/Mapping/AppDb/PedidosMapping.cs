using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A4S.ERP.Infra.Data.Mapping
{
    public class PedidosMapping : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("pedidos");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(p => p.Guid).HasColumnName("guid");
            builder.Property(p => p.DataCadastro).HasColumnName("data_cadastro");
            builder.Property(p => p.NF).HasColumnName("nf");
            builder.Property(p => p.Observacoes).HasColumnName("observacoes");
            builder.Property(p => p.StatusPedido).HasColumnName("status");
            builder.Property(p => p.Total).HasColumnName("total");
            builder.Property(p => p.ClienteId).HasColumnName("id_cliente");
            builder.Property(p => p.CondicoesPagamentoId).HasColumnName("id_condicao_pagamento");
            builder.Property(p => p.TotalComissao).HasColumnName("total_comissao");

            builder.HasOne(p => p.Cliente).WithMany(p => p.Pedidos).HasForeignKey(fk => fk.ClienteId);
            builder.HasOne(p => p.CondicoesPagamento).WithOne().HasForeignKey<Pedido>(fk => fk.CondicoesPagamentoId);
        }
    }
}
