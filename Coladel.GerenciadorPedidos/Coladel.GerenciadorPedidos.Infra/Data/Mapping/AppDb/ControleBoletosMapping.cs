using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A4S.ERP.Infra.Data.Mapping.AppDb
{
    public class ControleBoletosMapping : IEntityTypeConfiguration<ControleBoletos>
    {
        public void Configure(EntityTypeBuilder<ControleBoletos> builder)
        {
            builder.ToTable("controle_boletos");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(p => p.NossoNumero).HasColumnName("nosso_numero");

        }
    }
}
