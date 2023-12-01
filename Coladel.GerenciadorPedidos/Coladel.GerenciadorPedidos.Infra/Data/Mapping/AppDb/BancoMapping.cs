using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A4S.ERP.Infra.Data.Mapping.AppDb
{
    public class BancoMapping : IEntityTypeConfiguration<Banco>
    {
        public void Configure(EntityTypeBuilder<Banco> builder)
        {
            builder.ToTable("bancos");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id").ValueGeneratedOnAdd();

            builder.Property(p => p.Nome).HasColumnName("nome");
            builder.Property(p => p.Numero).HasColumnName("numero");
        }
    }
}
