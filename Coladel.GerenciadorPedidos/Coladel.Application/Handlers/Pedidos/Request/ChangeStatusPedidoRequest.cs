using Coladel.GerenciadorPedidos.Domain.Enum;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Coladel.Application.Handlers.Pedidos.Request
{
    public class ChangeStatusPedidoRequest : IRequest<IActionResult>
    {
        public StatusPedido StatusPedido { get; set; }
        public Guid Guid { get; set; }
    }
}
