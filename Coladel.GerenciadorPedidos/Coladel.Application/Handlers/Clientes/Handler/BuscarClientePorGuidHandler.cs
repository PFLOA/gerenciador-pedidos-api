using A4S.Application.Handlers.Clientes.Request;
using A4S.Application.Handlers.Clientes.Response;
using A4S.ERP.Application.Handlers.Clientes.Response;
using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace A4S.Application.Handlers.Clientes.Handler
{
    public class BuscarClientePorGuidHandler : IRequestHandler<BuscarClientePorGuidRequest, IActionResult>
    {
        private readonly IClienteRepository _clienteRepository;

        public BuscarClientePorGuidHandler(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<IActionResult> Handle(BuscarClientePorGuidRequest request, CancellationToken cancellationToken)
        {
            try
            {
                Cliente cliente = _clienteRepository.BuscarPorGuid(request.Guid);

                if(cliente is null) return await Task.FromResult(new NotFoundResult());
                return await Task.FromResult(new OkObjectResult(new { OkResult = new BuscarClientePorGuidResponse(cliente) }));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(new { Errors = new[] { $"{ex.Message}" } }));
            }
        }
    }
}
