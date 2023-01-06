using Coladel.GerenciadorAulas.Domain.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace Coladel.Application.Handlers.Empresas.Request
{
    public class EnviarEmailRequest : IRequest<IActionResult>
    {
        public string Cliente { get; set; }
        public string Nf { get; set; }
        public IFormFile File { get; set; }
    }
}
