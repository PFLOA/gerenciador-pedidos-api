using A4S.Application.Handlers.Clientes.Request;
using A4S.GerenciadorAulas.Domain.Entidades;
using A4S.GerenciadorAulas.Domain.Interface;
using A4S.GerenciadorPedidos.Domain.Entidades;
using A4S.GerenciadorPedidos.Domain.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace A4S.Application.Handlers.Clientes.Handler
{
    public class AlterarClienteHandler : IRequestHandler<AlterarClienteRequest, IActionResult>
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IEmailRepository _emailRepository;

        public AlterarClienteHandler(IClienteRepository clienteRepository, IEmailRepository emailRepository)
        {
            _clienteRepository = clienteRepository;
            _emailRepository = emailRepository;
        }

        public async Task<IActionResult> Handle(AlterarClienteRequest request, CancellationToken cancellationToken)
        {
            try
            {
                Cliente cliente = _clienteRepository.BuscarPorGuid(request.Guid);

                request.EmailRequest.ForEach(email =>
                {
                    if (email.Id == 0)
                        cliente.Emails.Add(new Email
                        {
                            Descricao = email.Email,
                            Guid = Guid.NewGuid(),
                            Cliente = cliente,
                        });
                });

                if (cliente is null) return await Task.FromResult(new NotFoundObjectResult(new { Error = "Não encontrado o Cliente com o GUID passado. " }));

                cliente.NomeCliente = request.NomeCliente;

                _clienteRepository.Alterar(cliente);

                return await Task.FromResult(new OkResult());
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(new { Error = ex.Message }));
                throw;
            }
        }
    }
}
