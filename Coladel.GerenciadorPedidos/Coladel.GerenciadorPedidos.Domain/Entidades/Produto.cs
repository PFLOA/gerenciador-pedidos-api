using Coladel.Core.Extensions;
using Coladel.GerenciadorPedidos.Domain.Body;
using System.Collections.Generic;

namespace Coladel.GerenciadorPedidos.Domain.Entidades
{
    public class Produto : Entity
    {
        public string NomeProduto { get; set; }
        public decimal Preco { get; set; }
        public ICollection<ItensPedido> ItensPedido { get; set; }
        public Produto() { }
        public Produto(CriarProdutoRequestBody criarProdutoRequestBody) => criarProdutoRequestBody.MappingProperties(this);
    }
}
