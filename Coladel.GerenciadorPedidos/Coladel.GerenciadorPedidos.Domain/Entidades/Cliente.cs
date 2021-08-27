using Coladel.Core.Extensions;
using Coladel.GerenciadorPedidos.Domain.Body;

namespace Coladel.GerenciadorPedidos.Domain.Entidades
{
  public class Cliente : Entity
  {
    public string NomeCliente { get; set; }
    public Cliente() { }
    public Cliente(CriarClienteRequestBody requestBody)  => requestBody.MappingProperties(this);
  }
}
