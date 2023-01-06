using Coladel.Application.Handlers.Empresas.Request;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Threading;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Coladel.GerenciadorAulas.Domain.Interface;

namespace Coladel.Application.Handlers.Empresas.Handler
{
    public class BuscarEmpresaHandler : IRequestHandler<BuscarEmpresaRequest, IActionResult>
    {
        private readonly IEmpresaRepository _empresaRepository;

        public BuscarEmpresaHandler(IEmpresaRepository empresaRepository) => _empresaRepository = empresaRepository;

        public async Task<IActionResult> Handle(BuscarEmpresaRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var empresa = _empresaRepository.RetornarEmpresa();

                if (empresa is null) return await Task.FromResult(new NotFoundResult());
                return await Task.FromResult(new OkObjectResult(new { OkResult = empresa }));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(new { error = ex.Message }));
            }
        }
    }
}
