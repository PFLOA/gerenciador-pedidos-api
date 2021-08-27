using Coladel.Application.Handlers.Clientes.Request;
using Coladel.Application.Handlers.Clientes.Response;
using Coladel.Core.Extensions;
using Coladel.Core.Results;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Coladel.Application.Handlers.Clientes.Handler
{
    public class BuscarClientesFiltroHandler : IRequestHandler<BuscarClientesFiltroRequest, IActionResult>
    {
        private readonly IRepository _clienteRepository;

        public BuscarClientesFiltroHandler(IRepository produtoRepository)
        {
            _clienteRepository = produtoRepository;
        }
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
