using Coladel.GerenciadorPedidos.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coladel.GerenciadorPedidos.Domain.Body
{
  public class CriarClienteRequestBody
  {
    public string NomeCliente { get; set; }
    public virtual Cliente ToModel() => new Cliente(this);
  }
}
