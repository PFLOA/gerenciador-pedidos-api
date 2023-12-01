using A4S.ERP.Domain.Filters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace A4S.ERP.Application.Handlers.Transportadoras.Request
{
    public class BuscarTransportadoraPorFiltroRequest : BuscarTransportadoraFilter, IRequest<IActionResult>
    {
    }
}
