using Coladel.Application.Handlers.Pedidos.Request;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Coladel.Application.Handlers.Pedidos.Handler
{
    public class CriarPedidoHandler : IRequestHandler<CriarPedidoRequest, IActionResult>
    {
        private readonly IPedidoRepository _pedidoRepository;

        public CriarPedidoHandler(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }
        public async Task<IActionResult> Handle(CriarPedidoRequest request, CancellationToken cancellationToken)
        {
            try
            {
                Pedido produto = _pedidoRepository.Criar(request.ToModel());
                return await Task.FromResult(new OkResult());
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(new { error = ex.Message }));
            }
        }
    }
}
