using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace A4S.ERP.Application.Handlers.Empresas.Request
{
    public class CadastrarCertificadoRequest : IRequest<IActionResult>
    {
        public string Senha { get; set; }
        
        public bool EmiteNfe { get; set; }
        public bool Padrao { get; set; }
        
        public IFormFile Certificado { get; set; }
        public DateTime DataValidade { get; set; }
    }
}
