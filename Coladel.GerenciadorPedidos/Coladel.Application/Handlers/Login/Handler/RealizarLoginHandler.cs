using Coladel.Application.Handlers.Login.Request;
using Coladel.Application.Handlers.Login.Response;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Interface;
using Coladel.GerenciadorPedidos.JWT;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Coladel.Application.Handlers.Login.Handler
{
    public class RealizarLoginHandler : IRequestHandler<RealizarLoginRequest, IActionResult>
    {
        private readonly ILoginRepository _loginRepository;
        public RealizarLoginHandler(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }
        public async Task<IActionResult> Handle(RealizarLoginRequest request, CancellationToken cancellationToken)
        {
            try
            {
                if (string.IsNullOrEmpty(request.UserName) || string.IsNullOrEmpty(request.Senha)) return await Task.FromResult(new BadRequestObjectResult(new { Errors = new[] { $"Usuario ou Senha vazios !" } }));
                Usuario usuario = _loginRepository.LoginUser(request.UserName, request.Senha);

                if (usuario == null) return new NotFoundObjectResult(new { Errors = new[] { "Usuário ou senha incorretos." } });

                string generatedToken = RetornoJwt.RetornoJwtString(usuario);

                return await Task.FromResult(new OkObjectResult(new { Token = generatedToken, Usuario = new RealizarLoginResponse(usuario) }));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(new { Errors = new[] { $"{ex.Message}" } }));
            }
        }
    }
}
