using A4S.ERP.Domain.Body;
using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace A4S.Application.Handlers.Clientes.Request
{
  public class CriarClienteRequest : CriarClienteRequestBody, IRequest<IActionResult> { }
}
