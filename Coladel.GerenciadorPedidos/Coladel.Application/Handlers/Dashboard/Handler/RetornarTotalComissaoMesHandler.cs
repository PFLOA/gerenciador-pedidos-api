using Coladel.Application.Handlers.Dashboard.Request;
using Coladel.GerenciadorPedidos.Domain.Interface;
using Coladel.GerenciadorPedidos.Domain.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;
using MediatR;
using System;

namespace Coladel.Application.Handlers.Dashboard.Handler
{
    public class RetornarTotalComissaoMesHandler : IRequestHandler<RetornarTotalComissaoMesRequest, IActionResult>
    {
        private readonly IPedidoRepository _pedidoRepository;

        public RetornarTotalComissaoMesHandler(IPedidoRepository pedidoRepository) => _pedidoRepository = pedidoRepository;

        public async Task<IActionResult> Handle(RetornarTotalComissaoMesRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var produto = _pedidoRepository.BuscarPedidosPorFiltro(new BuscarPedidosFiltroFilter
                {
                    Ano = request.Ano,
                    Mes = request.Mes,
                    Dia = request.Dia
                });

                if (request.Mes == 1)
                {
                    request.Mes = 12;
                    request.Ano -= 1;
                } else
                {
                    request.Mes -= 1;
                }

                var produtoMesAnterior = _pedidoRepository.BuscarPedidosPorFiltro(new BuscarPedidosFiltroFilter
                {
                    Ano = request.Ano,
                    Mes = request.Mes,
                    Dia = request.Dia
                });

                decimal total = 0;
                decimal totalMesAnterior = 0;

                produto.ToList().ForEach(x => total += x.TotalComissao);
                produtoMesAnterior.ToList().ForEach(x => totalMesAnterior += x.TotalComissao);

                return await Task.FromResult(new OkObjectResult(new { total = total, totalMesAnterior = totalMesAnterior }));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(new { error = ex.Message }));
            }
        }
    }
}
