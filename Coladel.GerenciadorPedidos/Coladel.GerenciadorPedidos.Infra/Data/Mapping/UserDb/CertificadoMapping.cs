using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A4S.ERP.Infra.Data.Mapping
{
    public class CertificadoMapping : IEntityTypeConfiguration<Certificado>
    {
        public void Configure(EntityTypeBuilder<Certificado> builder)
        {
            builder.ToTable("certificados");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(p => p.Guid).HasColumnName("guid");
            builder.Property(p => p.DataCadastro).HasColumnName("data_cadastro");
            builder.Property(p => p.CertificadoPrivado).HasColumnName("certificado");
            builder.Property(p => p.DataValidade).HasColumnName("data_validade");
            builder.Property(p => p.EmiteNfe).HasColumnName("emite_nfe");
            builder.Property(p => p.EmiteNfse).HasColumnName("emite_nfse");
            builder.Property(p => p.hash).HasColumnName("hash");
            builder.Property(p => p.EmpresaId).HasColumnName("id_empresa");
            builder.Property(p => p.Padrao).HasColumnName("padrao");
        }
    }
}
