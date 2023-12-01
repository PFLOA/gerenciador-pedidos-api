using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace A4S.ERP.Infra.Data.Mapping
{
    public class FornecedorMapping : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("fornecedor");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("id").ValueGeneratedOnAdd(); 

            builder.Property(p => p.ContatoId).HasColumnName("id_contato");
            builder.Property(p => p.IdEndereco).HasColumnName("id_endereco");
            builder.Property(p => p.Guid).HasColumnName("guid");
            builder.Property(p => p.DataCadastro).HasColumnName("data_cadastro");
            builder.Property(p => p.NomeFantasia).HasColumnName("nome_fantasia").HasColumnType("varchar(126)");
            builder.Property(p => p.Observacao).HasColumnName("observacao").HasColumnType("varchar(256)");
            builder.Property(p => p.CodTransportadora).HasColumnName("cod_transportadora").HasColumnType("varchar(10)");
            builder.Property(p => p.Website).HasColumnName("website").HasColumnType("varchar(100)");
            builder.Property(p => p.Cnpj).HasColumnName("cnpj").HasColumnType("varchar(14)");
            builder.Property(p => p.InscricaoEstadual).HasColumnName("inscricao_estadual").HasColumnType("varchar(14)");
            builder.Property(p => p.RazaoSocial).HasColumnName("razao_social").HasColumnType("varchar(256)");
            builder.Property(p => p.TipoPessoa).HasColumnName("tipo_pessoa").HasColumnType("varchar(8)").HasConversion<string>();
        }
    }
}
