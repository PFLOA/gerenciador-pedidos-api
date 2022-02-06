using Coladel.Application.Handlers.Pedidos.Request;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Coladel.Application.Handlers.Pedidos.Handler
{
    public class CriarPedidoHandler : IRequestHandler<CriarPedidoRequest, IActionResult>
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IClienteRepository _clienteRepository;
        private readonly IItensPedidoRepository _itensPedidoRepository;

        public CriarPedidoHandler(IPedidoRepository pedidoRepository, IClienteRepository clienteRepository, IItensPedidoRepository itensPedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
            _clienteRepository = clienteRepository;
            _itensPedidoRepository = itensPedidoRepository;
        }
        public async Task<IActionResult> Handle(CriarPedidoRequest request, CancellationToken cancellationToken)
        {
            try
            {
                Cliente cliente = _clienteRepository.BuscarPorGuid(request.ClienteGuid);
                Pedido pedido = new Pedido(request);

                pedido.IdCliente = cliente.Id;
                pedido.CalculoComissao(request.PorcentagemComissao);

                short pedidoResultId = _pedidoRepository.Criar(pedido).Id;
                CriarPedido(request.ItenPedido, pedidoResultId);

                return await Task.FromResult(new OkResult());
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(new { error = ex.Message }));
            }
        }

        public void CriarPedido(List<ItensPedido> list, short idPedido)
        {
            list.ForEach((itensPedido) =>
            {
                itensPedido.IdPedido = idPedido;
                _itensPedidoRepository.Criar(itensPedido);
            });
        }
    }
}
