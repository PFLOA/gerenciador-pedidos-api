using A4S.ERP.Application.Handlers.Transportadoras.Request;
using A4S.ERP.Domain.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace A4S.Application.Handlers.Transportadoras.Handler
{
    public class ImportarTransportadoraHandler : IRequestHandler<ImportarTransportadoraRequest, IActionResult>
    {
        private readonly ITransportadoraRepository _transportadoraRepository;

        public ImportarTransportadoraHandler(ITransportadoraRepository transportadoraRepository)
        {
            _transportadoraRepository = transportadoraRepository;
        }
        public async Task<IActionResult> Handle(ImportarTransportadoraRequest request, CancellationToken cancellationToken)
        {
            try
            {
                _transportadoraRepository.Importar(request.Arquivo.OpenReadStream());

                return await Task.FromResult(new OkObjectResult(new { mensagem = "Importação realizada com sucesso " }));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
