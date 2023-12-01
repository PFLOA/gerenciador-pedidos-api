using A4S.Application.Handlers.ItemPedido.Request;
using A4S.ERP.Domain.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Coladel.Application.Handlers.ItemPedido.Handler
{
    public class BuscarItemMaisVendidoHandler : IRequestHandler<BuscarItemMaisVendidoRequest, IActionResult>
    {
        private readonly IPedidoRepository _pedidoRepository;

        public BuscarItemMaisVendidoHandler(IPedidoRepository pedidoRepository) => _pedidoRepository = pedidoRepository;

        public async Task<IActionResult> Handle(BuscarItemMaisVendidoRequest request, CancellationToken cancellationToken)
        {
            try
            {
                return await Task.FromResult(new OkResult());
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(new { error = ex.Message }));
            }
        }
    }
}
