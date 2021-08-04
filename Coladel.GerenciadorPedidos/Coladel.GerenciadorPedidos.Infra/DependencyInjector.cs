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
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ILoginRepository, LoginRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
        }
    }
}
