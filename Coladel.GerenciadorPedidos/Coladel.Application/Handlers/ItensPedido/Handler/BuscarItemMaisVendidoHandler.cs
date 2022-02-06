using Coladel.Application.Handlers.ItemPedido.Request;
using Coladel.GerenciadorPedidos.Domain.Interface;
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
                var produto = _pedidoRepository.BuscarProdutoMaisVendidoMesAnoDados(request.Mes, request.Ano);
                return await Task.FromResult(new OkObjectResult(produto));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(new { error = ex.Message }));
            }
        }
    }
}
