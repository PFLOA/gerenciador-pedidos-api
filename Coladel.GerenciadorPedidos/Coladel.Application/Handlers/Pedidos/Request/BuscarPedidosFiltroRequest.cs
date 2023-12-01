using A4S.ERP.Domain.Filters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace A4S.Application.Handlers.Pedidos.Request
{
    public class BuscarPedidosFiltroRequest : BuscarPedidosFiltroFilter, IRequest<IActionResult> { }
}
