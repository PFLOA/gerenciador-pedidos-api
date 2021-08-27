using Coladel.GerenciadorPedidos.Domain.Body;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Coladel.Application.Handlers.Pedidos.Request
{
    public class CriarPedidoRequest : CriarPedidoBody, IRequest<IActionResult> { }
}
