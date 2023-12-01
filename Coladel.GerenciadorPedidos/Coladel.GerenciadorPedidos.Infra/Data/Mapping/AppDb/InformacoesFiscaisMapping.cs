using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A4S.ERP.Infra.Data.Mapping
{
    public class InformacoesFiscaisMapping : IEntityTypeConfiguration<InformacoesFiscais>
    {
        public void Configure(EntityTypeBuilder<InformacoesFiscais> builder)
        {
            builder.ToTable("informacoes_fiscais");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(p => p.OrigemMercadoriaId).HasColumnName("id_origem_mercadoria");
            builder.Property(p => p.UnidadesId).HasColumnName("id_un");
            builder.Property(p => p.MargemLucro).HasColumnName("margem_lucro");
            builder.Property(p => p.Cest).HasColumnName("cest");
            builder.Property(p => p.Comissao).HasColumnName("comissao");
            builder.Property(p => p.Ncm).HasColumnName("ncm");
            builder.Property(p => p.PesoBruto).HasColumnName("peso_bruto");
            builder.Property(p => p.PesoLiquido).HasColumnName("peso_liquido");
            builder.Property(p => p.TipoItem).HasColumnName("tipo_item");
            builder.Property(p => p.PrecoVenda).HasColumnName("preco_venda");
            builder.Property(p => p.PrecoCusto).HasColumnName("preco_custo");
            builder.Property(p => p.PrecoCompra).HasColumnName("preco_compra");

            builder.HasOne(p => p.OrigemMercadoria).WithMany(p => p.InformacoesFiscais).HasForeignKey(p => p.OrigemMercadoriaId);
            builder.HasOne(p => p.Unidades).WithMany(p => p.InformacoesFiscais).HasForeignKey(p => p.UnidadesId);
        }
    }
}
