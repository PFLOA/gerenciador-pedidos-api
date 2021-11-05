using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Coladel.GerenciadorPedidos.Infra.Data
{
    public class UserDbContext : DbContext
    {
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<ItensPedido> ItensPedido { get; set; }

        /// <summary>
        /// Construtor Padrão.
        /// </summary>
        /// <param name="options"></param>
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }
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
