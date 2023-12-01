using A4S.ERP.Domain.Body;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;

namespace A4S.Application.Handlers.Clientes.Request
{
    public class AlterarClienteRequest : AlterarClienteRequestBody, IRequest<IActionResult>
    {
        public Guid Guid { get; set; }
    }
}
