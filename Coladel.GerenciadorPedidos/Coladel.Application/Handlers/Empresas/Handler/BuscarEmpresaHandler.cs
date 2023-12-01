using A4S.Application.Handlers.Empresas.Request;
using A4S.ERP.Application.Handlers.Empresas.Response;
using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace A4S.Application.Handlers.Empresas.Handler
{
    public class BuscarEmpresaHandler : IRequestHandler<BuscarEmpresaRequest, IActionResult>
    {
        private readonly IEmpresaRepository _empresaRepository;

        public BuscarEmpresaHandler(IEmpresaRepository empresaRepository) => _empresaRepository = empresaRepository;

        public async Task<IActionResult> Handle(BuscarEmpresaRequest request, CancellationToken cancellationToken)
        {
            try
            {
                Empresa empresa = _empresaRepository.RetornarEmpresa();

                if (empresa is null) return await Task.FromResult(new NotFoundResult());

                return await Task.FromResult(new OkObjectResult(new { result = new BuscarEmpresaResponse(empresa) }));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(new { error = ex.Message }));
            }
        }
    }
}
