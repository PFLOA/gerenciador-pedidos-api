using Coladel.Application.Handlers.Clientes.Response;
using Coladel.Application.Handlers.Clientes.Request;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Interface;
using Coladel.GerenciadorAulas.Domain.Entidades;
using Coladel.GerenciadorAulas.Domain.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Threading;
using MediatR;
using System;

namespace Coladel.Application.Handlers.Clientes
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

                request.EmailRequest.ForEach(email =>
                {
                    _emailRepository.Criar(new Email
                    {
                        Cliente = cliente,
                        Descricao = email
                    });
                });

                return await Task.FromResult(new OkObjectResult(new { Produto = new CriarClienteResponse(cliente) }));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(new { Errors = new[] { $"{ex.Message}" } }));
            }
        }
    }
}
