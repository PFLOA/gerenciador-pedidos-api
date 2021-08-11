using Coladel.Application.Handlers.Clientes.Request;
using Coladel.Application.Handlers.Clientes.Response;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Coladel.Application.Handlers.Clientes
{
  public class CriarClienteHandler : IRequestHandler<CriarClienteRequest, IActionResult>
  {
    private readonly IClienteRepository _clienteRepository;

    public CriarClienteHandler(IClienteRepository produtoRepository)
    {
      _clienteRepository = produtoRepository;
    }
    public async Task<IActionResult> Handle(CriarClienteRequest request, CancellationToken cancellationToken)
    {
      try
      {
        Cliente cliente = _clienteRepository.CriarCliente(request);
        return await Task.FromResult(new OkObjectResult(new { Produto = new CriarClienteResponse(cliente) }));
      }
      catch (Exception ex)
      {
        return await Task.FromResult(new BadRequestObjectResult(new { Errors = new[] { $"{ex.Message}" } }));
      }
    }
  }
}
