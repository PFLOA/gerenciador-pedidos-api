using A4S.ERP.Domain.Filters;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;

namespace A4S.Application.Handlers.Clientes.Request
{
    public class BuscarClientesFiltroRequest : BuscarClientesFiltroFilter, IRequest<IActionResult>
    {
        
    }
}
