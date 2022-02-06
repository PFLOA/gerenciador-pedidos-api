using Coladel.GerenciadorPedidos.Domain.Interface;
using Coladel.GerenciadorPedidos.Infra.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Coladel.GerenciadorPedidos.Infra
{
    public static class DependencyInjector
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<ILoginRepository, LoginRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IItensPedidoRepository, ItensPedidoRepository>();
        }
    }
}
