using A4S.Application.Handlers.Pedidos.Request;
using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace A4S.Application.Handlers.Pedidos.Handler
{
    public class CriarPedidoHandler : IRequestHandler<CriarPedidoRequest, IActionResult>
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IClienteRepository _clienteRepository;

        public CriarPedidoHandler(IPedidoRepository pedidoRepository, IClienteRepository clienteRepository)
        {
            _pedidoRepository = pedidoRepository;
            _clienteRepository = clienteRepository;
        }

        public async Task<IActionResult> Handle(CriarPedidoRequest request, CancellationToken cancellationToken)
        {
            try
            {
                Cliente cliente = _clienteRepository.BuscarPorGuid(request.ClienteGuid);

                Pedido pedido = new Pedido(request);

                pedido.ClienteId = cliente.Id;

                pedido.CalculoComissao(request.PorcentagemComissao);

                short pedidoResultId = _pedidoRepository.Criar(pedido).Id;

                CriarPedido(request.ItensPedido, pedidoResultId);

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
            });
        }
    }
}
