using Coladel.Core.Extensions;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using System;

namespace Coladel.Application.Handlers.Produtos.Response
{
    public class BuscarProdutosFiltroResponse
    {
        public Guid Guid { get; set; }
        public string NomeProduto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public BuscarProdutosFiltroResponse(Produto produto) => produto.MappingProperties(this);
    }
}
