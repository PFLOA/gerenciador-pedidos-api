using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A4S.ERP.Infra.Data.Mapping
{
    public class ContatoUserMapping : IEntityTypeConfiguration<ContatoUser>
    {
        public void Configure(EntityTypeBuilder<ContatoUser> builder)
        {
            builder.ToTable("contatos");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(p => p.Email).HasColumnName("email").HasColumnType("varchar(126)");
            builder.Property(p => p.Telefone).HasColumnName("telefone").HasColumnType("varchar(12)");
            builder.Property(p => p.Celular).HasColumnName("celular").HasColumnType("varchar(14)");

            builder.HasOne(p => p.Usuario).WithOne(p => p.ContatoUser).HasForeignKey<Usuario>(p => p.ContatoUserId);
        }
    }
}
