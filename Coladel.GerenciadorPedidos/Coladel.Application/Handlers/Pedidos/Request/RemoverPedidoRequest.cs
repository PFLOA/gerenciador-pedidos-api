using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Coladel.Application.Handlers.Pedidos.Request
{
    public class RemoverPedidoRequest : IRequest<IActionResult>
    {
        public Guid Guid { get; set; }
    }
}
