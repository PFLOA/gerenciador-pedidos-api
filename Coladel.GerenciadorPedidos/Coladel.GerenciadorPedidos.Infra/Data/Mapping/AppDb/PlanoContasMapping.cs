using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A4S.ERP.Infra.Data.Mapping.AppDb
{
    public class PlanoContasMapping : IEntityTypeConfiguration<PlanoContas>
    {
        public void Configure(EntityTypeBuilder<PlanoContas> builder)
        {

            builder.ToTable("plano_contas");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id").ValueGeneratedOnAdd();

            builder.Property(p => p.Descricao).HasColumnName("descricao");
            builder.Property(p => p.Grupo).HasColumnName("grupo");
            builder.Property(p => p.TipoConta).HasColumnName("tipo_conta");
            builder.Property(p => p.IsCustoFixo).HasColumnName("custo_fixo");
        }
    }
}
