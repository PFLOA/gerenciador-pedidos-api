using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A4S.ERP.Infra.Data.Mapping
{
    public class BdEmpresaMapping : IEntityTypeConfiguration<BdEmpresa>
    {
        public void Configure(EntityTypeBuilder<BdEmpresa> builder)
        {
            builder.ToTable("bd_empresas");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(p => p.Guid).HasColumnName("guid");
            builder.Property(p => p.DataCadastro).HasColumnName("data_cadastro");
            builder.Property(p => p.BdNome).HasColumnName("bd_nome").HasColumnType("varchar(50)");
            builder.Property(p => p.BdPw).HasColumnName("bd_pw").HasColumnType("varchar(50)");
            builder.Property(p => p.BdServer).HasColumnName("bd_server").HasColumnType("varchar(50)");
            builder.Property(p => p.BdUser).HasColumnName("bd_user").HasColumnType("varchar(100)");
        }
    }
}
