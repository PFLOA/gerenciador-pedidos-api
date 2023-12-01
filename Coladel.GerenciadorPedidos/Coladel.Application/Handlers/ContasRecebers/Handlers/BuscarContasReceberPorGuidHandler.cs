using A4S.ERP.Application.Handlers.ContasRecebers.Request;
using A4S.ERP.Application.Handlers.ContasRecebers.Response;
using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace A4S.ERP.Application.Handlers.ContasRecebers.Handlers
{
    public class BuscarContasReceberPorGuidHandler : IRequestHandler<BuscarContasReceberPorGuidRequest, IActionResult>
    {
        private readonly IContasReceberRepository _contasReceberRepository;

        public BuscarContasReceberPorGuidHandler(IContasReceberRepository contasReceberRepository)
        {
            _contasReceberRepository = contasReceberRepository;
        }

        public async Task<IActionResult> Handle(BuscarContasReceberPorGuidRequest request, CancellationToken cancellationToken)
        {
            try
            {
                ContasReceber cr = _contasReceberRepository.BuscarPorGuid(request.Guid);

                if (cr is null) return await Task.FromResult(new NotFoundResult());
                return await Task.FromResult(new OkObjectResult(new { OkResult = new BuscarContasReceberPorGuidResponse(cr) }));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(new { Errors = new[] { $"{ex.Message}" } }));
            }
        }
    }
}
