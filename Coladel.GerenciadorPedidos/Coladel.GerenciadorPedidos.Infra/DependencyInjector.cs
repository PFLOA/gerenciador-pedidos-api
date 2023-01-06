using Coladel.GerenciadorPedidos.Domain.Interface;
using Coladel.GerenciadorPedidos.Infra.Repository;
using Coladel.GerenciadorAulas.Domain.Interface;
using Microsoft.Extensions.DependencyInjection;
using Coladel.Infra.Repository;

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
            services.AddScoped<IEmailRepository, EmailRepository>();
            services.AddScoped<IEmpresaRepository, EmpresaRepository>();
            services.AddScoped<IEnvioEmailRepository, EnvioEmailRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
        }
    }
}
