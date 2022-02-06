using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Infra.Data.Mapping;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Claims;

namespace Coladel.GerenciadorPedidos.Infra.Data
{
    public class UserDbContext : DbContext
    {
        private readonly string _connectionString;

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<ItensPedido> ItensPedido { get; set; }

        /// <summary>
        /// Construtor Padrão.
        /// </summary>
        /// <param name="options"></param>
        public UserDbContext(DbContextOptions<UserDbContext> options, IHttpContextAccessor httpContext) : base(options)
        {
            _connectionString = httpContext.HttpContext.User.Claims.Where(p => p.Type == ClaimTypes.Uri)
                            .Select(p => p.Value).FirstOrDefault();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(_connectionString, ServerVersion.AutoDetect(_connectionString), b => b.MigrationsAssembly("Coladel.GerenciadorPedidos"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoMapping());
            modelBuilder.ApplyConfiguration(new ClienteMapping());
            modelBuilder.ApplyConfiguration(new PedidosMapping());
            modelBuilder.ApplyConfiguration(new ItensPedidoMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
