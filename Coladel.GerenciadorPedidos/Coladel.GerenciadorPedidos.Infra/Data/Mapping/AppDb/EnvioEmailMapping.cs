using Microsoft.EntityFrameworkCore.Metadata.Builders;
using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace A4S.ERP.Infra.Data.Mapping
{
    public class EnvioEmailMapping : IEntityTypeConfiguration<EnvioEmail>
    {
        public void Configure(EntityTypeBuilder<EnvioEmail> builder)
        {
            builder.ToTable("envio_emails");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(p => p.EmpresaId).HasColumnName("id_empresa");
            builder.Property(p => p.Guid).HasColumnName("guid");
            builder.Property(p => p.DataCadastro).HasColumnName("data_cadastro");
            builder.Property(p => p.SmtpCliente).HasColumnName("smtp_cliente").HasColumnType("varchar(50)");
            builder.Property(p => p.PortSmtp).HasColumnName("port");
            builder.Property(p => p.Email).HasColumnName("email").HasColumnType("varchar(50)");
            builder.Property(p => p.Senha).HasColumnName("senha").HasColumnType("varchar(50)");
            builder.Property(p => p.TipoEmail).HasColumnName("tipo_email");
            builder.Property(p => p.Assunto).HasColumnName("assunto");
            builder.Property(p => p.Mensagem).HasColumnName("mensagem");
            builder.Property(p => p.IsOrigem).HasColumnName("is_origem");
        }
    }
}
