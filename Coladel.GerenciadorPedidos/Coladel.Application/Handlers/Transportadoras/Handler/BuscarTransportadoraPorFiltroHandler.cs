using A4S.Application.Handlers.Transportadoras.Response;
using A4S.Core.Results;
using A4S.ERP.Application.Handlers.Transportadoras.Request;
using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace A4S.Application.Handlers.Transportadoras.Handler
{
    public class BuscarTransportadoraPorFiltroHandler : IRequestHandler<BuscarTransportadoraPorFiltroRequest, IActionResult>
    {
        private readonly ITransportadoraRepository _transportadoraRepository;

        public BuscarTransportadoraPorFiltroHandler(ITransportadoraRepository transportadoraRepository) =>
            _transportadoraRepository = transportadoraRepository;

        public async Task<IActionResult> Handle(BuscarTransportadoraPorFiltroRequest request, CancellationToken cancellationToken)
        {
            Func<Transportadora, BuscarTransportadoraPorFiltroResponse> retorno = Construtor;

            try
            {
                IQueryable<Transportadora> transportadora = _transportadoraRepository.BuscarTransportadoraPorFiltro(request);

                return await Task.FromResult(PaginatedResult<BuscarTransportadoraPorFiltroResponse>.CreateSuccess(request, transportadora, retorno));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(new { Errors = new[] { $"{ex.Message}" } }));
            }
        }

        public BuscarTransportadoraPorFiltroResponse Construtor(Transportadora transportadora)
        {
            return new BuscarTransportadoraPorFiltroResponse(transportadora);
        }
    }
}
