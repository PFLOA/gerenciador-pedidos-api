using Coladel.GerenciadorAulas.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Infra.Data.Mapping;
using Coladel.Infra.Data.Mapping;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Claims;

namespace Coladel.GerenciadorPedidos.Infra.Data
{
    public class UserDbContext : DbContext
    {
        private readonly string _connectionString;

        public DbSet<Email> Email { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Contato> Contato { get; set; }
        public DbSet<Telefone> Telefone { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<EnvioEmail> EnvioEmail { get; set; }
        public DbSet<ItensPedido> ItensPedido { get; set; }
        public DbSet<Configuracoes> Configuracoes { get; set; }
        public DbSet<Transportadora> Transportadora { get; set; }

        public UserDbContext(DbContextOptions<UserDbContext> options, IHttpContextAccessor httpContext) : base(options)
        {
            _connectionString = httpContext.HttpContext.User.Claims.Where(p => p.Type == ClaimTypes.Uri).Select(p => p.Value).FirstOrDefault();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_connectionString != null)
                optionsBuilder.UseMySql(_connectionString, ServerVersion.AutoDetect(_connectionString), b => b.MigrationsAssembly("Coladel.GerenciadorPedidos"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmailMapping());
            modelBuilder.ApplyConfiguration(new EmpresaMapping());
            modelBuilder.ApplyConfiguration(new ProdutoMapping());
            modelBuilder.ApplyConfiguration(new ClienteMapping());
            modelBuilder.ApplyConfiguration(new PedidosMapping());
            modelBuilder.ApplyConfiguration(new ContatoMapping());
            modelBuilder.ApplyConfiguration(new TelefoneMapping());
            modelBuilder.ApplyConfiguration(new EnderecoMapping());
            modelBuilder.ApplyConfiguration(new EnvioEmailMapping());
            modelBuilder.ApplyConfiguration(new ItensPedidoMapping());
            modelBuilder.ApplyConfiguration(new ConfiguracoesMapping());
            modelBuilder.ApplyConfiguration(new TransportadoraMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
