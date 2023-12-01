using A4S.ERP.Application.Handlers.CondicoesPagamentos.Request;
using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace A4S.ERP.Application.Handlers.CondicoesPagamentos.Handler
{
    public class BuscarCondicoesPagamentoHandler : IRequestHandler<BuscarCondicoesPagamentoRequest, IActionResult>
    {
        private readonly ICondicoesPagamentoRepository _condicoesPagamento;

        public BuscarCondicoesPagamentoHandler(ICondicoesPagamentoRepository condicoesPagamento)
        {
            _condicoesPagamento = condicoesPagamento;
        }

        public async Task<IActionResult> Handle(BuscarCondicoesPagamentoRequest request, CancellationToken cancellationToken)
        {
            try
            {
                IList<CondicoesPagamento> c = _condicoesPagamento.BuscarCondicoesPagamento();

                return await Task.FromResult(new OkObjectResult(new { data = c }));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(new { Errors = new[] { $"{ex.Message}" } }));
            }
        }
    }
}
