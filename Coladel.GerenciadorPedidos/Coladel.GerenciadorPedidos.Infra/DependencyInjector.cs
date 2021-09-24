using Coladel.Application.Handlers.Login.Handler;
using Coladel.Application.Handlers.Login.Handler.Usuarios.Request;
using Coladel.Application.Handlers.Login.Request;
using Coladel.Application.Handlers.Usuarios.Handler;
using Coladel.GerenciadorPedidos.Domain.Interface;
using Coladel.GerenciadorPedidos.Infra.Repository;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Coladel.GerenciadorPedidos.Infra
{
    public static class DependencyInjector
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddSingleton<ILoginRepository, LoginRepository>();
            services.AddSingleton<IUsuarioRepository, UsuarioRepository>();
            services.AddSingleton<IProdutoRepository, ProdutoRepository>();
            services.AddSingleton<IPedidoRepository, PedidoRepository>();
            services.AddSingleton<IClienteRepository, ClienteRepository>();
            services.AddSingleton<IItensPedidoRepository, ItensPedidoRepository>();
        }
    }
}
