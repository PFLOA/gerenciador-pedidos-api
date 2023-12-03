using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coladel.Infra.Data.Mapping
{
    public class ConfiguracoesMapping : IEntityTypeConfiguration<Configuracoes>
    {
        public void Configure(EntityTypeBuilder<Configuracoes> builder)
        {
            builder.ToTable("configuracoes");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(p => p.Guid).HasColumnName("guid");
            builder.Property(p => p.DataCadastro).HasColumnName("data_cadastro");
            builder.Property(p => p.MostrarComissaoDashboard).HasColumnName("mostrar_comissao");
            builder.Property(p => p.EnviarEmailTransportadora).HasColumnName("enviar_transportadora");
            builder.Property(p => p.EnviarEmailLogistica).HasColumnName("enviar_logistica");
        }
    }
}
