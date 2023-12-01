using A4S.ERP.Domain.Filters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace A4S.ERP.Application.Handlers.ContasRecebers.Request
{
    public class BuscarContasReceberRequest : BuscarContasReceberFilter, IRequest<IActionResult>
    {
    }
}
