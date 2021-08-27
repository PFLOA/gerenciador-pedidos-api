using Coladel.Core.Extensions;
using Coladel.GerenciadorPedidos.Domain.Body;
using Coladel.GerenciadorPedidos.Domain.Enum;
using System.Collections.Generic;

namespace Coladel.GerenciadorPedidos.Domain.Entidades
{
    public class Pedido : Entity
    {
        public StatusPedido StatusPedido { get; set; }
        public virtual Cliente Cliente { get; set; }
        public List<Produto> ProdutosList { get; set; }
        public string NF { get; set; }
        public string Observacoes { get; set; }
        public short IdCliente { get; set; }
        public decimal Total { get; set; }
        public Pedido() { }
        public Pedido(CriarPedidoBody criarPedidoBody) => criarPedidoBody.MappingProperties(this);
    }
}
