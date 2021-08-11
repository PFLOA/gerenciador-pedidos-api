using Coladel.Core.Extensions;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using System;

namespace Coladel.Application.Handlers.Clientes.Response
{
  public class CriarClienteResponse
  {
    public Guid Guid { get; set; }
    public DateTime DataCadastro { get; set; }
    public string NomeCliente { get; set; }
    public CriarClienteResponse(Cliente cliente)
    {
      cliente.MappingProperties(this);
    }
  }
}
