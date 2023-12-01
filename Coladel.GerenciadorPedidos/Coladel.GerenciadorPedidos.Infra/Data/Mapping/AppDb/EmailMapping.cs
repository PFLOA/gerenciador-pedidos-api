using Microsoft.EntityFrameworkCore.Metadata.Builders;
using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace A4S.ERP.Infra.Data.Mapping
{
    public class EmailMapping : IEntityTypeConfiguration<Email>
    {
        public void Configure(EntityTypeBuilder<Email> builder)
        {
            builder.ToTable("emails");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(p => p.IdCliente).HasColumnName("id_cliente");
            builder.Property(p => p.Guid).HasColumnName("guid");
            builder.Property(p => p.DataCadastro).HasColumnName("data_cadastro");
            builder.Property(p => p.Descricao).HasColumnName("email").HasColumnType("varchar(256)");
        }
    }
}
