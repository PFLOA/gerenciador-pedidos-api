using Coladel.Core.Extensions;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Coladel.GerenciadorPedidos.Infra.Data.Mapping
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
            builder.Property(p => p.IdCliente).HasColumnName("id_cliente");

            builder.HasOne(p => p.Cliente).WithMany().HasForeignKey(fk => fk.IdCliente);
        }
    }
}
