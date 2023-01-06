using Coladel.Application.Handlers.Dashboard.Request;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Threading;
using MediatR;
using System;
using Coladel.GerenciadorPedidos.Domain.Interface;
using Coladel.GerenciadorPedidos.Domain.Filters;
using System.Linq;

namespace Coladel.Application.Handlers.Dashboard.Handler
{
    public class RetornarTotalPedidoHandler : IRequestHandler<RetornarTotalPedidoRequest, IActionResult>
    {
        private readonly IPedidoRepository _pedidoRepository;

        public RetornarTotalPedidoHandler(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public async Task<IActionResult> Handle(RetornarTotalPedidoRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var lista = _pedidoRepository.BuscarPedidosPorFiltro(new BuscarPedidosFiltroFilter
                {
                    Ano = request.Ano,
                    Mes = request.Mes,
                    Dia = request.Dia,
                    StatusPedido = request.StatusPedido
                });

                if (request.Mes == 1)
                {
                    request.Mes = 12;
                    request.Ano -= 1;
                }
                else
                {
                    request.Mes -= 1;
                }

                var listaMesAnterior = _pedidoRepository.BuscarPedidosPorFiltro(new BuscarPedidosFiltroFilter
                {
                    Ano = request.Ano,
                    Mes = request.Mes,
                    Dia = request.Dia,
                    StatusPedido = request.StatusPedido
                });

                var total = lista.Sum(p => p.Total);
                var totalMesAnterior = listaMesAnterior.Sum(p => p.Total);

                return await Task.FromResult(new OkObjectResult(new { total = total, totalMesAnterior = totalMesAnterior, pedidos = lista.Count(), pedidosMesAnterior = listaMesAnterior.Count() }));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(new { error = ex.Message }));
            }
        }
    }
}
