using A4S.ERP.Application.Handlers.Clientes.Request;
using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace A4S.ERP.Application.Handlers.Clientes.Handler
{
    public class ImportarClientesHandler : IRequestHandler<ImportarClientesRequest, IActionResult>
    {
        private readonly IClienteRepository _clienteRepository;

        public ImportarClientesHandler(IClienteRepository clienteRepository) => _clienteRepository = clienteRepository;

        public async Task<IActionResult> Handle(ImportarClientesRequest request, CancellationToken cancellationToken)
        {
            try
            {
                if (request.Arquivo.ContentType == "application/json") _clienteRepository.Importar(request.Arquivo.OpenReadStream());
                else
                    _clienteRepository.Importar((entrada) => new Cliente
                    {
                        DocumentoPrincipal = entrada[12],
                        NomeFantasia = entrada[20],
                        Endereco = new Endereco
                        {
                            Cep = entrada[6],
                            Bairro = entrada[5],
                            Cidade = entrada[7],
                            Complemento = entrada[23],
                            Estado = entrada[8],
                            Logradouro = entrada[4]
                        }
                    }, request.Arquivo.OpenReadStream());

                return await Task.FromResult(new OkObjectResult(new { mensagem = "Importação realizada com sucesso " }));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
