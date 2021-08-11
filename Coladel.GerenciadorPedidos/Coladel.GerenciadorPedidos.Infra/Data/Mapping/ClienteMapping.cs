using Coladel.GerenciadorPedidos.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coladel.GerenciadorPedidos.Infra.Data.Mapping
{
  public class ClienteMapping : IEntityTypeConfiguration<Cliente>
  {
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
      builder.ToTable("cliente");
      builder.HasKey(p => p.Id);
      builder.Property(p => p.Id).HasColumnName("id");
      builder.Property(p => p.Guid).HasColumnName("guid").HasColumnType("uniqueidentifier").HasDefaultValueSql<Guid>();
      builder.Property(p => p.DataCadastro).HasColumnName("data_cadastro");
      builder.Property(p => p.NomeCliente).HasColumnName("nome_cliente");
    }
  }
}
