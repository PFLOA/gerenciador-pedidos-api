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
        private readonly IClienteRepository _clienteRepository;
        private readonly IProdutoRepository _produtoRepository;

        public CriarPedidoHandler(IPedidoRepository pedidoRepository, IClienteRepository clienteRepository, IProdutoRepository produtoRepository)
        {
            _pedidoRepository = pedidoRepository;
            _clienteRepository = clienteRepository;
            _produtoRepository = produtoRepository;
        }
        public async Task<IActionResult> Handle(CriarPedidoRequest request, CancellationToken cancellationToken)
        {
            try
            {
                request.Cliente = _clienteRepository.BuscarPorGuid(request.ClienteGuid);
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
