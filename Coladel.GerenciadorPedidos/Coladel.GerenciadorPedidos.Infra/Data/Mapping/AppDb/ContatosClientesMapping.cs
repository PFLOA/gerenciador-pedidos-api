using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A4S.ERP.Infra.Data.Mapping.AppDb
{
    public class ContatosClientesMapping : IEntityTypeConfiguration<ContatoCliente>
    {
        public void Configure(EntityTypeBuilder<ContatoCliente> builder)
        {
            builder.ToTable("contatos_clientes");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(p => p.ClienteId).HasColumnName("id_cliente");
            builder.Property(p => p.Nome).HasColumnName("nome").HasColumnType("varchar(126)");
            builder.Property(p => p.Email).HasColumnName("email").HasColumnType("varchar(126)");
            builder.Property(p => p.Telefone).HasColumnName("telefone").HasColumnType("varchar(12)");
            builder.Property(p => p.Celular).HasColumnName("celular").HasColumnType("varchar(14)");
            builder.Property(p => p.TipoEmail).HasColumnName("tipo_email");

            builder.HasOne(p => p.Cliente).WithMany(p => p.ContatosCliente).HasForeignKey(p => p.ClienteId);
        }
    }
}
