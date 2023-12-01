using A4S.Application.Handlers.Clientes.Request;
using A4S.ERP.Domain.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace A4S.Application.Handlers.Clientes.Handler
{
    public class RemoverClienteHandler : IRequestHandler<RemoverClienteRequest, IActionResult>
    {
        private readonly IClienteRepository _clienteRepository;

        public RemoverClienteHandler(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<IActionResult> Handle(RemoverClienteRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var cliente = _clienteRepository.BuscarPorGuid(request.Guid);
                _clienteRepository.Remover(cliente);

                return await Task.FromResult(new OkObjectResult(new { Cliente = cliente }));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(new { Errors = new[] { $"{ex.Message}" } }));
            }
        }
    }
}
