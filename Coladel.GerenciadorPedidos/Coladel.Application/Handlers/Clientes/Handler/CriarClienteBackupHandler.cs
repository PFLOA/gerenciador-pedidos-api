using A4S.Application.Handlers.Clientes.Request;
using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace A4S.Application.Handlers.Clientes.Handler
{
    public class CriarClienteBackupHandler : IRequestHandler<ExportarClientes, IActionResult>
    {
        private readonly IClienteRepository _clienteRepository;

        public CriarClienteBackupHandler(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public async Task<IActionResult> Handle(ExportarClientes request, CancellationToken cancellationToken)
        {
            try
            {

                return await Task.FromResult(new OkResult());
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(new { Errors = new[] { $"{ex.Message}" } }));
            }
        }

        public void CriarCliente(Cliente cliente)
        {
            _clienteRepository.Criar(cliente);
        }
    }
}
