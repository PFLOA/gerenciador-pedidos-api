using Microsoft.AspNetCore.Mvc;
using MediatR;
using Coladel.GerenciadorAulas.Domain.Enum;

namespace Coladel.Application.Handlers.Empresas.Request
{
    public class GravarNovoEmailRequest : IRequest<IActionResult>
    {
        public string Email { get; set; }
        public int PortSmtp { get; set; } = 587;
        public string SmtpCliente { get; set; }
        public string Assunto { get; set; }
        public string Mensagem { get; set; }
        public string Senha { get; set; }
        public bool IsOrigem { get; set; }
        public TipoEmail TipoEmail { get; set; }
    }
}
