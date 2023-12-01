using Microsoft.EntityFrameworkCore.Metadata.Builders;
<<<<<<< HEAD
using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace A4S.ERP.Infra.Data.Mapping
=======
using Coladel.GerenciadorAulas.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Coladel.Infra.Data.Mapping
>>>>>>> 0d898aa9a598847d35bd4a65ea35f8eb6f5798b6
{
    public class TelefoneMapping : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
            builder.ToTable("telefones");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(p => p.Guid).HasColumnName("guid");
            builder.Property(p => p.Tipo).HasColumnName("tipo");
            builder.Property(p => p.Numero).HasColumnName("numero");
            builder.Property(p => p.Descricao).HasColumnName("descricao");
            builder.Property(p => p.IdCliente).HasColumnName("id_cliente");
            builder.Property(p => p.DataCadastro).HasColumnName("data_cadastro");
        }
    }
}
