using A4S.ERP.Domain.Body;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace A4S.ERP.Application.Handlers.ContasRecebers.Request
{
    public class CriarContasReceberRequest : CriarContasReceberBody, IRequest<IActionResult>
    {

    }
}
