using A4S.ERP.Application.Handlers.Empresas.Request;
using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Interface;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace A4S.ERP.Application.Handlers.Empresas.Handler
{
    public class CadastrarCertificadoHandler : IRequestHandler<CadastrarCertificadoRequest, IActionResult>
    {
        private readonly IHttpContextAccessor _httpContext;
        private readonly ICertificadoRepository _certificadoRepository;

        public CadastrarCertificadoHandler(ICertificadoRepository certificadoRepository, IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
            _certificadoRepository = certificadoRepository;
        }

        public async Task<IActionResult> Handle(CadastrarCertificadoRequest request, CancellationToken cancellationToken)
        {
            try
            {
                _certificadoRepository.Criar(new Certificado
                {
                    EmiteNfe = request.EmiteNfe,
                    DataValidade = request.DataValidade,
                    EmpresaId = Convert.ToInt16(_httpContext.HttpContext.User.Claims.Where(p => p.Type == "empresa_id").Select(p => p.Value).FirstOrDefault()),
                    hash = _certificadoRepository.GerarHash(request.Senha),
                    Padrao = request.Padrao,
                    CertificadoPrivado = await _certificadoRepository.SalvarBlob(request.Certificado)
                }) ;

                return await Task.FromResult(new OkObjectResult(new { result = "certificado salvo !" }));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(new { error = ex.Message }));
            }
        }
    }
}
