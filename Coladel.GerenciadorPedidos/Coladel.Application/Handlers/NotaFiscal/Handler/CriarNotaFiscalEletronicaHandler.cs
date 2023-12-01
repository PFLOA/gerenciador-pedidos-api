using A4S.Application.Handlers.NotaFiscal.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace A4S.Application.Handlers.NotaFiscal.Handler
{
    class CriarNotaFiscalEletronicaHandler : IRequestHandler<CriarNotaFiscalEletronicaRequest, IActionResult>
    {
        public async Task<IActionResult> Handle(CriarNotaFiscalEletronicaRequest request, CancellationToken cancellationToken)
        {
            try
            {
                return await Task.FromResult(new OkObjectResult(new { ok = "ok" }));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
