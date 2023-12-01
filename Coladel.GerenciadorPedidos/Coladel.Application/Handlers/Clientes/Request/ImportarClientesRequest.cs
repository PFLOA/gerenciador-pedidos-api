using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace A4S.ERP.Application.Handlers.Clientes.Request
{
    public class ImportarClientesRequest : IRequest<IActionResult>
    {
        public IFormFile Arquivo { get; set; }
    }
}
