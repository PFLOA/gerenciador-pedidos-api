using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A4S.ERP.Infra.Data.Mapping.AppDb
{
    public class RamoAtividadeMapping : IEntityTypeConfiguration<RamoAtividade>
    {
        public void Configure(EntityTypeBuilder<RamoAtividade> builder)
        {
            builder.ToTable("ramo_atividades");
            
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id").ValueGeneratedOnAdd();

            builder.Property(p => p.Descricao).HasColumnName("descricao");
        }
    }
}
