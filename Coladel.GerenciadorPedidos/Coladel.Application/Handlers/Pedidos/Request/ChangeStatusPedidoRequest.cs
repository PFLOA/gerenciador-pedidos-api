using A4S.ERP.Domain.Enum;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;

namespace A4S.Application.Handlers.Pedidos.Request
{
    public class ChangeStatusPedidoRequest : IRequest<IActionResult>
    {
        public StatusPedido StatusPedido { get; set; }
        public Guid Guid { get; set; }
    }
}
