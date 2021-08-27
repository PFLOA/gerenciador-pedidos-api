using Coladel.Application.Handlers.Pedidos.Request;
using Coladel.Application.Handlers.Pedidos.Response;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Coladel.Application.Handlers.Pedidos.Handler
{
    public class BuscarPedidosFiltroHandler : IRequestHandler<BuscarPedidosFiltroRequest, IActionResult>
    {
        public async Task<IActionResult> Handle(BuscarPedidosFiltroRequest request, CancellationToken cancellationToken)
        {
            try
            {
                return await Task.FromResult(new OkResult());
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestResult());
            }
        }
        public BuscarPedidosFiltroResponse Construtor(Pedido Pedido)
        {
            return new BuscarPedidosFiltroResponse();
        }
    }
}
