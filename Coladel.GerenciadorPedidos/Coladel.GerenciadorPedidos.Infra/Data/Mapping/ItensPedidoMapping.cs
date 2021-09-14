using Coladel.GerenciadorPedidos.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coladel.GerenciadorPedidos.Infra.Data.Mapping
{
    public class ItensPedidoMapping : IEntityTypeConfiguration<ItensPedido>
    {
        public void Configure(EntityTypeBuilder<ItensPedido> builder)
        {
            builder.ToTable("itens_pedido");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(p => p.Guid).HasColumnName("guid");
            builder.Property(p => p.IdPedido).HasColumnName("id_pedido");
            builder.Property(p => p.IdProduto).HasColumnName("id_produto");
            builder.Property(p => p.Quantidade).HasColumnName("quantidade");
            builder.Property(p => p.DataCadastro).HasColumnName("data_cadastro");

            builder.HasOne(p => p.Pedido).WithMany(e => e.ItensPedido).HasForeignKey(fk => fk.IdPedido);
            builder.HasOne(p => p.Produto).WithMany(e => e.ItensPedido).HasForeignKey(fk => fk.IdProduto);
        }
    }
}
