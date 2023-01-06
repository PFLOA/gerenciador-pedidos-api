using Coladel.GerenciadorAulas.Domain.Body;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Coladel.Application.Handlers.Clientes.Request
{
    public class AlterarClienteRequest : AlterarClienteRequestBody, IRequest<IActionResult>
    {
        public Guid Guid { get; set; }
    }
}
