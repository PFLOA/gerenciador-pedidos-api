using A4S.Core.Results;
using A4S.ERP.Application.Handlers.ContasRecebers.Request;
using A4S.ERP.Application.Handlers.ContasRecebers.Response;
using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace A4S.ERP.Application.Handlers.ContasRecebers.Handlers
{
    public class BuscarContasReceberHandler : IRequestHandler<BuscarContasReceberRequest, IActionResult>
    {
        private readonly IContasReceberRepository _contasReceberRepository;

        public BuscarContasReceberHandler(IContasReceberRepository contasReceberRepository) => 
            _contasReceberRepository = contasReceberRepository;

        public async Task<IActionResult> Handle(BuscarContasReceberRequest request, CancellationToken cancellationToken)
        {
            try
            {
                IQueryable<ContasReceber> contas = _contasReceberRepository.BuscarContasReceberPorFiltro();

                return await Task.FromResult(PaginatedResult<BuscarContasReceberResponse>.CreateSuccess(request, contas, (res) => new BuscarContasReceberResponse(res)));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(new { Errors = new[] { $"{ex.Message}" } }));
            }
        }
    }
}
