using A4S.Application.Handlers.Pedidos.Request;
using A4S.ERP.Domain.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace A4S.Application.Handlers.Pedidos.Handler
{
    public class RemoverPedidoHandler : IRequestHandler<RemoverPedidoRequest, IActionResult>
    {
        private readonly IPedidoRepository _pedidoRepository;

        public RemoverPedidoHandler(IPedidoRepository pedidoRepository) => _pedidoRepository = pedidoRepository;
        public async Task<IActionResult> Handle(RemoverPedidoRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var pedido = _pedidoRepository.BuscarPorGuid(request.Guid);
                if (pedido is null) return await Task.FromResult(new NotFoundObjectResult(new { error = $"Pedido com guid informado não encontrado." }));
                _pedidoRepository.Remover(pedido);

                return await Task.FromResult(new OkResult());
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(new { error = ex.Message }));
            }
        }
    }
}
