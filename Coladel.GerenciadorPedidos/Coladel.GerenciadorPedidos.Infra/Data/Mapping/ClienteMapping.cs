using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Coladel.GerenciadorPedidos.Infra.Data.Mapping
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("cliente");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(p => p.Guid).HasColumnName("guid");
            builder.Property(p => p.IdEndereco).HasColumnName("id_endereco");
            builder.Property(p => p.DataCadastro).HasColumnName("data_cadastro");
            builder.Property(p => p.Cnpj).HasColumnName("cnpj").HasColumnType("varchar(14)");
            builder.Property(p => p.Ie).HasColumnName("inscricao_estadual").HasColumnType("varchar(12)");
            builder.Property(p => p.NomeCliente).HasColumnName("nome_cliente").HasColumnType("varchar(256)");
            builder.Property(p => p.NomeFantasia).HasColumnName("nome_fantasia").HasColumnType("varchar(256)");

            builder.HasMany(p => p.Emails).WithOne(p => p.Cliente).HasForeignKey(p => p.IdCliente);
            builder.HasMany(p => p.Telefones).WithOne(p => p.Cliente).HasForeignKey(p => p.IdCliente);
            builder.HasOne(p => p.Endereco).WithOne(p => p.Cliente).HasForeignKey<Cliente>(p => p.IdEndereco);
        }
    }
}
