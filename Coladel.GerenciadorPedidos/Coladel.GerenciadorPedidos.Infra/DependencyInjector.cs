<<<<<<< HEAD
﻿using A4S.ERP.Domain.Interface;
using A4S.ERP.Infra.Repository;
=======
﻿using Coladel.GerenciadorPedidos.Domain.Interface;
using Coladel.GerenciadorPedidos.Infra.Repository;
using Coladel.GerenciadorAulas.Domain.Interface;
>>>>>>> 0d898aa9a598847d35bd4a65ea35f8eb6f5798b6
using Microsoft.Extensions.DependencyInjection;
using Coladel.Infra.Repository;

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
<<<<<<< HEAD
=======
            services.AddScoped<IItensPedidoRepository, ItensPedidoRepository>();
>>>>>>> 0d898aa9a598847d35bd4a65ea35f8eb6f5798b6
            services.AddScoped<IEmailRepository, EmailRepository>();
            services.AddScoped<IEmpresaRepository, EmpresaRepository>();
            services.AddScoped<IEnvioEmailRepository, EnvioEmailRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
<<<<<<< HEAD
            services.AddScoped<ITransportadoraRepository, TransportadoraRepository>();
            services.AddScoped<ICertificadoRepository, CertificadoRepository>();
            services.AddScoped<ICondicoesPagamentoRepository, CondicoesPagamentoRepository>();
            services.AddScoped<IContasReceberRepository, ContasReceberRepository>();
            services.AddScoped<IControleBoletosRepository, ControleBoletosRepository>();
            services.AddScoped<IRemessasRepository, RemessasRepository>();
=======
>>>>>>> 0d898aa9a598847d35bd4a65ea35f8eb6f5798b6
        }
    }
}
