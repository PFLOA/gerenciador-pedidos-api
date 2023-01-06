using Coladel.Application.Handlers.Login.Response;
using Microsoft.AspNetCore.Mvc;
using Coladel.Core.Interfaces;
using MediatR;

namespace Coladel.Application.Handlers.Login.Request
{
    public class RealizarLoginRequest : IRequest<IOperationResult<RealizarLoginResponse>>
    {
        public string UserName { get; set; }
        public string Senha { get; set; }

        public RealizarLoginRequest()
        {

        }

        public RealizarLoginRequest(string userName, string senha)
        {
            UserName = userName;
            Senha = senha;
        }
    }
}
