using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Coladel.GerenciadorPedidos.Infra.Data.Mapping
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("produtos"); 
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("id");
            builder.Property(p => p.Guid).HasColumnName("guid");
            builder.Property(p => p.DataCadastro).HasColumnName("data_cadastro");
            builder.Property(p => p.NomeProduto).HasColumnName("nome_produto");
            builder.Property(p => p.Preco).HasColumnName("preco").HasColumnType("decimal(2,2)");
        }
    }
}
