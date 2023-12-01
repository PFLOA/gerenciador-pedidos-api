using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A4S.ERP.Infra.Data.Mapping
{
    public class UnidadesMapping : IEntityTypeConfiguration<Unidades>
    {
        public void Configure(EntityTypeBuilder<Unidades> builder)
        {
            builder.ToTable("unidades");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(p => p.Descricao).HasColumnName("descricao");
            builder.Property(p => p.Unidade).HasColumnName("unidade");

            builder.HasMany(p => p.InformacoesFiscais).WithOne(p => p.Unidades).HasForeignKey(p => p.UnidadesId);
            builder.HasMany(p => p.Embalagens).WithOne(p => p.Unidades).HasForeignKey(p => p.UnidadesId);
        }
    }
}
