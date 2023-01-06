using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Coladel.GerenciadorAulas.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Coladel.Infra.Data.Mapping
{
    public class EmpresaMapping : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("empresa");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(p => p.IdConfiguracao).HasColumnName("id_configuracao");
            builder.Property(p => p.Guid).HasColumnName("guid");
            builder.Property(p => p.DataCadastro).HasColumnName("data_cadastro");
            builder.Property(p => p.Nome).HasColumnName("nome").HasColumnType("varchar(256)");

            builder.HasMany(p => p.EnvioEmails).WithOne(p => p.Empresa).HasForeignKey(p => p.IdEmpresa);
            builder.HasOne(p => p.Configuracoes).WithOne(p => p.Empresa).HasForeignKey<Empresa>(p => p.IdConfiguracao);
        }
    }
}
