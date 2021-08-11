using Coladel.Core.Extensions;
using Coladel.GerenciadorPedidos.Domain.Body;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coladel.GerenciadorPedidos.Domain.Entidades
{
  public class Produto : Entity<short>
  {
    public string NomeProduto { get; set; }
    public decimal Preco { get; set; }
    public Produto()
    {

    }
    public Produto(CriarProdutoRequestBody criarProdutoRequestBody)
    {
      criarProdutoRequestBody.MappingProperties(this);
    }
  }
}
