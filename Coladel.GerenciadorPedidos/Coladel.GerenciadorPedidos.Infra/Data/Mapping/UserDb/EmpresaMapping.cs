using Microsoft.EntityFrameworkCore.Metadata.Builders;
using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace A4S.ERP.Infra.Data.Mapping
{
    public class EmpresaMapping : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("empresas");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(p => p.Guid).HasColumnName("guid");
            builder.Property(p => p.DataCadastro).HasColumnName("data_cadastro");
            builder.Property(p => p.NomeFantasia).HasColumnName("nome_fantasia").HasColumnType("varchar(256)");
            builder.Property(p => p.RazaoSocial).HasColumnName("razao_social").HasColumnType("varchar(256)");
            builder.Property(p => p.TipoPessoa).HasColumnName("tipo_pessoa").HasColumnType("varchar(10)");
            builder.Property(p => p.DocumentoPrincipal).HasColumnName("documento_principal").HasColumnType("varchar(18)");
            builder.Property(p => p.DocumentoSecundario).HasColumnName("documento_secundario").HasColumnType("varchar(18)");
            builder.Property(p => p.InscricaoMunicipal).HasColumnName("Inscricao_municipal").HasColumnType("varchar(18)");
            builder.Property(p => p.Cnae).HasColumnName("cnae").HasColumnType("varchar(18)");
            builder.Property(p => p.InscricaoSuframa).HasColumnName("inscricao_suframa").HasColumnType("varchar(18)");
            builder.Property(p => p.Site).HasColumnName("site").HasColumnType("varchar(100)");
            builder.Property(p => p.BdEmpresaId).HasColumnName("id_bd_empresa").HasColumnType("smallint(6)");
            builder.Property(p => p.EnderecoId).HasColumnName("id_endereco").HasColumnType("smallint(6)");
            builder.Property(p => p.TributosId).HasColumnName("id_tributos").HasColumnType("smallint(6)");

            builder.HasOne(p => p.BdEmpresa).WithOne(p => p.Empresa).HasForeignKey<Empresa>(p => p.BdEmpresaId);
            builder.HasOne(p => p.Endereco).WithOne(p => p.Empresa).HasForeignKey<Empresa>(p => p.EnderecoId);
            builder.HasMany(p => p.Certificados).WithOne(p => p.Empresa).HasForeignKey(p => p.EmpresaId);
        }
    }
}
