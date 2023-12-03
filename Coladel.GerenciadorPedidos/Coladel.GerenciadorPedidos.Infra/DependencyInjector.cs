using A4S.ERP.Domain.Interface;
using A4S.ERP.Infra.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace A4S.ERP.Infra
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
            services.AddScoped<IEmailRepository, EmailRepository>();
            services.AddScoped<IEmpresaRepository, EmpresaRepository>();
            services.AddScoped<IEnvioEmailRepository, EnvioEmailRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<ITransportadoraRepository, TransportadoraRepository>();
            services.AddScoped<ICertificadoRepository, CertificadoRepository>();
            services.AddScoped<ICondicoesPagamentoRepository, CondicoesPagamentoRepository>();
            services.AddScoped<IContasReceberRepository, ContasReceberRepository>();
            services.AddScoped<IControleBoletosRepository, ControleBoletosRepository>();
            services.AddScoped<IRemessasRepository, RemessasRepository>();
        }
    }
}
