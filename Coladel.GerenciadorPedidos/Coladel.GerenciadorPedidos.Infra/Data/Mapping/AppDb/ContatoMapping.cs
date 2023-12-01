using Microsoft.EntityFrameworkCore.Metadata.Builders;
using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace A4S.ERP.Infra.Data.Mapping
{
    internal class ContatoMapping : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.ToTable("contatos");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(p => p.Nome).HasColumnName("nome").HasColumnType("varchar(126)");
            builder.Property(p => p.Email).HasColumnName("email").HasColumnType("varchar(126)");
            builder.Property(p => p.Telefone).HasColumnName("telefone").HasColumnType("varchar(12)");
            builder.Property(p => p.Celular).HasColumnName("celular").HasColumnType("varchar(14)");

            builder.HasOne(p => p.Transportadora).WithOne(p => p.Contato).HasForeignKey<Transportadora>(p => p.ContatoId);
        }
    }
}
