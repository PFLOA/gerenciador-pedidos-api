using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Coladel.Application.Handlers.Login.Handler.Usuarios.Request
{
    public class CriarUsuarioRequest : IRequest<IActionResult>
    {
        public Guid Guid { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
