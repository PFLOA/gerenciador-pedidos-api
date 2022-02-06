using Coladel.Application.Handlers.Pedidos.Request;
using Coladel.Application.Handlers.Pedidos.Response;
using Coladel.GerenciadorPedidos.Domain.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Coladel.Application.Handlers.Pedidos.Handler
{
    public class ChangeStatusPedidoHandler : IRequestHandler<ChangeStatusPedidoRequest, IActionResult>
    {
        private readonly IPedidoRepository _pedidoRepository;

        public ChangeStatusPedidoHandler(IPedidoRepository pedidoRepository) => _pedidoRepository = pedidoRepository;

        public async Task<IActionResult> Handle(ChangeStatusPedidoRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var pedido = _pedidoRepository.BuscarPorGuid(request.Guid);
                if (pedido is null) return await Task.FromResult(new NotFoundResult());

                switch (request.StatusPedido)
                {
                    case GerenciadorPedidos.Domain.Enum.StatusPedido.ENTREGUE:
                        pedido.EntregarPedido();
                        break;
                    case GerenciadorPedidos.Domain.Enum.StatusPedido.ATRASO:
                        pedido.EmAtraso();
                        break;
                    case GerenciadorPedidos.Domain.Enum.StatusPedido.CANCELADO:
                        pedido.Cancelar();
                        break;
                    default:
                        break;
                }

                _pedidoRepository.Alterar(pedido);

                return await Task.FromResult(new OkObjectResult(new { OkResult = new BuscarPedidoPorGuidResponse(pedido) }));
            }
            catch (Exception ex)
            {

                return await Task.FromResult(new BadRequestObjectResult(new { error = ex.Message }));
            }
        }
    }
}
