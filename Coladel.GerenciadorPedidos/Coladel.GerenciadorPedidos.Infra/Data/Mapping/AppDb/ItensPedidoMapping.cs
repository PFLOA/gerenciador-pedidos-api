using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A4S.ERP.Infra.Data.Mapping
{
    public class ItensPedidoMapping : IEntityTypeConfiguration<ItensPedido>
    {
        public void Configure(EntityTypeBuilder<ItensPedido> builder)
        {
            builder.ToTable("itens_pedido");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(p => p.IdPedido).HasColumnName("id_pedido");
            builder.Property(p => p.IdProduto).HasColumnName("id_produto");
            builder.Property(p => p.Preco).HasColumnName("preco");
            builder.Property(p => p.Quantidade).HasColumnName("quantidade");

            builder.HasOne(p => p.Pedido).WithMany(p => p.ItensPedido).HasForeignKey(fk => fk.IdPedido);
            builder.HasOne(p => p.Produto).WithMany(p => p.ItensPedido).HasForeignKey(fk => fk.IdProduto);
        }
    }
}
