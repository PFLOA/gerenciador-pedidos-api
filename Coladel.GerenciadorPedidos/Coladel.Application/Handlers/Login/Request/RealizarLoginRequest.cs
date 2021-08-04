using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coladel.Application.Handlers.Login.Request
{
    public class RealizarLoginRequest : IRequest<IActionResult>
    {
        public string UserName { get; set; }
        public string Senha { get; set; }
    }
}
