using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A4S.ERP.Infra.Data.Mapping.AppDb
{
    public class ContaMapping : IEntityTypeConfiguration<Conta>
    {
        public void Configure(EntityTypeBuilder<Conta> builder)
        {
            builder.ToTable("contas");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id").HasColumnType("smallint(6)");

            builder.Property(p => p.BancoId).HasColumnName("id_banco");
            builder.Property(p => p.NumAgencia).HasColumnName("agencia");
            builder.Property(p => p.NumConta).HasColumnName("conta");
            builder.Property(p => p.Observacoes).HasColumnName("observacoes");
            builder.Property(p => p.TipoConta).HasColumnName("tipo_conta").HasConversion<string>();

            builder.HasOne(p => p.Banco).WithMany(p => p.Contas).HasForeignKey(fk => fk.BancoId);
        }
    }
}
