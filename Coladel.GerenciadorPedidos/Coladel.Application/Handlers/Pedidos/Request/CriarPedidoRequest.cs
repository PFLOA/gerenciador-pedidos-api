using A4S.ERP.Domain.Body;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace A4S.Application.Handlers.Pedidos.Request
{
    public class CriarPedidoRequest : CriarPedidoBody, IRequest<IActionResult> { }
}
