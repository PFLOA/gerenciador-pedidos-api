using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coladel.GerenciadorPedidos.Infra.Data.Mapping
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuarios");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("id");
            builder.Property(p => p.Guid).HasColumnName("guid");
            builder.Property(p => p.DataCadastro).HasColumnName("data_cadastro");
            builder.Property(p => p.Nome).HasColumnName("nome");
            builder.Property(p => p.Senha).HasColumnName("senha");
            builder.Property(p => p.Email).HasColumnName("email");
            builder.Property(p => p.EmiteNfe).HasColumnName("user_name");
            builder.Property(p => p.Role).HasColumnName("Role").HasConversion<string>();
            builder.Property(p => p.EmpresaId).HasColumnName("id_empresa");
            builder.Property(p => p.ContatoUserId).HasColumnName("id_contato");
            builder.Property(p => p.SetorId).HasColumnName("id_setor");
            builder.Property(p => p.RoleId).HasColumnName("id_role");
        }
    }
}
