using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A4S.ERP.Infra.Data.Mapping
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
            builder.Property(p => p.EmiteNfe).HasColumnName("emite_nfe");
            builder.Property(p => p.RoleId).HasColumnName("id_role");
            builder.Property(p => p.SetorId).HasColumnName("id_setor");
            builder.Property(p => p.EmpresaId).HasColumnName("id_empresa");
            builder.Property(p => p.ContatoUserId).HasColumnName("id_contato");

            builder.HasOne(p => p.Empresa).WithMany(p => p.Usuarios).HasForeignKey(p => p.EmpresaId);
            builder.HasOne(p => p.Setor).WithMany(p => p.Usuarios).HasForeignKey(p => p.SetorId);
            builder.HasOne(p => p.Role).WithMany(p => p.Usuarios).HasForeignKey(p => p.RoleId);
        }
    }
}
