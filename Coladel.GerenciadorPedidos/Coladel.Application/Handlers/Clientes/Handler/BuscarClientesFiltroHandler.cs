using A4S.Application.Handlers.Clientes.Request;
using A4S.Application.Handlers.Clientes.Response;
using A4S.Core.Extensions;
using A4S.Core.Results;
using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace A4S.Application.Handlers.Clientes.Handler
{
    public class BuscarClientesFiltroHandler : IRequestHandler<BuscarClientesFiltroRequest, IActionResult>
    {
        private readonly IClienteRepository _clienteRepository;

        public BuscarClientesFiltroHandler(IClienteRepository produtoRepository) => _clienteRepository = produtoRepository;

        public async Task<IActionResult> Handle(BuscarClientesFiltroRequest request, CancellationToken cancellationToken)
        {
            Func<Cliente, BuscarClientesFiltroResponse> retorno = Construtor;
            try
            {
                IQueryable<Cliente> clientes = _clienteRepository.BuscarClientesPorFiltro(request);
                return await Task.FromResult(PaginatedResult<BuscarClientesFiltroResponse>.CreateSuccess(request, clientes, retorno));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(new { Errors = new[] { $"{ex.Message}" } }));
            }
        }

        public BuscarClientesFiltroResponse Construtor(Cliente cliente)
        {
            return new BuscarClientesFiltroResponse(cliente);
        }

    }
}
