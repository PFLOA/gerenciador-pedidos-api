using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Coladel.Application.Handlers.Pedidos.Request
{
    public class BuscarPedidoPorGuidRequest : IRequest<IActionResult>
    {
        public Guid Guid { get; set; }
    }
}
