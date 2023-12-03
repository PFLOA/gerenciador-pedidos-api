using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
            builder.Property(p => p.DataCadastro).HasColumnName("data_cadastro");
            builder.Property(p => p.EnderecoId).HasColumnName("id_endereco");
            builder.Property(p => p.TipoClienteId).HasColumnName("id_tipo_cliente");
            builder.Property(p => p.EnderecoCobrancaId).HasColumnName("id_endereco_cobranca");
            builder.Property(p => p.EnderecoEntregaId).HasColumnName("id_endereco_entrega");
            builder.Property(p => p.RamoAtividadeId).HasColumnName("id_ramo_atividade");
            builder.Property(p => p.DocumentoPrincipal).HasColumnName("cnpj").HasColumnType("varchar(14)");
            builder.Property(p => p.DocumentoSecundario).HasColumnName("inscricao_estadual").HasColumnType("varchar(12)");
            builder.Property(p => p.RazaoSocial).HasColumnName("razao_social").HasColumnType("varchar(256)");
            builder.Property(p => p.NomeFantasia).HasColumnName("nome_fantasia").HasColumnType("varchar(256)");
            builder.Property(p => p.TipoPessoa).HasColumnName("tipo_pessoa").HasConversion<string>();
            builder.Property(p => p.InscricaoMunicipal).HasColumnName("inscricao_municipal");
            builder.Property(p => p.Cnae).HasColumnName("cnae");
            builder.Property(p => p.InscricaoSuframa).HasColumnName("inscricao_suframa");
            builder.Property(p => p.Site).HasColumnName("site");
            builder.Property(p => p.Observacoes).HasColumnName("observacoes");

            builder.HasOne(p => p.Endereco).WithOne(p => p.Cliente).HasForeignKey<Cliente>(p => p.EnderecoId);
        }
    }
}
