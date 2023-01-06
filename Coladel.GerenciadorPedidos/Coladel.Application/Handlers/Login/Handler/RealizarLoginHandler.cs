using Coladel.Application.Handlers.Login.Response;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Interface;
using Coladel.Application.Handlers.Login.Request;
using Coladel.GerenciadorPedidos.JWT;
using Coladel.Core.Interfaces;
using System.Threading.Tasks;
using Coladel.Core.Enum;
using System.Threading;
using Coladel.Core;
using MediatR;
using System;

namespace Coladel.Application.Handlers.Login.Handler
{
    public class RealizarLoginHandler : IRequestHandler<RealizarLoginRequest, IOperationResult<RealizarLoginResponse>>
    {
        private readonly ILoginRepository _loginRepository;

        public RealizarLoginHandler(ILoginRepository loginRepository) => _loginRepository = loginRepository;

        public async Task<IOperationResult<RealizarLoginResponse>> Handle(RealizarLoginRequest request, CancellationToken cancellationToken)
        {
            try
            {
                if (string.IsNullOrEmpty(request.UserName) || string.IsNullOrEmpty(request.Senha)) return await Task.FromResult(OperationResult<RealizarLoginResponse>.Create(EnumTypeResult.InvalidInput).AddMessage("Valor do usuário ou senha inválidos, verifique as credenciais"));
                
                Usuario usuario = _loginRepository.LoginUser(request.UserName, request.Senha);

                if (usuario == null) return await Task.FromResult(OperationResult<RealizarLoginResponse>.Create(EnumTypeResult.NotFound).AddMessage("Usuário não Encontrado !"));

                string generatedToken = RetornoJwt.RetornoJwtString(usuario);

                return await Task.FromResult(OperationResult<RealizarLoginResponse>.Create(EnumTypeResult.Ok, new RealizarLoginResponse(usuario, generatedToken)));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(OperationResult<RealizarLoginResponse>.Create(EnumTypeResult.InternalError).AddMessage(ex.Message));
            }
        }
    }
}
