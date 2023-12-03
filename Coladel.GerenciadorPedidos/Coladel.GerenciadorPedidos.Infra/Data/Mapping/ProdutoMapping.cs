using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
            builder.Property(p => p.TributosId).HasColumnName("id_tributos");
            builder.Property(p => p.EmabalagemId).HasColumnName("id_embalagem");
            builder.Property(p => p.FabricanteId).HasColumnName("id_fabricante");
            builder.Property(p => p.CorId).HasColumnName("id_cor");
            builder.Property(p => p.GrupoId).HasColumnName("id_grupo");
            builder.Property(p => p.SubGrupoId).HasColumnName("id_sub_grupo");
            builder.Property(p => p.ModeloId).HasColumnName("id_modelo");
            builder.Property(p => p.NomeProduto).HasColumnName("nome_produto");
            builder.Property(p => p.CodEan).HasColumnName("cod_ean");
            builder.Property(p => p.CodOriginal).HasColumnName("cod_original");
            builder.Property(p => p.CodFabricante).HasColumnName("cod_fabricante");
            builder.Property(p => p.Garantia).HasColumnName("garantia");
            builder.Property(p => p.Observacoes).HasColumnName("observacoes");
            builder.Property(p => p.InformacoesFiscaisId).HasColumnName("id_inf_fiscais");
        }
    }
}
