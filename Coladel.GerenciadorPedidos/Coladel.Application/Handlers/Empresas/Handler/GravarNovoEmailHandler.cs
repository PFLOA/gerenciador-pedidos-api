using A4S.Application.Handlers.Empresas.Request;
using A4S.ERP.Domain.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Threading;
using MediatR;
using System;
using A4S.ERP.Domain.Entidades;

namespace A4S.Application.Handlers.Empresas.Handler
{
    public class GravarNovoEmailHandler : IRequestHandler<GravarNovoEmailRequest, IActionResult>
    {
        private readonly IEnvioEmailRepository _envioEmailRepository;

        public GravarNovoEmailHandler(IEnvioEmailRepository envioEmailRepository) => _envioEmailRepository = envioEmailRepository;

        public async Task<IActionResult> Handle(GravarNovoEmailRequest request, CancellationToken cancellationToken)
        {
            try
            {
                if (request.IsOrigem)
                {
                    var email = _envioEmailRepository.BuscarPorTipoEmail(request.TipoEmail);

                    if (email == null)
                    {
                        _envioEmailRepository.Criar(new EnvioEmail
                        {
                            Assunto = request.Assunto,
                            Mensagem = request.Mensagem,
                            SmtpCliente = request.SmtpCliente,
                            Email = request.Email,
                            Senha = request.Senha,
                            TipoEmail = request.TipoEmail,
                            PortSmtp = request.PortSmtp,
                            IsOrigem = request.IsOrigem,
                            EmpresaId = 1
                        });
                    }
                    else
                    {
                        email.Assunto = request.Assunto;
                        email.Mensagem = request.Mensagem;
                        email.SmtpCliente = request.SmtpCliente;
                        email.Email = request.Email;
                        email.Senha = request.Senha;
                        email.TipoEmail = request.TipoEmail;
                        email.PortSmtp = request.PortSmtp;
                        email.IsOrigem = request.IsOrigem;

                        _envioEmailRepository.Alterar(email);
                    }
                }
                else
                {
                    _envioEmailRepository.Criar(new EnvioEmail
                    {
                        Email = request.Email,
                        TipoEmail = request.TipoEmail,
                        IsOrigem = request.IsOrigem,
                        EmpresaId = 1
                    });
                }

                return await Task.FromResult(new OkObjectResult(new { OkResult = "Sucesso!" }));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(new { error = ex.Message }));
            }
        }
    }
}
