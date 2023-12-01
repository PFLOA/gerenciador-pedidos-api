using A4S.Application.Handlers.Clientes.Response;
using A4S.Application.Handlers.Pedidos.Request;
using A4S.Application.Handlers.Pedidos.Response;
using A4S.Core.Results;
using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace A4S.Application.Handlers.Pedidos.Handler
{
    public class BuscarPedidosFiltroHandler : IRequestHandler<BuscarPedidosFiltroRequest, IActionResult>
    {
        private readonly IPedidoRepository _pedidoRepository;

        public BuscarPedidosFiltroHandler(IPedidoRepository pedidoRepository) => _pedidoRepository = pedidoRepository;
        public async Task<IActionResult> Handle(BuscarPedidosFiltroRequest request, CancellationToken cancellationToken)
        {
            Func<Pedido, BuscarPedidosFiltroResponse> retorno = Construtor;
            try
            {
                IQueryable<Pedido> pedidos = _pedidoRepository.BuscarPedidosPorFiltro(request);
                return await Task.FromResult(PaginatedResult<BuscarPedidosFiltroResponse>.CreateSuccess(request, pedidos, retorno));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(new { error = ex.Message }));
            }
        }

        public BuscarPedidosFiltroResponse Construtor(Pedido pedido)
        {
            return new BuscarPedidosFiltroResponse(pedido);
        }
    }
}
