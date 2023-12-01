using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A4S.ERP.Infra.Data.Mapping
{
    public class SubGrupoProdutoMapping : IEntityTypeConfiguration<SubGrupoProduto>
    {
        public void Configure(EntityTypeBuilder<SubGrupoProduto> builder)
        {
            builder.ToTable("sub_grupo_produto");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id").HasColumnType("smallint(6)");
            builder.Property(p => p.Descricao).HasColumnName("descricao").HasColumnType("varchar(36)");
            builder.Property(p => p.GrupoId).HasColumnName("id_grupo");

            builder.HasOne(p => p.Grupo).WithMany(p => p.SubGrupos).HasForeignKey(fk => fk.GrupoId);
        }
    }
}
