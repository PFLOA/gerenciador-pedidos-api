using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using A4S.ERP.Domain.Entidades;

namespace A4S.ERP.Infra.Data.Mapping
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("produtos"); 

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id").HasColumnType("smallint(6)");
            builder.Property(p => p.Guid).HasColumnName("guid").HasColumnType("char(36)");
            builder.Property(p => p.CodEan).HasColumnName("cod_ean");
            builder.Property(p => p.Garantia).HasColumnName("garantia");
            builder.Property(p => p.NomeProduto).HasColumnName("nome_produto");
            builder.Property(p => p.CodOriginal).HasColumnName("cod_original");
            builder.Property(p => p.Observacoes).HasColumnName("observacoes");
            builder.Property(p => p.DataCadastro).HasColumnName("data_cadastro");
            builder.Property(p => p.CodFabricante).HasColumnName("cod_fabricante");

            builder.Property(p => p.CorId).HasColumnName("id_cor").HasColumnType("smallint(6)");
            builder.Property(p => p.GrupoId).HasColumnName("id_grupo").HasColumnType("smallint(6)");
            builder.Property(p => p.ModeloId).HasColumnName("id_modelo").HasColumnType("smallint(6)");
            builder.Property(p => p.SubGrupoId).HasColumnName("id_sub_grupo").HasColumnType("smallint(6)");
            builder.Property(p => p.TributosId).HasColumnName("id_tributos").HasColumnType("smallint(6)");
            builder.Property(p => p.EmabalagemId).HasColumnName("id_embalagem").HasColumnType("smallint(6)");
            builder.Property(p => p.FabricanteId).HasColumnName("id_fabricante").HasColumnType("smallint(6)");
            builder.Property(p => p.InformacoesFiscaisId).HasColumnName("id_inf_fiscais").HasColumnType("smallint(6)");

            builder.HasOne(p => p.Cor).WithMany(p => p.Produtos).HasForeignKey(fk => fk.CorId);
            builder.HasOne(p => p.Fabricante).WithMany(p => p.Produtos).HasForeignKey(fk => fk.FabricanteId);
            builder.HasOne(p => p.Embalagem).WithMany(p => p.Produtos).HasForeignKey(fk => fk.EmabalagemId);
            builder.HasOne(p => p.Modelo).WithMany(p => p.Produtos).HasForeignKey(fk => fk.ModeloId);
            builder.HasOne(p => p.GrupoProduto).WithMany(p => p.Produtos).HasForeignKey(fk => fk.GrupoId);
            builder.HasOne(p => p.SubGrupoProduto).WithMany(p => p.Produtos).HasForeignKey(fk => fk.SubGrupoId);

            builder.HasOne(p => p.Tributos).WithOne(p => p.Produto).HasForeignKey<Produto>(fk => fk.TributosId);
            builder.HasOne(p => p.InformacoesFiscais).WithOne(p => p.Produto).HasForeignKey<Produto>(fk => fk.InformacoesFiscaisId);
        }
    }
}
