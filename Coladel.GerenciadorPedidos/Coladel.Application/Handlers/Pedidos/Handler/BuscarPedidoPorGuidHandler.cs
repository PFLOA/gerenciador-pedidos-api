using Coladel.Application.Handlers.Pedidos.Request;
using Coladel.Application.Handlers.Pedidos.Response;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Coladel.Application.Handlers.Pedidos.Handler
{
    public class BuscarPedidoPorGuidHandler : IRequestHandler<BuscarPedidoPorGuidRequest, IActionResult>
    {
        private readonly IPedidoRepository _pedidoRepository;

        public BuscarPedidoPorGuidHandler(IPedidoRepository pedidoRepository) => _pedidoRepository = pedidoRepository;

        public async Task<IActionResult> Handle(BuscarPedidoPorGuidRequest request, CancellationToken cancellationToken)
        {
            try
            {
                Pedido pedido = _pedidoRepository.BuscarPorGuid(request.Guid);
                if (pedido is null) return await Task.FromResult(new NotFoundResult());
                return await Task.FromResult(new OkObjectResult(new { OkResult = new BuscarPedidoPorGuidResponse(pedido) }));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(new { error = ex.Message }));
            }
        }
    }
}
