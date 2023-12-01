using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A4S.ERP.Infra.Data.Mapping
{
    class TributosMapping : IEntityTypeConfiguration<Tributos>
    {
        public void Configure(EntityTypeBuilder<Tributos> builder)
        {
            builder.ToTable("tributos");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(p => p.ClasseEnquadramentoIpi).HasColumnName("classe_enquadramento_ipi");
            builder.Property(p => p.CodEnquadramentoIpi).HasColumnName("cod_enquadramento_ipi");
            builder.Property(p => p.Cofins).HasColumnName("cofins");
            builder.Property(p => p.CreditoIcms).HasColumnName("credito_icms");
            builder.Property(p => p.Crt).HasColumnName("crt");
            builder.Property(p => p.Csosn).HasColumnName("csosn");
            builder.Property(p => p.Csll).HasColumnName("csll");
            builder.Property(p => p.CstCofins).HasColumnName("cst_cofins");
            builder.Property(p => p.CstIcms).HasColumnName("cst_icms");
            builder.Property(p => p.CstIpi).HasColumnName("cst_ipi");
            builder.Property(p => p.CstPis).HasColumnName("cst_pis");
            builder.Property(p => p.Icms).HasColumnName("icms");
            builder.Property(p => p.Inss).HasColumnName("inss");
            builder.Property(p => p.Ipi).HasColumnName("ipi");
            builder.Property(p => p.Irpj).HasColumnName("irpj");
            builder.Property(p => p.Iss).HasColumnName("iss");
            builder.Property(p => p.Iva).HasColumnName("iva");
            builder.Property(p => p.Pis).HasColumnName("pis");
            builder.Property(p => p.ReducaoIcms).HasColumnName("reducao_icms");
            builder.Property(p => p.ReducaoIcmsst).HasColumnName("reducao_icmsst");
            builder.Property(p => p.NaturezaOperacao).HasColumnName("natureza_operacao");
        }
    }
}
