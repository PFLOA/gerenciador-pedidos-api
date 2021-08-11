using Coladel.GerenciadorPedidos.Domain.Filters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Coladel.Application.Handlers.Clientes.Request
{
    public class BuscarClientesFiltroRequest : BuscarClientesFiltroFilter, IRequest<IActionResult>
    {
    }
}
