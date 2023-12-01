using A4S.Application.Handlers.Clientes.Request;
using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.HttpSys;
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

                if (cliente is null) return await Task.FromResult(new NotFoundObjectResult(new { Error = "Não encontrado o Cliente com o GUID passado. " }));

                cliente.RazaoSocial = request.RazaoSocial;
                cliente.Observacoes = request.Observacoes;

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
