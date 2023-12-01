using A4S.Application.Handlers.Pedidos.Request;
using A4S.ERP.Domain.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace A4S.Application.Handlers.Pedidos.Handler
{
    public class BuscarStatusPedidosHandler : IRequestHandler<BuscarStatusPedidosRequest, IActionResult>
    {
        private readonly IPedidoRepository _pedidoRepository;

        public BuscarStatusPedidosHandler(IPedidoRepository pedidoRepository) => _pedidoRepository = pedidoRepository;

        public async Task<IActionResult> Handle(BuscarStatusPedidosRequest request, CancellationToken cancellationToken)
        {
            try
            {
                int total = _pedidoRepository.BuscarTotalStatusPedidosPorFiltro(request);
                return await Task.FromResult(new OkObjectResult(new { total = total }));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(new { error = ex }));
            }
        }
    }
}
