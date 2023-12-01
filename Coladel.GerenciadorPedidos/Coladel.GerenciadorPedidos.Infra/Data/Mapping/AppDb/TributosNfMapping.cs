using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A4S.ERP.Infra.Data.Mapping.AppDb
{
    public class TributosNfMapping : IEntityTypeConfiguration<TributosNf>
    {
        public void Configure(EntityTypeBuilder<TributosNf> builder)
        {
            builder.ToTable("tributos_nf");

            builder.HasKey("id");

            builder.Property(p => p.Id).HasColumnName("id");
        }
    }
}
