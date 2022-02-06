using Coladel.GerenciadorPedidos.Domain.Filters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Coladel.Application.Handlers.Pedidos.Request
{
    public class BuscarStatusPedidosRequest : BuscarStatusPedidoFilter, IRequest<IActionResult>
    {
        
    }
}
