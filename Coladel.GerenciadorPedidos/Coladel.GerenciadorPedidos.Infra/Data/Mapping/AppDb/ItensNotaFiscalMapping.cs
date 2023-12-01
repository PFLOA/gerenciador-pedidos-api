using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A4S.ERP.Infra.Data.Mapping
{
    public class ItensNotaFiscalMapping : IEntityTypeConfiguration<ItensNotaFiscal>
    {
        public void Configure(EntityTypeBuilder<ItensNotaFiscal> builder)
        {
            builder.ToTable("itens_nota_fiscal");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id").ValueGeneratedOnAdd();

            builder.Property(p => p.NotaFiscalId).HasColumnName("id_nota_fiscal");
            builder.Property(p => p.ProdutoId).HasColumnName("id_produto");

            builder.Property(p => p.Quantidade).HasColumnName("quantidade");
            builder.Property(p => p.ValorUnitario).HasColumnName("valor_unitario");

            builder.HasOne(p => p.Produto).WithMany(p => p.ItensNotaFiscal).HasForeignKey(fk => fk.ProdutoId);
            builder.HasOne(p => p.NotaFiscal).WithMany(p => p.ItensNotaFiscal).HasForeignKey(fk => fk.NotaFiscalId);
        }
    }
}
