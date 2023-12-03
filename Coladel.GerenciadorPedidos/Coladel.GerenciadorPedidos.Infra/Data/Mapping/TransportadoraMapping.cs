using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coladel.Infra.Data.Mapping
{
    public class TransportadoraMapping : IEntityTypeConfiguration<Transportadora>
    {
        public void Configure(EntityTypeBuilder<Transportadora> builder)
        {
            builder.ToTable("transportadoras");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(p => p.ContatoId).HasColumnName("id_contato").IsRequired(false);
            builder.Property(p => p.EnderecoId).HasColumnName("id_endereco").IsRequired(false);
            builder.Property(p => p.Guid).HasColumnName("guid");
            builder.Property(p => p.DataCadastro).HasColumnName("data_cadastro");
            builder.Property(p => p.RazaoSocial).HasColumnName("nome").HasColumnType("varchar(126)");
            builder.Property(p => p.NomeFantasia).HasColumnName("nome_fantasia").HasColumnType("varchar(126)");
            builder.Property(p => p.Observacao).HasColumnName("observacao").HasColumnType("varchar(256)");
            builder.Property(p => p.CodTransportadora).HasColumnName("cod_transportadora").HasColumnType("varchar(10)");
            builder.Property(p => p.Website).HasColumnName("website").HasColumnType("varchar(100)");

            builder.HasOne(p => p.Contato).WithOne(p => p.Transportadora).HasForeignKey<Transportadora>(p => p.ContatoId);
            builder.HasOne(p => p.Endereco).WithOne(p => p.Transportadora).HasForeignKey<Transportadora>(p => p.EnderecoId);
        }
    }
}
