using Coladel.GerenciadorPedidos.Domain.Body;
using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace Coladel.Application.Handlers.Clientes.Request
{
  public class CriarClienteRequest : CriarClienteRequestBody, IRequest<IActionResult> { }
}
