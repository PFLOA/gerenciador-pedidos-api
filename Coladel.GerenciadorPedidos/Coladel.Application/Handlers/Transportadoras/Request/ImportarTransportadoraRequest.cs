using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace A4S.ERP.Application.Handlers.Transportadoras.Request
{
    public class ImportarTransportadoraRequest : IRequest<IActionResult>
    {
        public IFormFile Arquivo { get; set; }
    }
}
