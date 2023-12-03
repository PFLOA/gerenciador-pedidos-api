using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace A4S.ERP.Infra.Data.Mapping
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("enderecos");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(p => p.Guid).HasColumnName("guid");
            builder.Property(p => p.DataCadastro).HasColumnName("data_cadastro");
            builder.Property(p => p.Logradouro).HasColumnName("logradouro").HasColumnType("varchar(126)");
            builder.Property(p => p.Numero).HasColumnName("numero").HasColumnType("varchar(5)");
            builder.Property(p => p.Estado).HasColumnName("estado").HasColumnType("varchar(2)");
            builder.Property(p => p.Cidade).HasColumnName("cidade").HasColumnType("varchar(26)");
            builder.Property(p => p.Bairro).HasColumnName("bairro").HasColumnType("varchar(26)");
            builder.Property(p => p.Complemento).HasColumnName("complemento").HasColumnType("varchar(126)");
            builder.Property(p => p.Cep).HasColumnName("cep").HasColumnType("varchar(10)");

            builder.HasOne(p => p.Transportadora).WithOne(p => p.Endereco).HasForeignKey<Transportadora>(p => p.EnderecoId);
            builder.HasOne(p => p.Cliente).WithOne(p => p.Endereco).HasForeignKey<Cliente>(p => p.EnderecoId);
            builder.HasOne(p => p.ClienteCobranca).WithOne(p => p.EnderecoCobranca).HasForeignKey<Cliente>(p => p.EnderecoCobrancaId);
            builder.HasOne(p => p.ClienteEntrega).WithOne(p => p.EnderecoEntrega).HasForeignKey<Cliente>(p => p.EnderecoEntregaId);
        }
    }
}
