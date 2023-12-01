using A4S.Application.Handlers.Login.Response;
using Microsoft.AspNetCore.Mvc;
using A4S.Core.Interfaces;
using MediatR;

namespace A4S.Application.Handlers.Login.Request
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
