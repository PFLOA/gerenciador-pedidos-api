using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coladel.Infra.Data.Mapping
{
    public class ConfiguracoesUsuarioMapping : IEntityTypeConfiguration<ConfiguracoesUsuario>
    {
        public void Configure(EntityTypeBuilder<ConfiguracoesUsuario> builder)
        {
            builder.ToTable("configuracoes_usuario");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(p => p.Guid).HasColumnName("guid");
            builder.Property(p => p.DataCadastro).HasColumnName("data_cadastro");
            builder.Property(p => p.NomeConfig).HasColumnName("nome_config").HasColumnType("varchar(256)");
            builder.Property(p => p.Valor).HasColumnName("valor_config").HasColumnType("varchar(256)");
        }
    }
}
