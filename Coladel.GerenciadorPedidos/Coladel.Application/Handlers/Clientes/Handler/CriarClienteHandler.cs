using A4S.Application.Handlers.Clientes.Request;
using A4S.Application.Handlers.Clientes.Response;
using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace A4S.Application.Handlers.Clientes
{
    public class CriarClienteHandler : IRequestHandler<CriarClienteRequest, IActionResult>
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IEmailRepository _emailRepository;
        private readonly IEnderecoRepository _enderecoRepository;

        public CriarClienteHandler(IClienteRepository clienteRepository, IEmailRepository emailRepository, IEnderecoRepository enderecoRepository)
        {
            _clienteRepository = clienteRepository;
            _emailRepository = emailRepository;
            _enderecoRepository = enderecoRepository;
        }

        public async Task<IActionResult> Handle(CriarClienteRequest request, CancellationToken cancellationToken)
        {
            try
            {
                Cliente cliente = _clienteRepository.Criar(request.ToModel());

                return await Task.FromResult(new OkObjectResult(new { Produto = new CriarClienteResponse(cliente) }));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(new { Errors = new[] { $"{ex.Message}" } }));
            }
        }
    }
}
