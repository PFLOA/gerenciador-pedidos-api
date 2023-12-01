using A4S.ERP.Application.Handlers.ContasRecebers.Request;
using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace A4S.ERP.Application.Handlers.ContasRecebers.Handlers
{
    public class CriarContasReceberHandler : IRequestHandler<CriarContasReceberRequest, IActionResult>
    {
        private readonly IContasReceberRepository _contasReceberRepository;

        public CriarContasReceberHandler(IContasReceberRepository contasReceberRepository) =>
            _contasReceberRepository = contasReceberRepository;

        public async Task<IActionResult> Handle(CriarContasReceberRequest request, CancellationToken cancellationToken)
        {
            try
            {
                ContasReceber cliente = _contasReceberRepository.Criar(request.ToModel());

                return await Task.FromResult(new OkObjectResult("Criada Contas a Receber"));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(new { Errors = new[] { $"{ex.Message}" } }));
            }
        }
    }
}
